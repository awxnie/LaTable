using System.Globalization;
using System.Text.Json;
using System.Windows.Forms;

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
            if (!File.Exists($"Data/{data.currentYear}{data.currentMonth}.xml"))
            {
                data.CreateAndInitializeXml(data.currentYear, data.currentMonth);
            }
            else
            {
                data.dataTable.ReadXml(data.GetXmlFilePath(data.currentYear, data.currentMonth));
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

        private void inputButton_Click(object sender, EventArgs e)
        {
            try
            {
                data.AddDateToList(user.GetName(), new DateTime(
                int.Parse(yearTextBox.Text),
                int.Parse(monthTextBox.Text),
                int.Parse(dayTextBox.Text)));

                if (!File.Exists($"Data/{int.Parse(yearTextBox.Text)}{int.Parse(monthTextBox.Text)}.xml"))
                {
                    data.CreateAndInitializeXml(int.Parse(yearTextBox.Text), int.Parse(monthTextBox.Text));
                }
                
                MessageBox.Show("Выходной заказан");
            }
            catch
            {
                MessageBox.Show("Некорректный ввод");
            }
        }
    }
}
