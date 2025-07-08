using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Archivos_Sec
{
    public partial class Form1 : Form
    {

        entero n1;
        VectorEnt v1, v2, v3, vR;
        Archivo a1, a2, a3, a4;
        Arreglo3D Y1;
        Matriz x1, x2;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            n1 = new entero();
            v1 = new VectorEnt();
            v2 = new VectorEnt();
            v3 = new VectorEnt();
            vR = new VectorEnt();
            a1 = new Archivo();
            a2 = new Archivo();
            a3 = new Archivo();
            a4 = new Archivo();
            Y1 = new Arreglo3D();
            x1 = new Matriz();
            x2 = new Matriz();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }


        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            v1.OrdAsc();

        }


        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = v1.descargar();
        }


        private void accesarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            vR.AccesarV(openFileDialog1.FileName);
        }


        private void grabarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            v1.GrabarV(saveFileDialog1.FileName);
        }


        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();
            a1.Ejer1(openFileDialog1.FileName, saveFileDialog1.FileName, a2);

        }


        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void descargarRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = vR.descargar();
        }


        private void descargarv2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = v2.descargar();
        }


        private void grabarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            v2.GrabarV(saveFileDialog1.FileName);
        }


        private void cargarManual2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2.cargarmanual(int.Parse(textBox1.Text));
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void ejercicio5ExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }



        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void ejercicio7ExamenRepechajeSBToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void reemplazarUnNumeroPorOtroN19XN219ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();


            a1.Ejercicio2(openFileDialog1.FileName, saveFileDialog1.FileName,
                                int.Parse(textBox2.Text), int.Parse(textBox3.Text));

            MessageBox.Show("Reemplazo completado con éxito.", "Operación finalizada");
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int mf, mc, mp, ra, rb;
            mf = int.Parse(textBox1.Text);
            mc = int.Parse(textBox2.Text);
            mp = int.Parse(textBox3.Text);
            ra = int.Parse(textBox8.Text);
            rb = int.Parse(textBox9.Text);

            Y1.Cargar(mf, mc, mp, ra, rb);
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox7.Text = Y1.Descargar();
        }



        private void cargarv2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            v2.OrdAsc();

        }


        private void cargarManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.cargarmanual(int.Parse(textBox1.Text));
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog2.ShowDialog();
            saveFileDialog1.ShowDialog();
            a1.Ejer3(openFileDialog1.FileName, openFileDialog2.FileName, saveFileDialog1.FileName, a2, a3);
        }

        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            x1.EleYFrec();
            textBox6.Text = x1.Descargar();
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            x1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox8.Text));
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox7.Text = x1.Descargar();
        }

        private void proyectoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void ejercicio5ExamenToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ejercicio4ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            textBox6.Text = Y1.MayorConPosicion();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Y1.SumarTodoYGuardarEnNuevaProfundidad();
            textBox6.Text = Y1.Descargar();
        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Y1.OrdenarPorFilasSeparadas();
            textBox6.Text = Y1.Descargar();
        }

        private void seleccionarCapicuasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();    // Entrada
            saveFileDialog1.ShowDialog();    // Salida
            a1.SeleccionarCapicuas(openFileDialog1.FileName, saveFileDialog1.FileName, a2);
        }


    }
}
