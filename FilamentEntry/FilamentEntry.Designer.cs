namespace FilamentEntry
{
    partial class FilamentEntry
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
            nameLabel = new Label();
            manufacturerLabel = new Label();
            manufacturerText = new TextBox();
            materialLabel = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.ControlLightLight;
            nameLabel.Location = new Point(169, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(226, 47);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Add Filament";
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.ForeColor = SystemColors.ControlLightLight;
            manufacturerLabel.Location = new Point(12, 74);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new Size(158, 32);
            manufacturerLabel.TabIndex = 1;
            manufacturerLabel.Text = "Manufacturer";
            // 
            // manufacturerText
            // 
            manufacturerText.Location = new Point(176, 67);
            manufacturerText.Name = "manufacturerText";
            manufacturerText.Size = new Size(219, 39);
            manufacturerText.TabIndex = 2;
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.ForeColor = SystemColors.ControlLightLight;
            materialLabel.Location = new Point(12, 119);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(101, 32);
            materialLabel.TabIndex = 1;
            materialLabel.Text = "Material";
            materialLabel.Click += this.label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 39);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PLA", "PETG" });
            comboBox1.Location = new Point(226, 207);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 40);
            comboBox1.TabIndex = 3;
            // 
            // FilamentEntry
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(588, 418);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(materialLabel);
            Controls.Add(manufacturerText);
            Controls.Add(manufacturerLabel);
            Controls.Add(nameLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "FilamentEntry";
            Text = "Add Filament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label manufacturerLabel;
        private TextBox manufacturerText;
        private Label materialLabel;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}
