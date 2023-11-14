using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomatateorisiproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate(object sender, EventArgs e)
        {
            string alphabet = textBoxAlphabet.Text;
            string regex = textBoxRegex.Text;
            int wordCount = Convert.ToInt32(textBoxWordCount.Text);

            string[] lettersArray = alphabet.Split(',');

            for (int i = 0; i < lettersArray.Length; i++)
            {
                lettersArray[i] = lettersArray[i].Trim();
            }

            char[] charCharacters = regex.ToCharArray();
            string[] stringCharacters = new string[charCharacters.Length + 1];

            string inParentheses;
            string[] inParenthesesSplit = null;
            Random random = new Random();
            string generatedWord = "";

            for (int j = 0; j < charCharacters.Length; j++)
            {
                stringCharacters[j] = charCharacters[j].ToString();
            }

            char[] charLetters = new char[charCharacters.Length];
            int charCharactersIndex = 0;
            bool letterError = false;


            foreach (char c in charCharacters)
            {
                if (Char.IsLetter(c) && c >= 'a' && c <= 'z')
                {
                    charLetters[charCharactersIndex++] = c;
                }
            }

            string[] lettersOfRegexArray = new string[charCharactersIndex];
            for (int j = 0; j < charCharactersIndex; j++)
            {
                lettersOfRegexArray[j] = charLetters[j].ToString();
            }

            for (int i = 0; i < lettersOfRegexArray.Length; i++)
            {
                bool letterMatch = false;

                for (int j = 0; j < lettersArray.Length; j++)
                {
                    if (lettersOfRegexArray[i] == lettersArray[j])
                    {
                        letterMatch = true;
                        break;
                    }
                }

                if (!letterMatch)
                {
                    MessageBox.Show("Düzenli ifadede, alfabede bulunmayan bir harf var!");
                    letterError = true;
                    break;
                }
            }

            if (!letterError)
            {
                foreach (string letter in lettersArray)
                {
                    if (!string.IsNullOrEmpty(letter))
                    {
                        richTextBoxAlphabet.AppendText(letter + Environment.NewLine);
                    }
                }

                labelRegex.Text = regex;

                for (int w = 0; w < wordCount; w++)
                {
                    generatedWord = "";

                    for (int i = 0; i < stringCharacters.Length; i++)
                    {
                        if (stringCharacters[i] == null)
                        {
                            break;
                        }

                        else if (stringCharacters[i] == "(")
                        {
                            inParentheses = "";
                            i++;

                            while (i < stringCharacters.Length && stringCharacters[i] != ")")
                            {
                                inParentheses = inParentheses + stringCharacters[i];
                                i++;
                            }

                            inParenthesesSplit = inParentheses.Split('+');

                            if (stringCharacters[i] == ")" && stringCharacters[i + 1] == "*")
                            {

                                int randomWordLength = random.Next(0, 10);
                                for (int t = 0; t < randomWordLength; t++)
                                {
                                    int randomLetter = random.Next(0, inParenthesesSplit.Length);
                                    generatedWord += inParenthesesSplit[randomLetter];
                                }
                            }
                            else if (stringCharacters[i] == ")" && stringCharacters[i + 1] != "*")
                            {

                                int randomLetter = random.Next(0, inParenthesesSplit.Length);
                                generatedWord += inParenthesesSplit[randomLetter];
                            }
                        }
                        else if (stringCharacters[i] == "*")
                        {
                        }
                        else if ((i == 0 && stringCharacters[i + 1] != "+") || (i > 0 && stringCharacters[i - 1] != "+" && stringCharacters[i + 1] != "+"))
                        {
                            if (stringCharacters[i + 1] == "*")
                            {
                                int randomWordLength = random.Next(0, 10);
                                for (int m = 0; m < randomWordLength; m++)
                                {
                                    generatedWord += stringCharacters[i];
                                }
                            }
                            else
                            {
                                generatedWord += stringCharacters[i];
                            }
                        }
                    }

                    richTextBoxGeneratedWord.AppendText(generatedWord + Environment.NewLine);
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxAlphabet.Clear();
            textBoxRegex.Clear();
            textBoxWordCount.Clear();
            richTextBoxAlphabet.Clear();
            richTextBoxGeneratedWord.Clear();
            labelRegex.Text = "";
        }
    }
}
