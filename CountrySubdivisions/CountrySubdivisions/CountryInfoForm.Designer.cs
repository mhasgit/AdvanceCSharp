namespace CountrySubdivisions
{
    public partial class CountryInfoForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            localesComboBox = new ComboBox();
            label1 = new Label();
            countryListBox = new ListBox();
            subdivisionListBox = new ListBox();
            SuspendLayout();
            // 
            // localesComboBox
            // 
            localesComboBox.FormattingEnabled = true;
            localesComboBox.Location = new Point(214, 13);
            localesComboBox.Name = "localesComboBox";
            localesComboBox.Size = new Size(331, 28);
            localesComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 21);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 1;
            label1.Text = "Select Locale";
            // 
            // countryListBox
            // 
            countryListBox.FormattingEnabled = true;
            countryListBox.ItemHeight = 20;
            countryListBox.Location = new Point(25, 71);
            countryListBox.Name = "countryListBox";
            countryListBox.Size = new Size(353, 364);
            countryListBox.TabIndex = 2;
            // 
            // subdivisionListBox
            // 
            subdivisionListBox.FormattingEnabled = true;
            subdivisionListBox.ItemHeight = 20;
            subdivisionListBox.Location = new Point(407, 71);
            subdivisionListBox.Name = "subdivisionListBox";
            subdivisionListBox.Size = new Size(369, 364);
            subdivisionListBox.TabIndex = 3;
            // 
            // CountryInfoFoam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(subdivisionListBox);
            Controls.Add(countryListBox);
            Controls.Add(label1);
            Controls.Add(localesComboBox);
            Name = "CountryInfoFoam";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox localesComboBox;
        private Label label1;
        private ListBox countryListBox;
        private ListBox subdivisionListBox;
    }
}