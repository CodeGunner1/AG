using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resolicion_de_parcial
{
    public partial class Form1 : Form
    {
        Matriz x1, x2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = new Matriz();
            x2 = new Matriz();
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = x1.Descargar();
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.EleYFrec();
            textBox6.Text = x1.Descargar();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text),int.Parse(textBox3.Text),int.Parse(textBox4.Text)); 
        }
    }
}
