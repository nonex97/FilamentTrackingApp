namespace FilamentTracking
{
    partial class FilamentEntry
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
            materialComboBox = new ComboBox();
            materialLabel = new Label();
            manufacturerText = new TextBox();
            manufacturerLabel = new Label();
            nameLabel = new Label();
            colorLabel = new Label();
            colorText = new TextBox();
            weightLabel = new Label();
            priceLabel = new Label();
            dateLabel = new Label();
            datePicker = new DateTimePicker();
            weightUpDown = new NumericUpDown();
            priceUpDown = new NumericUpDown();
            addFilamentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)weightUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceUpDown).BeginInit();
            SuspendLayout();
            // 
            // materialComboBox
            // 
            materialComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            materialComboBox.FormattingEnabled = true;
            materialComboBox.Location = new Point(188, 136);
            materialComboBox.Name = "materialComboBox";
            materialComboBox.Size = new Size(219, 40);
            materialComboBox.TabIndex = 2;
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.ForeColor = SystemColors.ControlLightLight;
            materialLabel.Location = new Point(24, 144);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(101, 32);
            materialLabel.TabIndex = 5;
            materialLabel.Text = "Material";
            // 
            // manufacturerText
            // 
            manufacturerText.Location = new Point(188, 91);
            manufacturerText.Name = "manufacturerText";
            manufacturerText.Size = new Size(219, 39);
            manufacturerText.TabIndex = 1;
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.ForeColor = SystemColors.ControlLightLight;
            manufacturerLabel.Location = new Point(24, 98);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new Size(158, 32);
            manufacturerLabel.TabIndex = 6;
            manufacturerLabel.Text = "Manufacturer";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.ControlLightLight;
            nameLabel.Location = new Point(106, 25);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(226, 47);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Add Filament";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.ForeColor = SystemColors.ControlLightLight;
            colorLabel.Location = new Point(24, 189);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(71, 32);
            colorLabel.TabIndex = 6;
            colorLabel.Text = "Color";
            // 
            // colorText
            // 
            colorText.Location = new Point(188, 182);
            colorText.Name = "colorText";
            colorText.Size = new Size(219, 39);
            colorText.TabIndex = 3;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.ForeColor = SystemColors.ControlLightLight;
            weightLabel.Location = new Point(24, 234);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(125, 32);
            weightLabel.TabIndex = 6;
            weightLabel.Text = "Weight (g)";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.ForeColor = SystemColors.ControlLightLight;
            priceLabel.Location = new Point(24, 279);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(65, 32);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Price";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.ForeColor = SystemColors.ControlLightLight;
            dateLabel.Location = new Point(24, 324);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(123, 32);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Purchased";
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(188, 317);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(219, 39);
            datePicker.TabIndex = 6;
            // 
            // weightUpDown
            // 
            weightUpDown.Location = new Point(188, 227);
            weightUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            weightUpDown.Name = "weightUpDown";
            weightUpDown.Size = new Size(219, 39);
            weightUpDown.TabIndex = 4;
            // 
            // priceUpDown
            // 
            priceUpDown.DecimalPlaces = 2;
            priceUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            priceUpDown.Location = new Point(188, 272);
            priceUpDown.Name = "priceUpDown";
            priceUpDown.Size = new Size(219, 39);
            priceUpDown.TabIndex = 5;
            // 
            // addFilamentButton
            // 
            addFilamentButton.Location = new Point(106, 379);
            addFilamentButton.Name = "addFilamentButton";
            addFilamentButton.Size = new Size(218, 39);
            addFilamentButton.TabIndex = 7;
            addFilamentButton.Text = "Add spool";
            addFilamentButton.UseVisualStyleBackColor = true;
            addFilamentButton.Click += addFilamentButton_Click;
            // 
            // FilamentEntry
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(432, 448);
            Controls.Add(addFilamentButton);
            Controls.Add(priceUpDown);
            Controls.Add(weightUpDown);
            Controls.Add(datePicker);
            Controls.Add(materialComboBox);
            Controls.Add(materialLabel);
            Controls.Add(dateLabel);
            Controls.Add(priceLabel);
            Controls.Add(weightLabel);
            Controls.Add(colorText);
            Controls.Add(colorLabel);
            Controls.Add(manufacturerText);
            Controls.Add(manufacturerLabel);
            Controls.Add(nameLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "FilamentEntry";
            Text = "FilamentEntry";
            ((System.ComponentModel.ISupportInitialize)weightUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox materialComboBox;
        private Label materialLabel;
        private TextBox manufacturerText;
        private Label manufacturerLabel;
        private Label nameLabel;
        private Label colorLabel;
        private TextBox colorText;
        private Label weightLabel;
        private Label priceLabel;
        private Label dateLabel;
        private DateTimePicker datePicker;
        private NumericUpDown weightUpDown;
        private NumericUpDown priceUpDown;
        private Button addFilamentButton;
    }
}