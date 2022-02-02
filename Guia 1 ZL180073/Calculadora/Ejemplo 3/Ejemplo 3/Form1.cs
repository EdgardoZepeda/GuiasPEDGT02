using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_3
{
    public partial class Form1 : Form
    {
        int x, y; //Variables 
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point punto = new Point(e.X, e.Y);
            x = punto.X;
            y = punto.Y;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen lapiz = new Pen(Color.DarkGray);

            if (listBox1.SelectedIndex == 0)
            {
                SolidBrush sb = new SolidBrush(Color.Gold);
                g.DrawEllipse(lapiz, x - 75, y - 50, 100, 100);
                g.FillEllipse(sb, x - 50, y - 75, 100, 100);
            }

            if (listBox1.SelectedIndex == 1)
            {
                SolidBrush sb = new SolidBrush(Color.DarkBlue);
                g.DrawRectangle(lapiz, x - 75, y - 50, 100, 100);
                g.FillRectangle(sb, x - 75, y - 50, 100, 100);
            }
                 }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
