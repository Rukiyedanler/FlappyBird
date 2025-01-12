namespace FlappyBird2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bird = new PictureBox();
            zemin = new PictureBox();
            engel2 = new PictureBox();
            engel1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            skoryazi = new Label();
            engel3 = new PictureBox();
            engel4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zemin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)engel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)engel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)engel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)engel4).BeginInit();
            SuspendLayout();
            // 
            // bird
            // 
            bird.BackColor = Color.Transparent;
            bird.Image = (Image)resources.GetObject("bird.Image");
            bird.Location = new Point(24, 294);
            bird.Name = "bird";
            bird.Size = new Size(57, 48);
            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.TabIndex = 0;
            bird.TabStop = false;
            // 
            // zemin
            // 
            zemin.Image = (Image)resources.GetObject("zemin.Image");
            zemin.Location = new Point(-4, 526);
            zemin.Name = "zemin";
            zemin.Size = new Size(1152, 76);
            zemin.SizeMode = PictureBoxSizeMode.StretchImage;
            zemin.TabIndex = 1;
            zemin.TabStop = false;
            // 
            // engel2
            // 
            engel2.BackColor = Color.Transparent;
            engel2.Image = (Image)resources.GetObject("engel2.Image");
            engel2.Location = new Point(519, -12);
            engel2.Name = "engel2";
            engel2.Size = new Size(70, 242);
            engel2.SizeMode = PictureBoxSizeMode.StretchImage;
            engel2.TabIndex = 2;
            engel2.TabStop = false;
            // 
            // engel1
            // 
            engel1.BackColor = Color.Transparent;
            engel1.Image = (Image)resources.GetObject("engel1.Image");
            engel1.Location = new Point(519, 378);
            engel1.Name = "engel1";
            engel1.Size = new Size(67, 494);
            engel1.SizeMode = PictureBoxSizeMode.StretchImage;
            engel1.TabIndex = 3;
            engel1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 35;
            timer1.Tick += timer1event;
            // 
            // skoryazi
            // 
            skoryazi.AutoSize = true;
            skoryazi.BackColor = Color.Transparent;
            skoryazi.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            skoryazi.ForeColor = Color.DarkGreen;
            skoryazi.Location = new Point(12, 9);
            skoryazi.Name = "skoryazi";
            skoryazi.Size = new Size(117, 29);
            skoryazi.TabIndex = 4;
            skoryazi.Text = "Score : 0";
            // 
            // engel3
            // 
            engel3.BackColor = Color.Transparent;
            engel3.Location = new Point(816, 432);
            engel3.Name = "engel3";
            engel3.Size = new Size(67, 97);
            engel3.SizeMode = PictureBoxSizeMode.StretchImage;
            engel3.TabIndex = 5;
            engel3.TabStop = false;
            // 
            // engel4
            // 
            engel4.BackColor = Color.Transparent;
            engel4.Location = new Point(813, -10);
            engel4.Name = "engel4";
            engel4.Size = new Size(70, 284);
            engel4.SizeMode = PictureBoxSizeMode.StretchImage;
            engel4.TabIndex = 6;
            engel4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(598, 589);
            Controls.Add(engel2);
            Controls.Add(zemin);
            Controls.Add(engel4);
            Controls.Add(engel3);
            Controls.Add(bird);
            Controls.Add(skoryazi);
            Controls.Add(engel1);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "Form1";
            Text = " ";
            KeyDown += down;
            KeyUp += up;
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)zemin).EndInit();
            ((System.ComponentModel.ISupportInitialize)engel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)engel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)engel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)engel4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bird;
        private PictureBox zemin;
        private PictureBox engel2;
        private PictureBox engel1;
        private System.Windows.Forms.Timer timer1;
        private Label skoryazi;
        private PictureBox engel3;
        private PictureBox engel4;
    }
}
