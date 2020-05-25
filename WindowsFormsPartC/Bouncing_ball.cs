using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPartC
{
   
    public partial class Bouncing_ball : Form
    {
        private int x = 200, y = 50;
        private int size = 30;
        private int xmove = 10, ymove = 10;

        public const int BYTE = 256;

        private Random generator = new Random();

        private Ball redBall = new Ball();

        private Point getRandomPoint()
        {
            int x = generator.Next(ballPictureBox.Width);
            int y = generator.Next(ballPictureBox.Height);

            Point randomRedPoint = new Point();
            return randomRedPoint;
        }
        private void ballPicturePoint_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillEllipse(Brushes.Red, x, y, size, size);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void moveBall(object sender, EventArgs e)
        {
            // add 10 to x and y positions
            x += xmove;
            if (x < 0)
            {
                xmove = -xmove;
            }
            else if (x + 30 > ClientSize.Width)
            {
                xmove = -xmove;
            }
            y += ymove;
            if (y < 0)
            {
                ymove = -ymove;
            }
            else if (y + 30 > ClientSize.Height)
            {
                ymove = -ymove;
            }
            Refresh();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        public Bouncing_ball()
        {
            InitializeComponent();
        }

        private void Bouncing_ball_Load(object sender, EventArgs e)
        {
            redBall.Position = getRandomPoint();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            string input;

            input = keyData.ToString();

            if (input == "Up")
            {
                size = size + 10;
                return true;
            }
            if (input == "Down")
            {
                size = size - 10;
                return true;
            }
            if (input == "C")
            {
                ballPictureBox.BackColor = getRandomColor();
                return true;
            }
            // return true if key processed, otherwise false
            return false;
        }

        private Color getRandomColor()
        {
            int r, g, b;

            r = generator.Next(BYTE);
            g = generator.Next(BYTE);
            b = generator.Next(BYTE);

            return Color.FromArgb(r, g, b);
        }
    }

    public class Ball
    {
        public int Size { get; set; }
        public Point Position { get; set; }
        public Point Speed { get; set; }

        public Ball()
        {
            Size = 30;
            Position = new Point(200, 50);
            Speed = new Point(10, 10);
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Red, Position.X, Position.Y, Size, Size);
        }
    }
}
