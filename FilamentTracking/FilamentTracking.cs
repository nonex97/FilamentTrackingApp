namespace FilamentTracking
{
    public partial class FilamentTracking : Form
    {
        public FilamentTracking()
        {
            InitializeComponent();
        }

        public void filamentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool hasSelection = filamentTable.SelectedRows.Count > 0;

            useFilamentButton.Enabled = hasSelection;
            deleteFilamentButton.Enabled = hasSelection;
        }

    }
}
