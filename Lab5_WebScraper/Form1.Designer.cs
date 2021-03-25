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
            this.FoundImageLabel = new System.Windows.Forms.Label();
            this.ListBoxResult = new System.Windows.Forms.ListBox();
            this.btn_SaveAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(10, 22);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(650, 20);
            this.textBox.TabIndex = 0;
            // 
            // ExtractButton
            // 
            this.ExtractButton.Location = new System.Drawing.Point(666, 21);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(78, 21);
            this.ExtractButton.TabIndex = 1;
            this.ExtractButton.Text = "Extract";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(565, 339);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(78, 29);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save Images";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FoundImageLabel
            // 
            this.FoundImageLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FoundImageLabel.AutoSize = true;
            this.FoundImageLabel.Location = new System.Drawing.Point(10, 347);
            this.FoundImageLabel.Name = "FoundImageLabel";
            this.FoundImageLabel.Size = new System.Drawing.Size(0, 13);
            this.FoundImageLabel.TabIndex = 4;
            // 
            // ListBoxResult
            // 
            this.ListBoxResult.FormattingEnabled = true;
            this.ListBoxResult.Location = new System.Drawing.Point(10, 50);
            this.ListBoxResult.Name = "ListBoxResult";
            this.ListBoxResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxResult.Size = new System.Drawing.Size(736, 277);
            this.ListBoxResult.TabIndex = 5;
            // 
            // btn_SaveAll
            // 
            this.btn_SaveAll.Location = new System.Drawing.Point(649, 339);
            this.btn_SaveAll.Name = "btn_SaveAll";
            this.btn_SaveAll.Size = new System.Drawing.Size(95, 29);
            this.btn_SaveAll.TabIndex = 6;
            this.btn_SaveAll.Text = "Save All Images";
            this.btn_SaveAll.UseVisualStyleBackColor = true;
            this.btn_SaveAll.Click += new System.EventHandler(this.btn_SaveAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 385);
            this.Controls.Add(this.btn_SaveAll);
            this.Controls.Add(this.ListBoxResult);
            this.Controls.Add(this.FoundImageLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.textBox);
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
        private System.Windows.Forms.Label FoundImageLabel;
        private System.Windows.Forms.ListBox ListBoxResult;
        private System.Windows.Forms.Button btn_SaveAll;
    }
}