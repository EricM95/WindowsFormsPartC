using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsPartC.Unit7
{
    /// <summary>
    /// This form will draw the screen
    /// when keys are pressed
    /// 
    /// Modified by: Eric Man
    /// </summary>
    public partial class SketchForm : Form
    {
        private Bitmap canvas;

        private int x = 300;
        private int y = 200;

        private int penSize = 10;

        private bool keyPressed = false;
        private string keyName;
        DialogResult response;

        public SketchForm()
        {
            InitializeComponent();
        }

        private void SketchForm_Load(object sender, EventArgs e)
        {
            canvas = new Bitmap(sketchPanel.Width, sketchPanel.Height);
            Graphics g = Graphics.FromImage(canvas);
            g.FillEllipse(Brushes.Red, x, y, penSize, penSize);
            sketchPanel.BackgroundImage = canvas;
        }

        /// <summary>
        /// This method will draw the screen
        /// when the user presses up, down, 
        /// left and right keys. 
        /// </summary>
        /// <param name="g"></param>
        private void drawPoint(Graphics g)
        {
            if (keyName == "Right")
            {
                x = x + penSize / 2;
            }
            else if (keyName == "Left")
            {
                x = x - penSize / 2;
            }
            else if (keyName == "Up")
            {
                y = y - penSize / 2;
            }
            else if (keyName == "Down")
            {
                y = y + penSize / 2;
            }
            else if (keyName == "Escape")
            {
                response = MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else if (keyName == "C")
            {
                SketchForm sketchForm = new SketchForm();
                sketchForm.Show();
                this.Dispose(false);
            }

            if (keyPressed)
                g.FillEllipse(Brushes.Red, x, y, penSize, penSize);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            keyName = keyData.ToString();
            keyPressed = true;

            Refresh();
            return true;
        }

        private void sketchPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(sketchPanel.BackgroundImage);
            drawPoint(g);
        }

    }
}
