namespace Lab5_WebScraper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.ImagesTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FoundImageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 25);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(758, 23);
            this.textBox.TabIndex = 0;
            // 
            // ExtractButton
            // 
            this.ExtractButton.Location = new System.Drawing.Point(777, 24);
            this.ExtractButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(91, 24);
            this.ExtractButton.TabIndex = 1;
            this.ExtractButton.Text = "Extract";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // ImagesTextBox
            // 
            this.ImagesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagesTextBox.Location = new System.Drawing.Point(12, 67);
            this.ImagesTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ImagesTextBox.Multiline = true;
            this.ImagesTextBox.Name = "ImagesTextBox";
            this.ImagesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ImagesTextBox.Size = new System.Drawing.Size(858, 322);
            this.ImagesTextBox.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(779, 397);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 33);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save Images";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FoundImageLabel
            // 
            this.FoundImageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FoundImageLabel.AutoSize = true;
            this.FoundImageLabel.Location = new System.Drawing.Point(12, 400);
            this.FoundImageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FoundImageLabel.Name = "FoundImageLabel";
            this.FoundImageLabel.Size = new System.Drawing.Size(38, 15);
            this.FoundImageLabel.TabIndex = 4;
            this.FoundImageLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 444);
            this.Controls.Add(this.FoundImageLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ImagesTextBox);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.textBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageScraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.TextBox ImagesTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label FoundImageLabel;
    }
}