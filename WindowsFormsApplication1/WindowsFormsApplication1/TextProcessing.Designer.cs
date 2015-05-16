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
            this.labelPath = new System.Windows.Forms.Label();
            this.richTextBoxLoadText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNQuantity = new System.Windows.Forms.TextBox();
            this.labelProcessTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoadTextFile
            // 
            this.buttonLoadTextFile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLoadTextFile.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadTextFile.Name = "buttonLoadTextFile";
            this.buttonLoadTextFile.Size = new System.Drawing.Size(234, 23);
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
            this.comboBoxTextSelection.Location = new System.Drawing.Point(12, 62);
            this.comboBoxTextSelection.Name = "comboBoxTextSelection";
            this.comboBoxTextSelection.Size = new System.Drawing.Size(234, 21);
            this.comboBoxTextSelection.TabIndex = 1;
            this.comboBoxTextSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxTextSelection_SelectedIndexChanged);
            // 
            // buttonParallel
            // 
            this.buttonParallel.Location = new System.Drawing.Point(16, 164);
            this.buttonParallel.Name = "buttonParallel";
            this.buttonParallel.Size = new System.Drawing.Size(102, 23);
            this.buttonParallel.TabIndex = 2;
            this.buttonParallel.Text = "Parallel";
            this.buttonParallel.UseVisualStyleBackColor = true;
            // 
            // buttonSecuential
            // 
            this.buttonSecuential.Location = new System.Drawing.Point(124, 164);
            this.buttonSecuential.Name = "buttonSecuential";
            this.buttonSecuential.Size = new System.Drawing.Size(114, 23);
            this.buttonSecuential.TabIndex = 3;
            this.buttonSecuential.Text = "Secuential";
            this.buttonSecuential.UseVisualStyleBackColor = true;
            this.buttonSecuential.Click += new System.EventHandler(this.buttonSecuential_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPath.Location = new System.Drawing.Point(433, 9);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(100, 19);
            this.labelPath.TabIndex = 5;
            this.labelPath.Text = "Path Directory:";
            // 
            // richTextBoxLoadText
            // 
            this.richTextBoxLoadText.Location = new System.Drawing.Point(272, 35);
            this.richTextBoxLoadText.Name = "richTextBoxLoadText";
            this.richTextBoxLoadText.Size = new System.Drawing.Size(592, 214);
            this.richTextBoxLoadText.TabIndex = 7;
            this.richTextBoxLoadText.Text = "No data loaded.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "N Quantity";
            // 
            // textBoxNQuantity
            // 
            this.textBoxNQuantity.Location = new System.Drawing.Point(16, 127);
            this.textBoxNQuantity.Name = "textBoxNQuantity";
            this.textBoxNQuantity.Size = new System.Drawing.Size(230, 20);
            this.textBoxNQuantity.TabIndex = 9;
            this.textBoxNQuantity.Text = "1";
            // 
            // labelProcessTime
            // 
            this.labelProcessTime.AutoSize = true;
            this.labelProcessTime.Location = new System.Drawing.Point(54, 235);
            this.labelProcessTime.Name = "labelProcessTime";
            this.labelProcessTime.Size = new System.Drawing.Size(77, 13);
            this.labelProcessTime.TabIndex = 10;
            this.labelProcessTime.Text = "Process Time: ";
            // 
            // TextProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(876, 261);
            this.Controls.Add(this.labelProcessTime);
            this.Controls.Add(this.textBoxNQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxLoadText);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.buttonSecuential);
            this.Controls.Add(this.buttonParallel);
            this.Controls.Add(this.comboBoxTextSelection);
            this.Controls.Add(this.buttonLoadTextFile);
            this.Name = "TextProcessing";
            this.Text = "TextProcessing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadTextFile;
        private System.Windows.Forms.ComboBox comboBoxTextSelection;
        private System.Windows.Forms.Button buttonParallel;
        private System.Windows.Forms.Button buttonSecuential;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.RichTextBox richTextBoxLoadText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNQuantity;
        private System.Windows.Forms.Label labelProcessTime;
    }
}