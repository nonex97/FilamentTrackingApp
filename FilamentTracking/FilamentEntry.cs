using FilamentLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FilamentTracking
{
    public partial class FilamentEntry : Form
    {
        public FilamentEntry()
        {
            InitializeComponent();

            materialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            materialComboBox.FormattingEnabled = true;
            materialComboBox.Format += (_, e) =>
            {
                if (e.ListItem is FilamentType.PLA_LW)
                    e.Value = "PLA-LW";
                if (e.ListItem is FilamentType.PLA_PLUS)
                    e.Value = "PLA+";
            };

            materialComboBox.DataSource = Enum.GetValues(typeof(FilamentType));
            materialComboBox.SelectedIndex = 0;

            weightUpDown.Enter += SelectNumericText;
            priceUpDown.Enter += SelectNumericText;
        }

        private void SelectNumericText(object? sender, EventArgs e)
        {
            if (sender is NumericUpDown input)
            {
                input.Select(0, input.Text.Length);
            }
        }
    }
}
