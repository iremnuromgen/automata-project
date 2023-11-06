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
            int numberOfWord = Convert.ToInt32(textBoxNumberOfWord.Text);
            
            string[] letters = alphabet.Split(',');

            for(int i=0; i<letters.Length ;i++)
            {
                letters[i] = letters[i].Trim();
            }

            foreach (string letter in letters)
            {
                if(!string.IsNullOrEmpty(letter))
                {
                    richTextBoxAlphabet.AppendText(letter + Environment.NewLine);
                }
            }

            labelRegex.Text = regex;

            char[] characters = regex.ToCharArray();
            string[] character = new string[characters.Length + 1];
            string parentheses;
            string[] parenthesesSplit = null;
            int kleeneStar = 0;
            Random random = new Random();
            string generatedWord ="";


            for (int i=0;i<characters.Length;i++)
            {
                character[i] = characters[i].ToString();
            }

            for(int i = 0 ; i < character.Length ; i++)
            {
                if(character[i] == null)
                {
                    break;
                }
                else if(character[i] == "(")
                {
                    parentheses = "";
                    i++;
                    while(i < character.Length && character[i] != ")")
                    {
                        parentheses += character[i];
                        i++;
                    }
                    if(i < character.Length && character[i] == ")")
                    {
                        i++;
                        if(i < character.Length && character[i] == "*")
                        {
                            kleeneStar = 1;
                        }
                    }
                    parenthesesSplit = parentheses.Split('+');
                }
                else if(character[i] == "*")
                {
                }
            }

            if (kleeneStar == 1)
            {
                int wordLength = 0;

                for (int j = 0; j < numberOfWord; j++)
                {
                    generatedWord = "";
                    for (int k = 0; k < wordLength; k++)
                    {
                        int randomIndex = random.Next(0, parenthesesSplit.Length);
                        generatedWord += parenthesesSplit[randomIndex];
                    }
                    richTextBoxGeneratedWords.AppendText(generatedWord + Environment.NewLine);

                    wordLength++;
                }
            }
        }
    }
}
