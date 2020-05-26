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
        public const int BYTE = 256;
        private Bitmap canvas;

        private int x = 300;
        private int y = 200;

        private int penSize = 10;

        private bool keyPressed = false;
        private string keyName;
        DialogResult response;

        private Random generator = new Random();

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
        /// when the user presses keys.
        /// </summary>
        /// <param name="g"></param>
        private void drawPoint(Graphics g)
        {
            Brush myBrush = new SolidBrush(getRandomColor());
            Rectangle rectangle = new Rectangle(x, y, penSize, penSize);

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
            else if (keyName == "Up" && keyName == "Left")
            {
                x = x + penSize / 2;
                y = y + penSize / 2;
            }
            else if (keyName == "Up" && keyName == "Right")
            {
                y = y - penSize / 2;
                x = x + penSize / 2;
            }
            else if (keyName == "Down" && keyName == "Right")
            {
                y = y - penSize / 2;
                x = x - penSize / 2;
            }
            else if (keyName == "Down" && keyName == "Left")
            {
                y = y + penSize / 2;
                x = x - penSize / 2;
            }
            else if (keyName == "B")
            {
                penSize = penSize + 1;
            }
            else if (keyName == "S")
            {
                penSize = penSize - 1;
            }
            else if (keyName == "F1")
            {
                g.FillEllipse(myBrush, rectangle);
            }
            else if (keyName == "F2")
            {
                this.BackColor = getRandomColor();
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
               // g.FillEllipse(Brushes.Red, rectangle);
            g.FillEllipse(myBrush, rectangle);
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
        private Color getRandomColor()
        {
            int r, g, b;

            r = generator.Next(BYTE);
            g = generator.Next(BYTE);
            b = generator.Next(BYTE);

            return Color.FromArgb(r, g, b);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
