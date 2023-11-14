namespace otomatateorisiproject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAlphabet = new System.Windows.Forms.TextBox();
            this.textBoxRegex = new System.Windows.Forms.TextBox();
            this.textBoxWordCount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRegex = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxAlphabet = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBoxGeneratedWord = new System.Windows.Forms.RichTextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alfabeyi Tanımlayınız (Virgül ile ayırınız.) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Düzenli İfadeyi Tanımlayınız (Örnek : (a+b)*a) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kaç Kelime Üretmek İstiyorsunuz? :";
            // 
            // textBoxAlphabet
            // 
            this.textBoxAlphabet.Location = new System.Drawing.Point(467, 51);
            this.textBoxAlphabet.Name = "textBoxAlphabet";
            this.textBoxAlphabet.Size = new System.Drawing.Size(161, 22);
            this.textBoxAlphabet.TabIndex = 3;
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.Location = new System.Drawing.Point(467, 99);
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(161, 22);
            this.textBoxRegex.TabIndex = 4;
            // 
            // textBoxWordCount
            // 
            this.textBoxWordCount.Location = new System.Drawing.Point(467, 155);
            this.textBoxWordCount.Name = "textBoxWordCount";
            this.textBoxWordCount.Size = new System.Drawing.Size(161, 22);
            this.textBoxWordCount.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "ÜRET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonGenerate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Düzenli İfadeniz :";
            // 
            // labelRegex
            // 
            this.labelRegex.AutoSize = true;
            this.labelRegex.Location = new System.Drawing.Point(148, 310);
            this.labelRegex.Name = "labelRegex";
            this.labelRegex.Size = new System.Drawing.Size(13, 17);
            this.labelRegex.TabIndex = 8;
            this.labelRegex.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Alfabeniz :";
            // 
            // richTextBoxAlphabet
            // 
            this.richTextBoxAlphabet.Location = new System.Drawing.Point(290, 310);
            this.richTextBoxAlphabet.Name = "richTextBoxAlphabet";
            this.richTextBoxAlphabet.Size = new System.Drawing.Size(50, 263);
            this.richTextBoxAlphabet.TabIndex = 10;
            this.richTextBoxAlphabet.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Üretilen Kelimeler :";
            // 
            // richTextBoxGeneratedWord
            // 
            this.richTextBoxGeneratedWord.Location = new System.Drawing.Point(558, 306);
            this.richTextBoxGeneratedWord.Name = "richTextBoxGeneratedWord";
            this.richTextBoxGeneratedWord.Size = new System.Drawing.Size(206, 263);
            this.richTextBoxGeneratedWord.TabIndex = 12;
            this.richTextBoxGeneratedWord.Text = "";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(438, 211);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(98, 32);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "TEMİZLE";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 606);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.richTextBoxGeneratedWord);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBoxAlphabet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelRegex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxWordCount);
            this.Controls.Add(this.textBoxRegex);
            this.Controls.Add(this.textBoxAlphabet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAlphabet;
        private System.Windows.Forms.TextBox textBoxRegex;
        private System.Windows.Forms.TextBox textBoxWordCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRegex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxAlphabet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBoxGeneratedWord;
        private System.Windows.Forms.Button buttonClear;
    }
}

