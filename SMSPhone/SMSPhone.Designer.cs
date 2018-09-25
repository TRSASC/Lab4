namespace SMSPhone {
    partial class SMSPhone {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SMSTextBox = new System.Windows.Forms.TextBox();
            this.FormatComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SMSTextBox
            // 
            this.SMSTextBox.Location = new System.Drawing.Point(25, 100);
            this.SMSTextBox.MaximumSize = new System.Drawing.Size(235, 335);
            this.SMSTextBox.MinimumSize = new System.Drawing.Size(235, 335);
            this.SMSTextBox.Multiline = true;
            this.SMSTextBox.Name = "SMSTextBox";
            this.SMSTextBox.Size = new System.Drawing.Size(235, 335);
            this.SMSTextBox.TabIndex = 0;
            // 
            // FormatComboBox
            // 
            this.FormatComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormatComboBox.FormattingEnabled = true;
            this.FormatComboBox.Location = new System.Drawing.Point(25, 35);
            this.FormatComboBox.Name = "FormatComboBox";
            this.FormatComboBox.Size = new System.Drawing.Size(120, 21);
            this.FormatComboBox.TabIndex = 1;
            this.FormatComboBox.SelectedIndexChanged += new System.EventHandler(this.FormatComboBox_SelectedIndexChanged);
            // 
            // SMSPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.FormatComboBox);
            this.Controls.Add(this.SMSTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "SMSPhone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMSPhone";
            this.Load += new System.EventHandler(this.SMSPhone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SMSTextBox;
        private System.Windows.Forms.ComboBox FormatComboBox;
    }
}

