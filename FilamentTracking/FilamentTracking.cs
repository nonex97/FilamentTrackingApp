using FilamentLibrary;
using System.ComponentModel;

namespace FilamentTracking
{
    public partial class FilamentTracking : Form
    {
        BindingList<FilamentModel> filaments = new BindingList<FilamentModel>();

        public FilamentTracking()
        {
            InitializeComponent();

            FilamentModel one = new FilamentModel
            {
                Manufacturer = "ESUN",
                Color = "Black",
                RemainingGrams = 100,
                Price = 19,
                Type = FilamentType.PLA,
                DatePurchased = new DateOnly(2025, 1, 1)
            };

            filaments.Add(one);


            filamentTable.AutoGenerateColumns = false;
            filamentTable.DataSource = filaments;

        }

        public void filamentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool hasSelection = filamentTable.SelectedRows.Count > 0;

            useFilamentButton.Enabled = hasSelection;
            deleteFilamentButton.Enabled = hasSelection;
        }

        private void addFilamentButton_Click(object sender, EventArgs e)
        {
            // Opens add filament form
            FilamentEntry entry = new FilamentEntry();
            entry.Show();

        }

        private void deleteFilamentButton_Click(object sender, EventArgs e)
        {
            // Opens pop-up if user is sure they want to delete spool
        }

        private void useFilamentButton_Click(object sender, EventArgs e)
        {
            // Opens edit spool form where weight of print can be added - that weight is then subtracted from available (maybe if it's zero ask if user wants to delete?)
        }
    }
}
