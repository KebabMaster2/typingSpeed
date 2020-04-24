namespace typingSpeed
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
            this.components = new System.ComponentModel.Container();
            this.sourceText = new System.Windows.Forms.Label();
            this.TargetText = new System.Windows.Forms.TextBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.typingProgress = new System.Windows.Forms.ProgressBar();
            this.TypingTimer = new System.Windows.Forms.Timer(this.components);
            this.timeProgress = new System.Windows.Forms.ProgressBar();
            this.CurrentCPM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceText
            // 
            this.sourceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceText.Location = new System.Drawing.Point(64, 36);
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(653, 52);
            this.sourceText.TabIndex = 0;
            this.sourceText.Text = "A contango market implies oil traders believe crude prices will rally in the futu" +
    "re, encouraging them to store oil now and to sell at a later date.";
            // 
            // TargetText
            // 
            this.TargetText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetText.Location = new System.Drawing.Point(68, 110);
            this.TargetText.Multiline = true;
            this.TargetText.Name = "TargetText";
            this.TargetText.Size = new System.Drawing.Size(611, 103);
            this.TargetText.TabIndex = 1;
            this.TargetText.TextChanged += new System.EventHandler(this.textBoxTextType_TextChanged);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::typingSpeed.Properties.Resources.closeRed;
            this.pictureBoxClose.Location = new System.Drawing.Point(647, 309);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.pictureBoxClose_MouseLeave);
            // 
            // typingProgress
            // 
            this.typingProgress.Location = new System.Drawing.Point(68, 230);
            this.typingProgress.Name = "typingProgress";
            this.typingProgress.Size = new System.Drawing.Size(611, 28);
            this.typingProgress.TabIndex = 3;
            // 
            // TypingTimer
            // 
            this.TypingTimer.Interval = 1000;
            this.TypingTimer.Tick += new System.EventHandler(this.timeProgress_Tick);
            // 
            // timeProgress
            // 
            this.timeProgress.Location = new System.Drawing.Point(68, 275);
            this.timeProgress.Name = "timeProgress";
            this.timeProgress.Size = new System.Drawing.Size(611, 28);
            this.timeProgress.TabIndex = 4;
            // 
            // CurrentCPM
            // 
            this.CurrentCPM.AutoSize = true;
            this.CurrentCPM.Location = new System.Drawing.Point(84, 333);
            this.CurrentCPM.Name = "CurrentCPM";
            this.CurrentCPM.Size = new System.Drawing.Size(79, 13);
            this.CurrentCPM.TabIndex = 5;
            this.CurrentCPM.Text = "Current CPM: 0";
            this.CurrentCPM.Click += new System.EventHandler(this.CurrentCPM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.CurrentCPM);
            this.Controls.Add(this.timeProgress);
            this.Controls.Add(this.typingProgress);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.TargetText);
            this.Controls.Add(this.sourceText);
            this.Name = "Form1";
            this.Text = "Typing Speed Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sourceText;
        private System.Windows.Forms.TextBox TargetText;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.ProgressBar typingProgress;
        private System.Windows.Forms.Timer TypingTimer;
        private System.Windows.Forms.ProgressBar timeProgress;
        private System.Windows.Forms.Label CurrentCPM;
    }
}

