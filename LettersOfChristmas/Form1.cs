using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettersOfChristmas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += (sender, args) =>
            {
                LetterGenerator l = new LetterGenerator();
                string[] emails = {textBox1.Text, textBox2.Text};
                var emailsWithLetters = l.GetLettersFromEmailsAndCount(emails, (int) numericUpDown1.Value);
                
                foreach (var em in emailsWithLetters)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(em.Email + ": ");
                    foreach (var letter in em.Letters)
                        sb.Append(letter + " ");
                    MessageBox.Show(this, sb.ToString());
                }

                
            };
        }
    }
}
