using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Diagnostics;
using System.Drawing;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private Bitmap image;
        static Stopwatch temporizador;
        static long tiempo1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// Las lineas comentadas en este metodo, futuramente seran eliminadas
            ///Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "JPG Images (*.jpg)|*.jpg|PNG Images (*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   /// if ((myStream = openFileDialog1.OpenFile()) != null)
                    ///{
                        image = new Bitmap(openFileDialog1.OpenFile());
                    ///}
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from Directory. Original error: " + ex.Message);
                }
            }
            pictureBoxWImageSearch.Image = image;
            pictureBoxWImageSearch.SizeMode = PictureBoxSizeMode.Zoom;
        }



        private void buttonParallel_Click(object sender, EventArgs e)
        {
            temporizador = Stopwatch.StartNew();

            Parallel.Invoke(() =>
            {
                Operations.RainbowFilterParallel(image);
                tiempo1 = temporizador.ElapsedMilliseconds;
            });
            temporizador.Stop();

            pictureBoxWFilterApplied.Image = image;
            pictureBoxWFilterApplied.SizeMode = PictureBoxSizeMode.Zoom;

            MessageBox.Show("Tiempo Paralello: " + tiempo1, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void buttonSecuential_Click(object sender, EventArgs e)
        {
            temporizador = Stopwatch.StartNew();

            image = Operations.RainbowFilter(image);
            pictureBoxWFilterApplied.Image = image;
            pictureBoxWFilterApplied.SizeMode = PictureBoxSizeMode.Zoom;

            tiempo1 = temporizador.ElapsedMilliseconds;
            temporizador.Stop();

            MessageBox.Show("Tiempo Secuencial: " + tiempo1, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
