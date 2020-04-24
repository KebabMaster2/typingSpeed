using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace typingSpeed
{
    public partial class Form1 : Form
    {
        int sec = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeTypingProgress();
            InitializeTypingTimer();
        }
        private void InitializeTypingTimer()
        {
            TypingTimer.Interval = 1000;
            TypingTimer.Start();
        }
        private void InitializeTypingProgress()
        {
            typingProgress.Maximum = sourceText.Text.Length;
            timeProgress.Maximum = 60;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxClose.Image = Properties.Resources.closeBlue;
        }

        private void pictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClose.Image = Properties.Resources.closeRed;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxTextType_TextChanged(object sender, EventArgs e)
        {
            if (TextsAreSame())
            {
                AllowTyping();
                typingProgress.Value = textBoxTextType.Text.Length;
            }
            else
            {
                BlockTyping();
            }
        }

        private bool TextsAreSame()
        {
            int characterCount;
            characterCount = textBoxTextType.Text.Length;
            string lablString = sourceText.Text.Substring(0, characterCount);
            if (textBoxTextType.Text != lablString)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void BlockTyping()
        {
            int characterCount;
            characterCount = textBoxTextType.Text.Length;
            string lablString = sourceText.Text.Substring(0, characterCount);           
            textBoxTextType.MaxLength = characterCount;
            textBoxTextType.ForeColor = Color.Red;
            
        }
        private void AllowTyping()
        {
            textBoxTextType.MaxLength = sourceText.Text.Length;
            textBoxTextType.ForeColor = Color.Black;
        }

        private void timeProgress_Tick(object sender, EventArgs e)
        {
            sec += 1;
            timeProgress.Value = sec;
        }
    }
}
