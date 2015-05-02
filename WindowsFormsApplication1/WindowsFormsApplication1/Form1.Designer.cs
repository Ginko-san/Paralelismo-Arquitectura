namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.buttonParallel = new System.Windows.Forms.Button();
            this.buttonSecuential = new System.Windows.Forms.Button();
            this.listBoxFilters = new System.Windows.Forms.ListBox();
            this.pictureBoxWImageSearch = new System.Windows.Forms.PictureBox();
            this.pictureBoxWFilterApplied = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWImageSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWFilterApplied)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonParallel
            // 
            this.buttonParallel.Location = new System.Drawing.Point(537, 553);
            this.buttonParallel.Name = "buttonParallel";
            this.buttonParallel.Size = new System.Drawing.Size(75, 23);
            this.buttonParallel.TabIndex = 0;
            this.buttonParallel.Text = "Parallel";
            this.buttonParallel.UseVisualStyleBackColor = true;
            this.buttonParallel.Click += new System.EventHandler(this.buttonParallel_Click);
            // 
            // buttonSecuential
            // 
            this.buttonSecuential.Location = new System.Drawing.Point(619, 553);
            this.buttonSecuential.Name = "buttonSecuential";
            this.buttonSecuential.Size = new System.Drawing.Size(75, 23);
            this.buttonSecuential.TabIndex = 1;
            this.buttonSecuential.Text = "Secuential";
            this.buttonSecuential.UseVisualStyleBackColor = true;
            this.buttonSecuential.Click += new System.EventHandler(this.buttonSecuential_Click);
            // 
            // listBoxFilters
            // 
            this.listBoxFilters.FormattingEnabled = true;
            this.listBoxFilters.Location = new System.Drawing.Point(12, 108);
            this.listBoxFilters.Name = "listBoxFilters";
            this.listBoxFilters.Size = new System.Drawing.Size(94, 303);
            this.listBoxFilters.TabIndex = 2;
            // 
            // pictureBoxWImageSearch
            // 
            this.pictureBoxWImageSearch.Location = new System.Drawing.Point(112, 36);
            this.pictureBoxWImageSearch.Name = "pictureBoxWImageSearch";
            this.pictureBoxWImageSearch.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxWImageSearch.TabIndex = 3;
            this.pictureBoxWImageSearch.TabStop = false;
            // 
            // pictureBoxWFilterApplied
            // 
            this.pictureBoxWFilterApplied.Location = new System.Drawing.Point(619, 37);
            this.pictureBoxWFilterApplied.Name = "pictureBoxWFilterApplied";
            this.pictureBoxWFilterApplied.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxWFilterApplied.TabIndex = 4;
            this.pictureBoxWFilterApplied.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Image To Apply the Filters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(791, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Image Filters Applied";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filters";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Load Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 604);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxWFilterApplied);
            this.Controls.Add(this.pictureBoxWImageSearch);
            this.Controls.Add(this.listBoxFilters);
            this.Controls.Add(this.buttonSecuential);
            this.Controls.Add(this.buttonParallel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWImageSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWFilterApplied)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonParallel;
        private System.Windows.Forms.Button buttonSecuential;
        private System.Windows.Forms.ListBox listBoxFilters;
        private System.Windows.Forms.PictureBox pictureBoxWImageSearch;
        private System.Windows.Forms.PictureBox pictureBoxWFilterApplied;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

