using System.Data;
using System.Globalization;
using System.Xml;

namespace LaTable
{
    public partial class AdminForm : Form
    {
        private Data data = new Data();

        public AdminForm()
        {
            InitializeComponent();
            data.InitializeDate();
            UpdateDateLabel();
            ShowDataInGrid();
            nameLabel.Text = "Admin";
        }

        private void UpdateDateLabel()
        {
            dateLabel.Text = new DateTime(data.currentYear, data.currentMonth, 1).AddMonths(0).ToString("MMMM", new CultureInfo("ru-RU"))
                + ", " + data.currentYear;
        }

        private void ShowDataInGrid()
        {
            data.dataTable.Columns.Clear();
            data.dataTable.Rows.Clear();
            try
            {
                data.dataTable.ReadXml(data.GetXmlFilePath());
            }
            catch
            {
                data.CreateAndInitializeXml();
            }
            calendarGrid.DataSource = data.dataTable;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            data.SaveDataInXml();
            MessageBox.Show("Данные внесены");
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            data.IncrementMonth();
            UpdateDateLabel();
            ShowDataInGrid();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            data.DecrementMonth();
            UpdateDateLabel();
            ShowDataInGrid();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
