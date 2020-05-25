namespace WindowsFormsPartC
{
    partial class Bouncing_ball
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
            this.ballPictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ballPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ballPictureBox
            // 
            this.ballPictureBox.BackColor = System.Drawing.Color.Moccasin;
            this.ballPictureBox.Location = new System.Drawing.Point(31, 40);
            this.ballPictureBox.Name = "ballPictureBox";
            this.ballPictureBox.Size = new System.Drawing.Size(741, 309);
            this.ballPictureBox.TabIndex = 0;
            this.ballPictureBox.TabStop = false;
            this.ballPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ballPicturePoint_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.moveBall);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(157, 372);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(117, 56);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(323, 372);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(115, 56);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(493, 372);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(106, 56);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Bouncing_ball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.ballPictureBox);
            this.Name = "Bouncing_ball";
            this.Text = "Eric\'s Bouncing Ball";
            this.Load += new System.EventHandler(this.Bouncing_ball_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ballPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ballPictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button quitButton;
    }
}