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
using System.Diagnostics;


namespace WindowsFormsApplication1
{
    public partial class TextProcessing : Form
    {
        private String lines;
        private String[] words;
        private Stopwatch temporizador;
        private static long tiempo1;

        public TextProcessing()
        {
            InitializeComponent();

            comboBoxTextSelection.SelectedIndex = 0;
            label1.Visible = false;
            textBoxNQuantity.Visible = false;
        }

        /// <summary>
        /// The load method doens't present any problems! 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoadTextFile_Click(object sender, EventArgs e)
        {
            temporizador = Stopwatch.StartNew();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt Files (*.txt)|*.txt|All Files(*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog1.OpenFile() != null)
                    {
                        String strFilePath = openFileDialog1.FileName;
                        MessageBox.Show(strFilePath, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        labelPath.Text = "Path Directory: " + strFilePath;
                        

                        lines = File.ReadAllText(strFilePath);

                        richTextBoxLoadText.Text = lines;

                        words = Operations.splitLines(lines);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            tiempo1 = temporizador.ElapsedMilliseconds;
            temporizador.Stop();
            tiempo1 /= 60;

            labelProcessTime.Text = "Process Time: " + tiempo1 + " ms";
        }

        private void buttonSecuential_Click(object sender, EventArgs e)
        {
            temporizador = Stopwatch.StartNew();

            if (words == null)
                MessageBox.Show("Choose a file, first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (comboBoxTextSelection.SelectedIndex == 0)
                {
                    String word = Operations.wordMostLargeInLinesSecuential(words);

                    tiempo1 = temporizador.ElapsedMilliseconds;
                    temporizador.Stop();

                    MessageBox.Show("Palabra mas larga en el texto: " + word, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                else if (comboBoxTextSelection.SelectedIndex == 1)
                {
                    int n = Convert.ToInt32(textBoxNQuantity.Text);
                    String[] wordsMostCommon = Operations.nWordsMostCommonSecuential(words, n);

                    tiempo1 = temporizador.ElapsedMilliseconds;
                    temporizador.Stop();

                    foreach (String s in wordsMostCommon)
                    {
                        MessageBox.Show("Las palabras mas comunes son:" + s, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                else if (comboBoxTextSelection.SelectedIndex == 2)
                {
                    String noIdea = textBoxNQuantity.Text;
                    int quantity = Operations.wordNTimesSecuential(words, noIdea);

                    tiempo1 = temporizador.ElapsedMilliseconds;
                    temporizador.Stop();

                    MessageBox.Show("Las palabra:" + noIdea + ", esta: " + quantity, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            
            tiempo1 /= 60;

            labelProcessTime.Text = "Process Time: " + tiempo1 + " ms";


        }

        private void comboBoxTextSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            /// first option Selected
            if (comboBoxTextSelection.SelectedIndex == 0)
            {
                label1.Visible = false;
                textBoxNQuantity.Visible = false;
            }

            /// second option Selected
            else if (comboBoxTextSelection.SelectedIndex == 1)
            {
                label1.Text = "Value Percent Opacity";
                label1.Visible = true;
                textBoxNQuantity.Visible = true;
            }

            /// third option Selected
            else if (comboBoxTextSelection.SelectedIndex == 2)
            {
                label1.Text = "Word to Search";
                label1.Visible = true;
                textBoxNQuantity.Visible = true;
            }
            
        }  
    
    }
}
