using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter
{
    public partial class UserControl1 : UserControl
    {
        Graphics graphic;
        bool move = false;
        int x = 0;
        int y = 0;

        Pen pen;
        public UserControl1()
        {
            InitializeComponent();
            graphic = panel1.CreateGraphics();
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 1);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //changer couleur rouge
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // changer couleur green
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //ici on commence la ligne
            move = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //ici on fait la ligne si mouse down
            if (move && x != -1 && y != -1)
            {
                graphic.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            //ici on finit la ligne
            move = false;
            x = 0;
            y = 0;

        }
    }
}
