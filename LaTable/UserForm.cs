using System.Globalization;

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
            SetDataLabel();
            user = _user;
            nameLabel.Text = user.GetName();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            ShowDataInGrid();
        }

        private void SetDataLabel()
        {
            var currentDate = new DateTime(data.currentYear, data.currentMonth, 1);
            string monthName = currentDate.ToString("MMMM", new CultureInfo("ru-RU"));
            string capitalizedMonthName = char.ToUpper(monthName[0]) + monthName.Substring(1);
            dateLabel.Text = $"{capitalizedMonthName}, {data.currentYear}";
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
            UpdateCellColors();

            calendarGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            for (int i = 1; i < calendarGrid.Columns.Count; i++)
            {
                calendarGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            foreach (DataGridViewColumn column in calendarGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            data.IncrementMonth();
            SetDataLabel();
            ShowDataInGrid();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            data.DecrementMonth();
            SetDataLabel();
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

        private void calendarGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = calendarGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            UpdateCellColor(cell);
        }

        private Color GetColorForValue(string value)
        {
            switch (value)
            {
                case "У":
                    return Color.Gold;
                case "В":
                    return Color.Turquoise;
                case "Н":
                    return Color.CadetBlue;
                case "П":
                    return Color.Red;
                case "ВХ":
                    return Color.SpringGreen;
                case "R":
                    return Color.Magenta;
                default:
                    return Color.White;
            }
        }

        private void UpdateCellColor(DataGridViewCell cell)
        {
            string value = cell.Value?.ToString().ToUpper();
            cell.Style.BackColor = GetColorForValue(value);
        }

        private void UpdateCellColors()
        {
            foreach (DataGridViewRow row in calendarGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    UpdateCellColor(cell);
                }
            }
        }
    }
}
