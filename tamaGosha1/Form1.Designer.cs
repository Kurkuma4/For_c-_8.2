namespace tamaGosha1
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
            buttonPlay = new Button();
            progressBarHunger = new ProgressBar();
            progressBarEnergy = new ProgressBar();
            progressBarHappy = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            buttonSleep = new Button();
            buttonFeed = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonPlay
            // 
            buttonPlay.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonPlay.Location = new Point(746, 306);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(117, 59);
            buttonPlay.TabIndex = 0;
            buttonPlay.Text = "ПОГРАТИ";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // progressBarHunger
            // 
            progressBarHunger.Location = new Point(573, 149);
            progressBarHunger.Name = "progressBarHunger";
            progressBarHunger.Size = new Size(100, 23);
            progressBarHunger.TabIndex = 3;
            // 
            // progressBarEnergy
            // 
            progressBarEnergy.Location = new Point(573, 239);
            progressBarEnergy.Name = "progressBarEnergy";
            progressBarEnergy.Size = new Size(100, 23);
            progressBarEnergy.TabIndex = 4;
            // 
            // progressBarHappy
            // 
            progressBarHappy.Location = new Point(573, 325);
            progressBarHappy.Name = "progressBarHappy";
            progressBarHappy.Size = new Size(100, 23);
            progressBarHappy.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(595, 131);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 6;
            label1.Text = "ГОЛОД";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(591, 221);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 7;
            label2.Text = "ЕНЕРГІЯ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(595, 306);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 8;
            label3.Text = "ЩАСТЯ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(133, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 307);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(179, 39);
            label4.Name = "label4";
            label4.Size = new Size(212, 25);
            label4.TabIndex = 10;
            label4.Text = "мене звати Г О Ш А ";
            // 
            // buttonSleep
            // 
            buttonSleep.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonSleep.Location = new Point(746, 221);
            buttonSleep.Name = "buttonSleep";
            buttonSleep.Size = new Size(117, 59);
            buttonSleep.TabIndex = 11;
            buttonSleep.Text = "ДАТИ ПОСПАТИ";
            buttonSleep.UseVisualStyleBackColor = true;
            buttonSleep.Click += buttonSleep_Click;
            // 
            // buttonFeed
            // 
            buttonFeed.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonFeed.Location = new Point(746, 131);
            buttonFeed.Name = "buttonFeed";
            buttonFeed.Size = new Size(117, 59);
            buttonFeed.TabIndex = 12;
            buttonFeed.Text = "ГОДУВАТИ";
            buttonFeed.UseVisualStyleBackColor = true;
            buttonFeed.Click += buttonFeed_Click;
            // 
            // timer1
            // 
            timer1.Interval = 6000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 512);
            Controls.Add(buttonFeed);
            Controls.Add(buttonSleep);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBarHappy);
            Controls.Add(progressBarEnergy);
            Controls.Add(progressBarHunger);
            Controls.Add(buttonPlay);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPlay;
        private ProgressBar progressBarHunger;
        private ProgressBar progressBarEnergy;
        private ProgressBar progressBarHappy;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Button buttonSleep;
        private Button buttonFeed;
        private System.Windows.Forms.Timer timer1;
    }
}
