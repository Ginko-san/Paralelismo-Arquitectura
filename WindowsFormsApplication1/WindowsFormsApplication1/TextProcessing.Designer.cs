namespace WindowsFormsApplication1
{
    partial class TextProcessing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadTextFile = new System.Windows.Forms.Button();
            this.comboBoxTextSelection = new System.Windows.Forms.ComboBox();
            this.buttonParallel = new System.Windows.Forms.Button();
            this.buttonSecuential = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadTextFile
            // 
            this.buttonLoadTextFile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLoadTextFile.Location = new System.Drawing.Point(24, 12);
            this.buttonLoadTextFile.Name = "buttonLoadTextFile";
            this.buttonLoadTextFile.Size = new System.Drawing.Size(222, 23);
            this.buttonLoadTextFile.TabIndex = 0;
            this.buttonLoadTextFile.Text = "Load Text File ";
            this.buttonLoadTextFile.UseVisualStyleBackColor = false;
            this.buttonLoadTextFile.Click += new System.EventHandler(this.buttonLoadTextFile_Click);
            // 
            // comboBoxTextSelection
            // 
            this.comboBoxTextSelection.FormattingEnabled = true;
            this.comboBoxTextSelection.Items.AddRange(new object[] {
            "Word Most Large",
            "N\'s Words Most Common",
            "Number of Times a Word is Located"});
            this.comboBoxTextSelection.Location = new System.Drawing.Point(24, 62);
            this.comboBoxTextSelection.Name = "comboBoxTextSelection";
            this.comboBoxTextSelection.Size = new System.Drawing.Size(222, 21);
            this.comboBoxTextSelection.TabIndex = 1;
            // 
            // buttonParallel
            // 
            this.buttonParallel.Location = new System.Drawing.Point(24, 139);
            this.buttonParallel.Name = "buttonParallel";
            this.buttonParallel.Size = new System.Drawing.Size(102, 23);
            this.buttonParallel.TabIndex = 2;
            this.buttonParallel.Text = "Parallel";
            this.buttonParallel.UseVisualStyleBackColor = true;
            // 
            // buttonSecuential
            // 
            this.buttonSecuential.Location = new System.Drawing.Point(132, 139);
            this.buttonSecuential.Name = "buttonSecuential";
            this.buttonSecuential.Size = new System.Drawing.Size(114, 23);
            this.buttonSecuential.TabIndex = 3;
            this.buttonSecuential.Text = "Secuential";
            this.buttonSecuential.UseVisualStyleBackColor = true;
            this.buttonSecuential.Click += new System.EventHandler(this.buttonSecuential_Click);
            // 
            // TextProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(772, 261);
            this.Controls.Add(this.buttonSecuential);
            this.Controls.Add(this.buttonParallel);
            this.Controls.Add(this.comboBoxTextSelection);
            this.Controls.Add(this.buttonLoadTextFile);
            this.Name = "TextProcessing";
            this.Text = "TextProcessing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadTextFile;
        private System.Windows.Forms.ComboBox comboBoxTextSelection;
        private System.Windows.Forms.Button buttonParallel;
        private System.Windows.Forms.Button buttonSecuential;
    }
}