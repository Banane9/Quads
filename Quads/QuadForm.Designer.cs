namespace Quads
{
    partial class QuadForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.openImageButton = new System.Windows.Forms.Button();
            this.resultImage = new System.Windows.Forms.PictureBox();
            this.updateResultButton = new System.Windows.Forms.Button();
            this.iterationsTextBox = new System.Windows.Forms.TextBox();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.spacedCheckBox = new System.Windows.Forms.CheckBox();
            this.shapeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stepsTextBox = new System.Windows.Forms.TextBox();
            this.stepsLabel = new System.Windows.Forms.Label();
            this.saveGifBatchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultImage)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "Image Files|*.png; *.jpg; *.jpeg; *.bmp";
            this.openImageDialog.Title = "Select an Image";
            // 
            // openImageButton
            // 
            this.openImageButton.Location = new System.Drawing.Point(12, 745);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(152, 23);
            this.openImageButton.TabIndex = 0;
            this.openImageButton.Text = "Open Image";
            this.openImageButton.UseVisualStyleBackColor = true;
            this.openImageButton.Click += new System.EventHandler(this.openImageButton_Click);
            // 
            // resultImage
            // 
            this.resultImage.Location = new System.Drawing.Point(12, 12);
            this.resultImage.Name = "resultImage";
            this.resultImage.Size = new System.Drawing.Size(1401, 725);
            this.resultImage.TabIndex = 2;
            this.resultImage.TabStop = false;
            // 
            // updateResultButton
            // 
            this.updateResultButton.Location = new System.Drawing.Point(762, 745);
            this.updateResultButton.Name = "updateResultButton";
            this.updateResultButton.Size = new System.Drawing.Size(179, 23);
            this.updateResultButton.TabIndex = 3;
            this.updateResultButton.Text = "Update Preview";
            this.updateResultButton.UseVisualStyleBackColor = true;
            this.updateResultButton.Click += new System.EventHandler(this.updateResultButton_Click);
            // 
            // iterationsTextBox
            // 
            this.iterationsTextBox.Location = new System.Drawing.Point(279, 747);
            this.iterationsTextBox.Name = "iterationsTextBox";
            this.iterationsTextBox.Size = new System.Drawing.Size(58, 20);
            this.iterationsTextBox.TabIndex = 4;
            this.iterationsTextBox.Text = "1";
            this.iterationsTextBox.TextChanged += new System.EventHandler(this.iterationsTextBox_TextChanged);
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.AutoSize = true;
            this.iterationsLabel.Location = new System.Drawing.Point(220, 750);
            this.iterationsLabel.Name = "iterationsLabel";
            this.iterationsLabel.Size = new System.Drawing.Size(53, 13);
            this.iterationsLabel.TabIndex = 5;
            this.iterationsLabel.Text = "Iterations:";
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.AddExtension = false;
            // 
            // saveImageButton
            // 
            this.saveImageButton.Location = new System.Drawing.Point(979, 745);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(127, 23);
            this.saveImageButton.TabIndex = 6;
            this.saveImageButton.Text = "Save Result Image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // spacedCheckBox
            // 
            this.spacedCheckBox.AutoSize = true;
            this.spacedCheckBox.Checked = true;
            this.spacedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.spacedCheckBox.Location = new System.Drawing.Point(400, 749);
            this.spacedCheckBox.Name = "spacedCheckBox";
            this.spacedCheckBox.Size = new System.Drawing.Size(63, 17);
            this.spacedCheckBox.TabIndex = 8;
            this.spacedCheckBox.Text = "Spaced";
            this.spacedCheckBox.UseVisualStyleBackColor = true;
            // 
            // shapeComboBox
            // 
            this.shapeComboBox.FormattingEnabled = true;
            this.shapeComboBox.Items.AddRange(new object[] {
            "Quad",
            "Ellipse"});
            this.shapeComboBox.Location = new System.Drawing.Point(573, 747);
            this.shapeComboBox.Name = "shapeComboBox";
            this.shapeComboBox.Size = new System.Drawing.Size(121, 21);
            this.shapeComboBox.TabIndex = 9;
            this.shapeComboBox.Text = "Quad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 750);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Shape:";
            // 
            // stepsTextBox
            // 
            this.stepsTextBox.Location = new System.Drawing.Point(1192, 747);
            this.stepsTextBox.Name = "stepsTextBox";
            this.stepsTextBox.Size = new System.Drawing.Size(56, 20);
            this.stepsTextBox.TabIndex = 11;
            this.stepsTextBox.Text = "1";
            this.stepsTextBox.TextChanged += new System.EventHandler(this.stepsTextBox_TextChanged);
            // 
            // stepsLabel
            // 
            this.stepsLabel.AutoSize = true;
            this.stepsLabel.Location = new System.Drawing.Point(1149, 750);
            this.stepsLabel.Name = "stepsLabel";
            this.stepsLabel.Size = new System.Drawing.Size(37, 13);
            this.stepsLabel.TabIndex = 12;
            this.stepsLabel.Text = "Steps:";
            // 
            // saveGifBatchButton
            // 
            this.saveGifBatchButton.Location = new System.Drawing.Point(1295, 745);
            this.saveGifBatchButton.Name = "saveGifBatchButton";
            this.saveGifBatchButton.Size = new System.Drawing.Size(118, 23);
            this.saveGifBatchButton.TabIndex = 15;
            this.saveGifBatchButton.Text = "Save GIF Batch";
            this.saveGifBatchButton.UseVisualStyleBackColor = true;
            this.saveGifBatchButton.Click += new System.EventHandler(this.saveGifBatchButton_Click);
            // 
            // QuadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 778);
            this.Controls.Add(this.saveGifBatchButton);
            this.Controls.Add(this.stepsLabel);
            this.Controls.Add(this.stepsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeComboBox);
            this.Controls.Add(this.spacedCheckBox);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.iterationsLabel);
            this.Controls.Add(this.iterationsTextBox);
            this.Controls.Add(this.updateResultButton);
            this.Controls.Add(this.resultImage);
            this.Controls.Add(this.openImageButton);
            this.Name = "QuadForm";
            this.Text = "Quad Tree Image Maker";
            ((System.ComponentModel.ISupportInitialize)(this.resultImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Button openImageButton;
        private System.Windows.Forms.PictureBox resultImage;
        private System.Windows.Forms.Button updateResultButton;
        private System.Windows.Forms.TextBox iterationsTextBox;
        private System.Windows.Forms.Label iterationsLabel;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.CheckBox spacedCheckBox;
        private System.Windows.Forms.ComboBox shapeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stepsTextBox;
        private System.Windows.Forms.Label stepsLabel;
        private System.Windows.Forms.Button saveGifBatchButton;
    }
}

