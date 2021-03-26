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
            this.SaveButton = new System.Windows.Forms.Button();
            this.DownloadedImageLabel = new System.Windows.Forms.Label();
            this.ListBoxResult = new System.Windows.Forms.ListBox();
            this.btn_SaveAll = new System.Windows.Forms.Button();
            this.UrlFoundLabl = new System.Windows.Forms.Label();
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
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(659, 391);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 33);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save Images";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DownloadedImageLabel
            // 
            this.DownloadedImageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DownloadedImageLabel.AutoSize = true;
            this.DownloadedImageLabel.Location = new System.Drawing.Point(12, 400);
            this.DownloadedImageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DownloadedImageLabel.Name = "DownloadedImageLabel";
            this.DownloadedImageLabel.Size = new System.Drawing.Size(0, 15);
            this.DownloadedImageLabel.TabIndex = 4;
            // 
            // ListBoxResult
            // 
            this.ListBoxResult.FormattingEnabled = true;
            this.ListBoxResult.ItemHeight = 15;
            this.ListBoxResult.Location = new System.Drawing.Point(12, 58);
            this.ListBoxResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListBoxResult.Name = "ListBoxResult";
            this.ListBoxResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxResult.Size = new System.Drawing.Size(858, 319);
            this.ListBoxResult.TabIndex = 5;
            this.ListBoxResult.SelectedIndexChanged += new System.EventHandler(this.ListBoxResult_SelectedIndexChanged);
            // 
            // btn_SaveAll
            // 
            this.btn_SaveAll.Location = new System.Drawing.Point(757, 391);
            this.btn_SaveAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SaveAll.Name = "btn_SaveAll";
            this.btn_SaveAll.Size = new System.Drawing.Size(111, 33);
            this.btn_SaveAll.TabIndex = 6;
            this.btn_SaveAll.Text = "Save All Images";
            this.btn_SaveAll.UseVisualStyleBackColor = true;
            this.btn_SaveAll.Click += new System.EventHandler(this.btn_SaveAll_Click);
            // 
            // UrlFoundLabl
            // 
            this.UrlFoundLabl.AutoSize = true;
            this.UrlFoundLabl.Location = new System.Drawing.Point(88, 400);
            this.UrlFoundLabl.Name = "UrlFoundLabl";
            this.UrlFoundLabl.Size = new System.Drawing.Size(0, 15);
            this.UrlFoundLabl.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 444);
            this.Controls.Add(this.UrlFoundLabl);
            this.Controls.Add(this.btn_SaveAll);
            this.Controls.Add(this.ListBoxResult);
            this.Controls.Add(this.DownloadedImageLabel);
            this.Controls.Add(this.SaveButton);
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
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label DownloadedImageLabel;
        private System.Windows.Forms.ListBox ListBoxResult;
        private System.Windows.Forms.Button btn_SaveAll;
        private System.Windows.Forms.Label UrlFoundLabl;
    }
}