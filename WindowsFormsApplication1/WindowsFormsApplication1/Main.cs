using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        /// private ImageProcesing imageProcesing;
        /// 
        public Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImageProcesing imageProcesing = new ImageProcesing();
            imageProcesing.ShowDialog();
            this.Close();
        }

        private void labelTextProcessing_Click(object sender, EventArgs e)
        {
            this.Hide();
            TextProcessing textProcessing = new TextProcessing();
            textProcessing.ShowDialog();
            this.Close();
        }
    }
}
