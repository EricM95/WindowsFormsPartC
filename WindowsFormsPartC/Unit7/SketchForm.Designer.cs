namespace WindowsFormsPartC.Unit7
{
    partial class SketchForm
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
            this.sketchPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sketchPanel
            // 
            this.sketchPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sketchPanel.BackColor = System.Drawing.Color.Bisque;
            this.sketchPanel.Location = new System.Drawing.Point(47, 61);
            this.sketchPanel.Name = "sketchPanel";
            this.sketchPanel.Size = new System.Drawing.Size(997, 476);
            this.sketchPanel.TabIndex = 0;
            this.sketchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sketchPanel_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(257, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eric\'s Etch a Sketch Project";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SketchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1098, 663);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sketchPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SketchForm";
            this.Text = "Sketch Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SketchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sketchPanel;
        private System.Windows.Forms.Label label1;
    }
}