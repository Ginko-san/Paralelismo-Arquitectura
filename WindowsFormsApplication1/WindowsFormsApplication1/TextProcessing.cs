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


namespace WindowsFormsApplication1
{
    public partial class TextProcessing : Form
    {
        private StreamReader sr;
        private String allText;
        private String lines;

        public TextProcessing()
        {
            InitializeComponent();

            comboBoxTextSelection.SelectedIndex = 0;
        }

        private void buttonLoadTextFile_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt Files (*.txt)|*.txt|All Files(*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {

                        String strFilePath = openFileDialog1.FileName;
                        MessageBox.Show(strFilePath, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        lines = File.ReadAllText(strFilePath);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }


        private void buttonSecuential_Click(object sender, EventArgs e)
        {
            if (comboBoxTextSelection.SelectedIndex == 0)
            {
                String word = Operations.wordMostLargeInLinesSecuential(lines);
                MessageBox.Show("Palabra mas larga en el texto: " + word, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

    
    
    
    
    
    
    
    }
}
