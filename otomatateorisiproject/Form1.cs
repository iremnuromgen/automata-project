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
            //kullanıcıdan ilk olarak alfabeyi, düzenli ifadeyi ve üretmek istediği kelime sayısı bilgisini alıyorum.
            string alphabet = textBoxAlphabet.Text;
            string regex = textBoxRegex.Text;
            int numberOfWord = Convert.ToInt32(textBoxNumberOfWord.Text);

            //letters isminde bir dizi oluşturup Split işlemi ile virgülle ayırarak her birinin farklı bir karakter olarak algılanmasını sağlıyorum
            string[] letters = alphabet.Split(',');

            //bir for döngüsü oluşturup Trim özelliği ile letters dizisindeki karakterlerin başındaki ve sonundaki boşlukları kaldırıyorum. Bu şekilde virgülden sonra boşluk koyulduysa harfin boşlukla yazılmasını engellemiş olacağım.
            for(int i=0; i<letters.Length ;i++)
            {
                letters[i] = letters[i].Trim();
            }

            //daha sonra bir foreach döngüsü oluşturdum. letters dizisi üzerinde dolaşıp her letter karakterinin boş veya null olup olmadığını kontrol ettirerek richtextboxa alt alta gelecek şekilde yazdırdım.
            foreach (string letter in letters)
            {
                if(!string.IsNullOrEmpty(letter))
                {
                    richTextBoxAlphabet.AppendText(letter + Environment.NewLine);
                }
            }

            labelRegex.Text = regex;
        }
    }
}
