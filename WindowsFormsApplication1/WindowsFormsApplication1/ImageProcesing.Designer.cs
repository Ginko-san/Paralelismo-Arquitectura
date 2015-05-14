namespace WindowsFormsApplication1
{
    partial class ImageProcesing
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
            this.pictureBoxWImageSearch = new System.Windows.Forms.PictureBox();
            this.pictureBoxWFilterApplied = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.panelFilterOptions = new System.Windows.Forms.Panel();
            this.labelOpacityOrBrightness = new System.Windows.Forms.Label();
            this.labelTrackBarValuePercent = new System.Windows.Forms.Label();
            this.trackBarOpacityOrBrightness = new System.Windows.Forms.TrackBar();
            this.comboBoxFilterSelection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWImageSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWFilterApplied)).BeginInit();
            this.panelFilterOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacityOrBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonParallel
            // 
            this.buttonParallel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonParallel.Location = new System.Drawing.Point(50, 176);
            this.buttonParallel.Name = "buttonParallel";
            this.buttonParallel.Size = new System.Drawing.Size(101, 23);
            this.buttonParallel.TabIndex = 4;
            this.buttonParallel.Text = "Parallel";
            this.buttonParallel.UseVisualStyleBackColor = false;
            this.buttonParallel.Click += new System.EventHandler(this.buttonParallel_Click);
            // 
            // buttonSecuential
            // 
            this.buttonSecuential.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSecuential.Location = new System.Drawing.Point(157, 176);
            this.buttonSecuential.Name = "buttonSecuential";
            this.buttonSecuential.Size = new System.Drawing.Size(101, 23);
            this.buttonSecuential.TabIndex = 5;
            this.buttonSecuential.Text = "Secuential";
            this.buttonSecuential.UseVisualStyleBackColor = false;
            this.buttonSecuential.Click += new System.EventHandler(this.buttonSecuential_Click);
            // 
            // pictureBoxWImageSearch
            // 
            this.pictureBoxWImageSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxWImageSearch.Location = new System.Drawing.Point(15, 30);
            this.pictureBoxWImageSearch.Name = "pictureBoxWImageSearch";
            this.pictureBoxWImageSearch.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxWImageSearch.TabIndex = 3;
            this.pictureBoxWImageSearch.TabStop = false;
            // 
            // pictureBoxWFilterApplied
            // 
            this.pictureBoxWFilterApplied.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxWFilterApplied.Location = new System.Drawing.Point(522, 31);
            this.pictureBoxWFilterApplied.Name = "pictureBoxWFilterApplied";
            this.pictureBoxWFilterApplied.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxWFilterApplied.TabIndex = 4;
            this.pictureBoxWFilterApplied.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(158, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Image To Apply the Filters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(694, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Image Filters Applied";
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLoadImage.Location = new System.Drawing.Point(108, 18);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(101, 23);
            this.buttonLoadImage.TabIndex = 1;
            this.buttonLoadImage.Text = "Load Image";
            this.buttonLoadImage.UseVisualStyleBackColor = false;
            this.buttonLoadImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelFilterOptions
            // 
            this.panelFilterOptions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelFilterOptions.Controls.Add(this.labelOpacityOrBrightness);
            this.panelFilterOptions.Controls.Add(this.labelTrackBarValuePercent);
            this.panelFilterOptions.Controls.Add(this.trackBarOpacityOrBrightness);
            this.panelFilterOptions.Controls.Add(this.comboBoxFilterSelection);
            this.panelFilterOptions.Controls.Add(this.buttonLoadImage);
            this.panelFilterOptions.Controls.Add(this.buttonSecuential);
            this.panelFilterOptions.Controls.Add(this.buttonParallel);
            this.panelFilterOptions.Location = new System.Drawing.Point(1028, 31);
            this.panelFilterOptions.Name = "panelFilterOptions";
            this.panelFilterOptions.Size = new System.Drawing.Size(316, 211);
            this.panelFilterOptions.TabIndex = 9;
            // 
            // labelOpacityOrBrightness
            // 
            this.labelOpacityOrBrightness.AutoSize = true;
            this.labelOpacityOrBrightness.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpacityOrBrightness.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelOpacityOrBrightness.Location = new System.Drawing.Point(92, 92);
            this.labelOpacityOrBrightness.Name = "labelOpacityOrBrightness";
            this.labelOpacityOrBrightness.Size = new System.Drawing.Size(131, 16);
            this.labelOpacityOrBrightness.TabIndex = 12;
            this.labelOpacityOrBrightness.Text = "Value Percent Opacity";
            this.labelOpacityOrBrightness.Visible = false;
            // 
            // labelTrackBarValuePercent
            // 
            this.labelTrackBarValuePercent.AutoSize = true;
            this.labelTrackBarValuePercent.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackBarValuePercent.Location = new System.Drawing.Point(143, 108);
            this.labelTrackBarValuePercent.Name = "labelTrackBarValuePercent";
            this.labelTrackBarValuePercent.Size = new System.Drawing.Size(25, 14);
            this.labelTrackBarValuePercent.TabIndex = 11;
            this.labelTrackBarValuePercent.Text = "0 %";
            // 
            // trackBarOpacityOrBrightness
            // 
            this.trackBarOpacityOrBrightness.Location = new System.Drawing.Point(29, 125);
            this.trackBarOpacityOrBrightness.Maximum = 100;
            this.trackBarOpacityOrBrightness.Name = "trackBarOpacityOrBrightness";
            this.trackBarOpacityOrBrightness.Size = new System.Drawing.Size(259, 45);
            this.trackBarOpacityOrBrightness.TabIndex = 3;
            this.trackBarOpacityOrBrightness.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // comboBoxFilterSelection
            // 
            this.comboBoxFilterSelection.DisplayMember = "1";
            this.comboBoxFilterSelection.FormattingEnabled = true;
            this.comboBoxFilterSelection.Items.AddRange(new object[] {
            "Gray Scale",
            "Sepia",
            "Opacity",
            "Invert Colors",
            "Gaussin blur",
            "Adjusting brightness",
            "Rainbow",
            "Blues Balance"});
            this.comboBoxFilterSelection.Location = new System.Drawing.Point(3, 47);
            this.comboBoxFilterSelection.Name = "comboBoxFilterSelection";
            this.comboBoxFilterSelection.Size = new System.Drawing.Size(310, 21);
            this.comboBoxFilterSelection.TabIndex = 2;
            this.comboBoxFilterSelection.Tag = "";
            this.comboBoxFilterSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterSelection_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(1132, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Filter Options";
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.backButton.Location = new System.Drawing.Point(1258, 511);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(49, 19);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ImageProcesing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1349, 541);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelFilterOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxWFilterApplied);
            this.Controls.Add(this.pictureBoxWImageSearch);
            this.Name = "ImageProcesing";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWImageSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWFilterApplied)).EndInit();
            this.panelFilterOptions.ResumeLayout(false);
            this.panelFilterOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacityOrBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonParallel;
        private System.Windows.Forms.Button buttonSecuential;
        private System.Windows.Forms.PictureBox pictureBoxWImageSearch;
        private System.Windows.Forms.PictureBox pictureBoxWFilterApplied;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Panel panelFilterOptions;
        private System.Windows.Forms.TrackBar trackBarOpacityOrBrightness;
        private System.Windows.Forms.ComboBox comboBoxFilterSelection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTrackBarValuePercent;
        private System.Windows.Forms.Label labelOpacityOrBrightness;
        private System.Windows.Forms.Label backButton;
    }
}

