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
        private int size = 30;

        public const int BYTE = 256;

        private Random generator = new Random();

        private Ball redBall;

        private Ball greenBall;

        private Point getRandomPoint()
        {
            int x = generator.Next(ballPictureBox.Width);
            int y = generator.Next(ballPictureBox.Height);

            Point randomRedPoint = new Point(x, y);
            return randomRedPoint;
        }
        private void ballPicturePoint_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush brush = new SolidBrush(Color.Red);
            redBall.Draw(e.Graphics, brush);

            brush = new SolidBrush(Color.Green);
            greenBall.Draw(e.Graphics, brush);
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
            redBall.Move();
            greenBall.Move();

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
            Rectangle boundary = new Rectangle(0, 0, ballPictureBox.Width, ballPictureBox.Height);
            redBall = new Ball(boundary);
            greenBall = new Ball(boundary);

            redBall.Position = getRandomPoint();
            greenBall.Position = getRandomPoint();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up )
            {
                redBall.Size = size + 10;
                return true;
            }
            if (keyData == Keys.Down)
            {
                redBall.Size = size - 10;
                return true;
            }
            if (keyData == Keys.C)
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
        public Rectangle Boundary { get; set; }

        public Ball(Rectangle boundary)
        {
            Boundary = boundary;

            Size = 30;
            Position = new Point(200, 50);
            Speed = new Point(10, 10);
        }

        public void Draw(Graphics g, SolidBrush brush)
        {
            g.FillEllipse(brush, Position.X, Position.Y, Size, Size);
        }

        public void Move()
        {
            Point p = new Point(Position.X + Speed.X, Position.Y + Speed.Y);
            Position = p;

            if (p.X + Size >= Boundary.Width)
            {
                Speed = new Point(-Speed.X, Speed.Y);
            }
            else if (p.Y + Size >= Boundary.Height)
            {
                Speed = new Point(Speed.X, -Speed.Y);
            }
            else if (p.X + Size <= Boundary.X) 
            {
                Speed = new Point(-Speed.X, Speed.Y);
            }
            else if (p.Y + Size <= Boundary.Y)
            {
                Speed = new Point(Speed.X, -Speed.Y);
            }
        }
    }
}
