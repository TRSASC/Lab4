namespace Mobila {
    partial class PhoneForm {
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
            this.Speaker = new System.Windows.Forms.RadioButton();
            this.UnoffHeadset = new System.Windows.Forms.RadioButton();
            this.SamsHeadset = new System.Windows.Forms.RadioButton();
            this.ExtSpeaker = new System.Windows.Forms.RadioButton();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Speaker
            // 
            this.Speaker.AutoSize = true;
            this.Speaker.Location = new System.Drawing.Point(12, 7);
            this.Speaker.Name = "Speaker";
            this.Speaker.Size = new System.Drawing.Size(65, 17);
            this.Speaker.TabIndex = 0;
            this.Speaker.TabStop = true;
            this.Speaker.Text = "Speaker";
            this.Speaker.UseVisualStyleBackColor = true;
            this.Speaker.CheckedChanged += new System.EventHandler(this.Speaker_CheckedChanged);
            // 
            // UnoffHeadset
            // 
            this.UnoffHeadset.AutoSize = true;
            this.UnoffHeadset.Location = new System.Drawing.Point(12, 37);
            this.UnoffHeadset.Name = "UnoffHeadset";
            this.UnoffHeadset.Size = new System.Drawing.Size(110, 17);
            this.UnoffHeadset.TabIndex = 1;
            this.UnoffHeadset.TabStop = true;
            this.UnoffHeadset.Text = "Unofficial headset";
            this.UnoffHeadset.UseVisualStyleBackColor = true;
            this.UnoffHeadset.CheckedChanged += new System.EventHandler(this.UnoffHeadset_CheckedChanged);
            // 
            // SamsHeadset
            // 
            this.SamsHeadset.AutoSize = true;
            this.SamsHeadset.Location = new System.Drawing.Point(12, 67);
            this.SamsHeadset.Name = "SamsHeadset";
            this.SamsHeadset.Size = new System.Drawing.Size(110, 17);
            this.SamsHeadset.TabIndex = 2;
            this.SamsHeadset.TabStop = true;
            this.SamsHeadset.Text = "Samsung headset";
            this.SamsHeadset.UseVisualStyleBackColor = true;
            this.SamsHeadset.CheckedChanged += new System.EventHandler(this.SamsHeadset_CheckedChanged);
            // 
            // ExtSpeaker
            // 
            this.ExtSpeaker.AutoSize = true;
            this.ExtSpeaker.Location = new System.Drawing.Point(12, 97);
            this.ExtSpeaker.Name = "ExtSpeaker";
            this.ExtSpeaker.Size = new System.Drawing.Size(104, 17);
            this.ExtSpeaker.TabIndex = 3;
            this.ExtSpeaker.TabStop = true;
            this.ExtSpeaker.Text = "External speaker";
            this.ExtSpeaker.UseVisualStyleBackColor = true;
            this.ExtSpeaker.CheckedChanged += new System.EventHandler(this.ExtSpeaker_CheckedChanged);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(200, 30);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Padding = new System.Windows.Forms.Padding(2);
            this.buttonPlay.Size = new System.Drawing.Size(75, 25);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // PlaybackPanel
            // 
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 120);
            this.panel1.TabIndex = 5;
            // 
            // PlayTextBox
            // 
            this.PlayTextBox.Location = new System.Drawing.Point(20, 180);
            this.PlayTextBox.Multiline = true;
            this.PlayTextBox.Name = "PlayTextBox";
            this.PlayTextBox.Size = new System.Drawing.Size(240, 240);
            this.PlayTextBox.TabIndex = 6;
            // 
            // PhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonPlay);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "PhoneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone";
            this.PlaybackPanel.ResumeLayout(false);
            this.PlaybackPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Speaker;
        private System.Windows.Forms.RadioButton UnoffHeadset;
        private System.Windows.Forms.RadioButton SamsHeadset;
        private System.Windows.Forms.RadioButton ExtSpeaker;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

