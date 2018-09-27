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
            this.FormatComboBox = new System.Windows.Forms.ComboBox();
            this.SenderComboBox = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.OrAndCheckBox = new System.Windows.Forms.CheckBox();
            this.MessageListView = new System.Windows.Forms.ListView();
            this.SMSSender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SMSText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            // SenderComboBox
            // 
            this.SenderComboBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SenderComboBox.FormattingEnabled = true;
            this.SenderComboBox.Location = new System.Drawing.Point(190, 35);
            this.SenderComboBox.Name = "SenderComboBox";
            this.SenderComboBox.Size = new System.Drawing.Size(120, 21);
            this.SenderComboBox.TabIndex = 2;
            this.SenderComboBox.SelectedIndexChanged += new System.EventHandler(this.SenderComboBox_SelectedIndexChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SearchTextBox.Location = new System.Drawing.Point(190, 74);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(120, 20);
            this.SearchTextBox.TabIndex = 3;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.Location = new System.Drawing.Point(190, 153);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.Size = new System.Drawing.Size(120, 20);
            this.FromDatePicker.TabIndex = 4;
            this.FromDatePicker.ValueChanged += new System.EventHandler(this.FromDatePicker_ValueChanged);
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.Location = new System.Drawing.Point(190, 194);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.Size = new System.Drawing.Size(120, 20);
            this.ToDatePicker.TabIndex = 5;
            this.ToDatePicker.ValueChanged += new System.EventHandler(this.ToDatePicker_ValueChanged);
            // 
            // OrAndCheckBox
            // 
            this.OrAndCheckBox.AutoSize = true;
            this.OrAndCheckBox.Location = new System.Drawing.Point(190, 114);
            this.OrAndCheckBox.Name = "OrAndCheckBox";
            this.OrAndCheckBox.Size = new System.Drawing.Size(92, 17);
            this.OrAndCheckBox.TabIndex = 6;
            this.OrAndCheckBox.Text = "And Condition";
            this.OrAndCheckBox.UseVisualStyleBackColor = true;
            this.OrAndCheckBox.CheckedChanged += new System.EventHandler(this.OrAndCheckBox_CheckedChanged);
            // 
            // MessageListView
            // 
            this.MessageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SMSSender,
            this.SMSText});
            this.MessageListView.Location = new System.Drawing.Point(25, 250);
            this.MessageListView.MaximumSize = new System.Drawing.Size(285, 335);
            this.MessageListView.MinimumSize = new System.Drawing.Size(285, 335);
            this.MessageListView.Name = "MessageListView";
            this.MessageListView.Size = new System.Drawing.Size(285, 335);
            this.MessageListView.TabIndex = 7;
            this.MessageListView.TileSize = new System.Drawing.Size(280, 30);
            this.MessageListView.UseCompatibleStateImageBehavior = false;
            this.MessageListView.View = System.Windows.Forms.View.Tile;
            // 
            // SMSPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 611);
            this.Controls.Add(this.MessageListView);
            this.Controls.Add(this.OrAndCheckBox);
            this.Controls.Add(this.ToDatePicker);
            this.Controls.Add(this.FromDatePicker);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SenderComboBox);
            this.Controls.Add(this.FormatComboBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 650);
            this.Name = "SMSPhone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMSPhone";
            this.Load += new System.EventHandler(this.SMSPhone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox FormatComboBox;
        private System.Windows.Forms.ComboBox SenderComboBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DateTimePicker FromDatePicker;
        private System.Windows.Forms.DateTimePicker ToDatePicker;
        private System.Windows.Forms.CheckBox OrAndCheckBox;
        private System.Windows.Forms.ListView MessageListView;
        private System.Windows.Forms.ColumnHeader SMSSender;
        private System.Windows.Forms.ColumnHeader SMSText;
    }
}

