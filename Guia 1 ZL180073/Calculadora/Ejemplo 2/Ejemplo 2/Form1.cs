using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_2
{
    public partial class Form1 : Form
    {
        public Button boton1;
        public Button boton2;
        public Form1()
        {
            boton1 = new Button();
            boton1.Size = new Size(80, 40);
            boton1.Location = new Point(30, 30);

            boton1.Text = "Presione Aquí";
            this.Controls.Add(boton1);
            boton1.Click += new EventHandler(boton1_Click);

            boton2 = new Button();
            boton2.Size = new Size(60, 60);
            boton2.Location = new Point(30, 70);
            boton2.BackColor = Color.LightBlue;

            boton2.Text = "Presione la segunda opción";
            this.Controls.Add(boton2);
            boton2.Click += new EventHandler(boton2_Click);
            
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha creado un botón por código");
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha creado un segundo boton por codigo");
            MessageBox.Show("Gracias por presionar el boton...");
        }
    }
}
