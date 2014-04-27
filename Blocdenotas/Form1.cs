using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Blocdenotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "Desea guardar antes de salir?";
            string titulo = "Bloc de notas";
            DialogResult respuesta = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                saveFileDialog1.FileName = "Sin título.txt";
                var guardar = saveFileDialog1.ShowDialog();
                if (guardar == DialogResult.OK)
                {
                    using (var Savefile = new StreamWriter(saveFileDialog1.FileName))
                    {
                        Savefile.WriteLine(richTextBox1.Text);
                    }
                }

                {
                    this.Close();
                }
            }
        }

        private void acercaDeBlocDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "Sistema realizado por Pablo Matías Aimar\n";
            mensaje += "Diseño y Gestión de Base de Datos\n";
            mensaje += "Año 2014\n";
            mensaje += "Instituto de Profesorado N° 20";
            string titulo = "SmoothSofts";
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fuente = fontDialog1.ShowDialog();
            if (fuente == DialogResult.OK)
                {
                    richTextBox1.Font = fontDialog1.Font;
                }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string leer;
            openFileDialog1.ShowDialog();
            StreamReader archivo = new StreamReader(openFileDialog1.FileName);
            leer = archivo.ReadLine();
            richTextBox1.Text = leer.ToString();

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Sin título.txt";
            var guardar = saveFileDialog1.ShowDialog();
            if (guardar == DialogResult.OK)
            {
                using (var Savefile = new StreamWriter(saveFileDialog1.FileName))
                {
                    Savefile.WriteLine(richTextBox1.Text);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private PrintDocument documento_a_imprimir =
            new PrintDocument();

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.AllowSomePages = true;
            printDialog1.ShowHelp = true;

            printDialog1.Document = documento_a_imprimir;
            DialogResult resultado = printDialog1.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                documento_a_imprimir.Print();
            }



        }

        private void configurarPáginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void horaYFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(DateTime.Now.ToString("HH:mm dd/MM/yy"));
        }

        private void ajusteDeLíneaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void barraDeEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
