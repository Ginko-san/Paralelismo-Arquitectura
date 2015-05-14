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
    public partial class ImageProcesing : Form
    {

        private Bitmap image;
        static Stopwatch temporizador;
        static long tiempo1;

        public ImageProcesing()
        {
            InitializeComponent();

            comboBoxFilterSelection.SelectedIndex = 0;

            /// Objects init invisible, and set visible when the filterSelection index get into 4

            labelOpacityOrBrightness.Visible = false;
            labelTrackBarValuePercent.Visible = false;
            trackBarOpacityOrBrightness.Visible = false;
        }
        
        /// <summary>
        /// This button load the bmp image from a file (.jpg , .png, .bmp, etc...)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "JPG Images (*.jpg)|*.jpg|PNG Images (*.png)|*.png|BMP Images (*.bmp)|*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(openFileDialog1.OpenFile());
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
            Bitmap imageCopy = new Bitmap(1, 1);

            

            /// Gray Scale Selected
            if (comboBoxFilterSelection.SelectedIndex == 0)
            {
                
                Parallel.Invoke(() =>
                {
                    imageCopy = Operations.grayScaleInParallelProcesing(image);
                    tiempo1 = temporizador.ElapsedMilliseconds;
                });
                
            }

            /// Gray Scale Selected
            else if (comboBoxFilterSelection.SelectedIndex == 1)
            {
                
                Parallel.Invoke(() =>
                {
                    imageCopy = Operations.sepiaScaleInParallelProcesing(image);
                    tiempo1 = temporizador.ElapsedMilliseconds;
                });
                
            }

            /// Opacity Scale Selected
            else if (comboBoxFilterSelection.SelectedIndex == 2)
            {
                double opacity = ((int)trackBarOpacityOrBrightness.Value * 0.01);
                Parallel.Invoke(() =>
                {
                    imageCopy = Operations.OpacityInParallelProcesing(image, opacity);
                    tiempo1 = temporizador.ElapsedMilliseconds;
                });

            }

            /// Invert Colors Scale Selected
            else if (comboBoxFilterSelection.SelectedIndex == 3)
            {
                Parallel.Invoke(() =>
                {
                    imageCopy = Operations.invertColorsInParallelProcesing(image);
                    tiempo1 = temporizador.ElapsedMilliseconds;
                });
            }

            /// gaussin Blur Selected
            else if (comboBoxFilterSelection.SelectedIndex == 4)
            {
                int gaussinFactor = trackBarOpacityOrBrightness.Value;
                Parallel.Invoke(() =>
                {
                    imageCopy = Operations.gaussinBlurInParallelProcesing(image, gaussinFactor);
                    tiempo1 = temporizador.ElapsedMilliseconds;
                });

            }
                
            /// adjusting Brightness Selected
            else if (comboBoxFilterSelection.SelectedIndex == 5)
            {
                double opacity = (double)trackBarOpacityOrBrightness.Value;
                Parallel.Invoke(() =>
                {
                    imageCopy = Operations.adjustingBrightnessInParallelProcesing(image, opacity);
                    tiempo1 = temporizador.ElapsedMilliseconds;
                });

            }
    
            /// Rainbow Selected
            else if (comboBoxFilterSelection.SelectedIndex == 6)
            {
                Parallel.Invoke(() =>
                {
                    imageCopy = Operations.RainbowFilterInParallelProcesing(image);
                    tiempo1 = temporizador.ElapsedMilliseconds;
                });
            }

            /// Blues Balance Selected
            else if (comboBoxFilterSelection.SelectedIndex == 7)
            {
                Parallel.Invoke(() =>
                {
                    imageCopy = Operations.bluesBalanceInParallelProcesing(image);
                    tiempo1 = temporizador.ElapsedMilliseconds;
                });
            }

            else
            {
                MessageBox.Show("Todavia no estan listos los demas ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            temporizador.Stop();

            pictureBoxWFilterApplied.Image = imageCopy;
            pictureBoxWFilterApplied.SizeMode = PictureBoxSizeMode.Zoom;

            MessageBox.Show("Tiempo Paralello: " + tiempo1, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void buttonSecuential_Click(object sender, EventArgs e)
        {
            temporizador = Stopwatch.StartNew();
            Bitmap imageCopy = new Bitmap(1,1);


            /// Gray Scale Selected
            if (comboBoxFilterSelection.SelectedIndex == 0)
            {
                imageCopy = Operations.grayScaleFilterSecuential(image);
            }

            /// Sepia Scale Selected
            else if (comboBoxFilterSelection.SelectedIndex == 1)
            {
                imageCopy = Operations.sepiaFilterSecuential(image);
            }

            /// Opacity Scale Selected
            else if (comboBoxFilterSelection.SelectedIndex == 2)
            {   
                double opacity = ((int)trackBarOpacityOrBrightness.Value * 0.01);
                imageCopy = Operations.OpacityFilterSecuential(image, opacity);
            }
                
            /// invert Colors Scale Selected
            else if (comboBoxFilterSelection.SelectedIndex == 3)
            {   
                imageCopy = Operations.invertColorsFilterSecuential(image);
            }

            /// gaussin Blue Scale Selected
            else if (comboBoxFilterSelection.SelectedIndex == 4)
            {
                int gaussinFactor = trackBarOpacityOrBrightness.Value;
                imageCopy = Operations.gaussinBlurColorsFilterSecuential(image, gaussinFactor);
            }

            /// Adjusting Brightness Scale Selected
            else if (comboBoxFilterSelection.SelectedIndex == 5)
            {
                double opacity = (double)trackBarOpacityOrBrightness.Value;
                imageCopy = Operations.adjustingBrightnessFilterSecuential(image, opacity);
            }

            /// Rainbow Selected
            else if (comboBoxFilterSelection.SelectedIndex == 6)
            {
                imageCopy = Operations.RainbowFilter(image);
            }

            /// Blues Balance Selected
            else if (comboBoxFilterSelection.SelectedIndex == 7)
            {
                imageCopy = Operations.bluesBalanceFilterSecuential(image);
            }

            else
            {
                MessageBox.Show("Todavia no estan listos los demas ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            pictureBoxWFilterApplied.Image = imageCopy;
            pictureBoxWFilterApplied.SizeMode = PictureBoxSizeMode.Zoom;

            tiempo1 = temporizador.ElapsedMilliseconds;
            temporizador.Stop();

            MessageBox.Show("Tiempo Secuencial: " + tiempo1, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelTrackBarValuePercent.Text = trackBarOpacityOrBrightness.Value.ToString() + " %" ; 
            
        }

        private void comboBoxFilterSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            /// Gray Scale Selected
            if (comboBoxFilterSelection.SelectedIndex == 0)
            {
                /// set the widgets invisible
                labelOpacityOrBrightness.Visible = false;
                labelTrackBarValuePercent.Visible = false;
                trackBarOpacityOrBrightness.Visible = false;
            }

            /// Sepia Selected
            else if (comboBoxFilterSelection.SelectedIndex == 1)
            {
                /// set the widgets invisible
                labelOpacityOrBrightness.Visible = false;
                labelTrackBarValuePercent.Visible = false;
                trackBarOpacityOrBrightness.Visible = false;
            }
            
            /// Opacity Selected
            else if (comboBoxFilterSelection.SelectedIndex == 2)
            {
                /// set the widgets visible, because the filter needed  and set other text to the label.
                labelOpacityOrBrightness.Text = "Value Percent Opacity";
                labelOpacityOrBrightness.Visible = true;
                labelTrackBarValuePercent.Visible = true;
                trackBarOpacityOrBrightness.Visible = true;
            }
            
            /// Invert Colors Selected
            else if (comboBoxFilterSelection.SelectedIndex == 3)
            {
                /// set the widgets invisible 
                /// labelOpacityOrBrightness.Text = "Value Percent Brightness";
                labelOpacityOrBrightness.Visible = false;
                labelTrackBarValuePercent.Visible = false;
                trackBarOpacityOrBrightness.Visible = false;
            }

            /// Gaussin blur Selected
            else if (comboBoxFilterSelection.SelectedIndex == 4)
            {
                /// set the widgets invisible and set other text to the label
                labelOpacityOrBrightness.Text = "Value Percent To Gaussin Blur";
                trackBarOpacityOrBrightness.Maximum = 5;
                labelOpacityOrBrightness.Visible = true;
                labelTrackBarValuePercent.Visible = true;
                trackBarOpacityOrBrightness.Visible = true;
            }

            /// Adjusting brightness Selected
            else if (comboBoxFilterSelection.SelectedIndex == 5)
            {
                /// set the widgets invisible and set other text to the label
                labelOpacityOrBrightness.Text = "Value Percent Brightness";
                labelOpacityOrBrightness.Visible = true;
                labelTrackBarValuePercent.Visible = true;
                trackBarOpacityOrBrightness.Visible = true;
            }

            /// Rainbow Filter Selected
            else if (comboBoxFilterSelection.SelectedIndex == 6)
            {
                /// set the widgets invisible
                labelOpacityOrBrightness.Visible = false;
                labelTrackBarValuePercent.Visible = false;
                trackBarOpacityOrBrightness.Visible = false;
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
            this.Close();
        }

    }
}
