namespace CountriesFormApp
{
    partial class CountriesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.localesComboBox = new System.Windows.Forms.ComboBox();
            this.countryListBox = new System.Windows.Forms.ListBox();
            this.subdivisionListBox = new System.Windows.Forms.ListBox();
            this.flagPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flagPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Locales";
            // 
            // localesComboBox
            // 
            this.localesComboBox.FormattingEnabled = true;
            this.localesComboBox.Location = new System.Drawing.Point(150, 18);
            this.localesComboBox.Name = "localesComboBox";
            this.localesComboBox.Size = new System.Drawing.Size(280, 24);
            this.localesComboBox.TabIndex = 1;
            // 
            // countryListBox
            // 
            this.countryListBox.FormattingEnabled = true;
            this.countryListBox.ItemHeight = 16;
            this.countryListBox.Location = new System.Drawing.Point(12, 78);
            this.countryListBox.Name = "countryListBox";
            this.countryListBox.Size = new System.Drawing.Size(363, 356);
            this.countryListBox.TabIndex = 2;
            // 
            // subdivisionListBox
            // 
            this.subdivisionListBox.FormattingEnabled = true;
            this.subdivisionListBox.ItemHeight = 16;
            this.subdivisionListBox.Location = new System.Drawing.Point(393, 78);
            this.subdivisionListBox.Name = "subdivisionListBox";
            this.subdivisionListBox.Size = new System.Drawing.Size(395, 356);
            this.subdivisionListBox.TabIndex = 3;
            // 
            // flagPictureBox
            // 
            this.flagPictureBox.Location = new System.Drawing.Point(481, 12);
            this.flagPictureBox.Name = "flagPictureBox";
            this.flagPictureBox.Size = new System.Drawing.Size(148, 50);
            this.flagPictureBox.TabIndex = 4;
            this.flagPictureBox.TabStop = false;
            // 
            // CountriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flagPictureBox);
            this.Controls.Add(this.subdivisionListBox);
            this.Controls.Add(this.countryListBox);
            this.Controls.Add(this.localesComboBox);
            this.Controls.Add(this.label1);
            this.Name = "CountriesForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flagPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox localesComboBox;
        private System.Windows.Forms.ListBox countryListBox;
        private System.Windows.Forms.ListBox subdivisionListBox;
        private System.Windows.Forms.PictureBox flagPictureBox;
    }
}

