using System;
using System.Drawing;
using System.Windows.Forms;

namespace typingSpeed
{
    public partial class Form1 : Form
    {
        int sec = 0;
        bool typingStarted = false;
        public Form1()
        {
            InitializeComponent();
            InitializeTypingProgress();
            InitializeTypingTimer();
        }
        private void InitializeTypingTimer()
        {
            TypingTimer.Interval = 1000;
            
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
            if (!typingStarted)
            {
                TypingTimer.Start();
                typingStarted = true;
            }
            if (TextsAreSame())
            {
                AllowTyping();
                typingProgress.Value = TargetText.Text.Length;
                if (TargetText.Text.Length == sourceText.Text.Length)
                {
                    TypingOver();
                }
            }
            else
            {
                BlockTyping();
            }
            UpdateCurrentCPM();
        }
        private void UpdateCurrentCPM()
        {
            CurrentCPM.Text = "Current CPM: " + CalculateCPM();
        }

        private bool TextsAreSame()
        {
            int characterCount;
            characterCount = TargetText.Text.Length;
            string lablString = sourceText.Text.Substring(0, characterCount);
            if (TargetText.Text != lablString)
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
            characterCount = TargetText.Text.Length;
            string lablString = sourceText.Text.Substring(0, characterCount);
            TargetText.MaxLength = characterCount;
            TargetText.ForeColor = Color.Red;

        }
        private void AllowTyping()
        {
            TargetText.MaxLength = sourceText.Text.Length;
            TargetText.ForeColor = Color.Black;
        }

        private void timeProgress_Tick(object sender, EventArgs e)
        {
            
            sec += 1;           
            try
            {
                timeProgress.Value = sec;
            }
            catch 
            {

            }
            UpdateCurrentCPM();


        }
        private int CalculateCPM()
        {
            int cpm;
            try
            {
                cpm= TargetText.Text.Length * 60 / sec;
                return cpm;
            }
            catch (Exception)
            {
                return 0;

            }

        }
        private void TypingOver()
        {
            TypingTimer.Stop();
            MessageBox.Show("Time is up! Your result is " + CalculateCPM());
        }

        private void CurrentCPM_Click(object sender, EventArgs e)
        {

        }
    }
}
