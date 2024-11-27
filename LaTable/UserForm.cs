using System.Globalization;
using System.Text.Json;

namespace LaTable
{
    public partial class UserForm : Form
    {
        private Data data = new Data();
        private User user;

        public UserForm(User _user)
        {
            InitializeComponent();
            data.InitializeDate();
            UpdateDateLabel();
            ShowDataInGrid();
            user = _user;
            nameLabel.Text = user.GetName();
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
