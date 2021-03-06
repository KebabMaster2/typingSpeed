﻿using System;
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
        public Form1()
        {
            InitializeComponent();
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
            string lablString = labelTextOriginal.Text.Substring(0, characterCount);
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
            string lablString = labelTextOriginal.Text.Substring(0, characterCount);           
            textBoxTextType.MaxLength = characterCount;
            textBoxTextType.ForeColor = Color.Red;
            
        }
        private void AllowTyping()
        {
            textBoxTextType.MaxLength = labelTextOriginal.Text.Length;
            textBoxTextType.ForeColor = Color.Black;
        }
    }
}
