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
                DatePurchased = new DateOnly(2025,1,1)
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

    }
}
