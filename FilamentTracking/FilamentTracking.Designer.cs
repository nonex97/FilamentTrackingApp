namespace FilamentTracking
{
    partial class FilamentTracking
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
            filamentTable = new DataGridView();
            Manufacturer = new DataGridViewTextBoxColumn();
            Material = new DataGridViewTextBoxColumn();
            Color = new DataGridViewTextBoxColumn();
            Remaining = new DataGridViewTextBoxColumn();
            Purchased = new DataGridViewTextBoxColumn();
            useFilamentButton = new Button();
            deleteFilamentButton = new Button();
            addFilamentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)filamentTable).BeginInit();
            SuspendLayout();
            // 
            // filamentTable
            // 
            filamentTable.AllowUserToAddRows = false;
            filamentTable.AllowUserToDeleteRows = false;
            filamentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            filamentTable.Columns.AddRange(new DataGridViewColumn[] { Manufacturer, Material, Color, Remaining, Purchased });
            filamentTable.Location = new Point(12, 12);
            filamentTable.MultiSelect = false;
            filamentTable.Name = "filamentTable";
            filamentTable.ReadOnly = true;
            filamentTable.RowHeadersWidth = 40;
            filamentTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            filamentTable.Size = new Size(896, 315);
            filamentTable.TabIndex = 0;
            filamentTable.CellContentClick += filamentTable_CellContentClick;
            // 
            // Manufacturer
            // 
            Manufacturer.DataPropertyName = "Manufacturer";
            Manufacturer.HeaderText = "Manufacturer";
            Manufacturer.Name = "Manufacturer";
            Manufacturer.ReadOnly = true;
            Manufacturer.Width = 200;
            // 
            // Material
            // 
            Material.DataPropertyName = "Type";
            Material.HeaderText = "Material";
            Material.Name = "Material";
            Material.ReadOnly = true;
            Material.Width = 110;
            // 
            // Color
            // 
            Color.DataPropertyName = "Color";
            Color.HeaderText = "Color";
            Color.Name = "Color";
            Color.ReadOnly = true;
            Color.Width = 190;
            // 
            // Remaining
            // 
            Remaining.DataPropertyName = "RemainingGrams";
            Remaining.HeaderText = "Remaining (g)";
            Remaining.Name = "Remaining";
            Remaining.ReadOnly = true;
            Remaining.Width = 200;
            // 
            // Purchased
            // 
            Purchased.DataPropertyName = "DatePurchased";
            Purchased.HeaderText = "Purchased";
            Purchased.Name = "Purchased";
            Purchased.ReadOnly = true;
            Purchased.Width = 150;
            // 
            // useFilamentButton
            // 
            useFilamentButton.Enabled = false;
            useFilamentButton.Location = new Point(142, 333);
            useFilamentButton.Name = "useFilamentButton";
            useFilamentButton.Size = new Size(124, 44);
            useFilamentButton.TabIndex = 1;
            useFilamentButton.Text = "Use";
            useFilamentButton.UseVisualStyleBackColor = true;
            useFilamentButton.Click += useFilamentButton_Click;
            // 
            // deleteFilamentButton
            // 
            deleteFilamentButton.Enabled = false;
            deleteFilamentButton.Location = new Point(272, 333);
            deleteFilamentButton.Name = "deleteFilamentButton";
            deleteFilamentButton.Size = new Size(124, 44);
            deleteFilamentButton.TabIndex = 1;
            deleteFilamentButton.Text = "Delete";
            deleteFilamentButton.UseVisualStyleBackColor = true;
            deleteFilamentButton.Click += deleteFilamentButton_Click;
            // 
            // addFilamentButton
            // 
            addFilamentButton.Location = new Point(12, 333);
            addFilamentButton.Name = "addFilamentButton";
            addFilamentButton.Size = new Size(124, 44);
            addFilamentButton.TabIndex = 1;
            addFilamentButton.Text = "Add";
            addFilamentButton.UseVisualStyleBackColor = true;
            addFilamentButton.Click += addFilamentButton_Click;
            // 
            // FilamentTracking
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(920, 422);
            Controls.Add(deleteFilamentButton);
            Controls.Add(addFilamentButton);
            Controls.Add(useFilamentButton);
            Controls.Add(filamentTable);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "FilamentTracking";
            Text = "Filament Tracking";
            ((System.ComponentModel.ISupportInitialize)filamentTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView filamentTable;
        private Button button1;
        private Button useFilamentButton;
        private Button deleteFilamentButton;
        private Button addFilamentButton;
        private DataGridViewTextBoxColumn Manufacturer;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn Remaining;
        private DataGridViewTextBoxColumn Purchased;
    }
}
