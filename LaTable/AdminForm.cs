using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace LaTable
{
    public partial class AdminForm : Form
    {
        private Data data = new Data();
        private int yOffset = 10;

        public AdminForm()
        {
            InitializeComponent();
            data.InitializeDate();
            SetDataLabel();
            nameLabel.Text = "Admin";
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            ShowDataInGrid();
            data.LoadDatesToList();
            AddDateControls();
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
            string xmlFilePath = data.GetXmlFilePath(data.currentYear, data.currentMonth);
            if (File.Exists(xmlFilePath))
            {
                data.dataTable.ReadXml(data.GetXmlFilePath(data.currentYear, data.currentMonth));
            }
            else
            {
                data.CreateAndInitializeXml(data.currentYear, data.currentMonth);
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

        private void AddDateControls()
        {
            foreach (var item in data.dateList)
            {
                Label nameLabel = new Label
                {
                    Text = item.Key,
                    Size = new Size(120, 50),
                    Location = new Point(10, yOffset),
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = item
                };
                tabPage2.Controls.Add(nameLabel);

                Label timeLabel = new Label
                {
                    Text = item.Value.ToShortDateString(),
                    Size = new Size(120, 50),
                    Location = new Point(140, yOffset),
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = item
                };
                tabPage2.Controls.Add(timeLabel);

                Button actionButton = new Button
                {
                    Text = "Согласовать",
                    Size = new Size(120, 50),
                    Location = new Point(270, yOffset),
                    Tag = item
                };
                actionButton.Click += requestAcceptButton_Click;
                tabPage2.Controls.Add(actionButton);

                yOffset += 60;
            }
        }

        private void RearrangeControls()
        {
            yOffset = 10;
            foreach (Control control in tabPage2.Controls)
            {
                if (control is Label || control is Button)
                {
                    control.Location = new Point(control.Location.X, yOffset);

                    if (control.Location.X == 270)
                        yOffset += 60;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            data.SaveDataInXml(data.currentYear, data.currentMonth);
            MessageBox.Show("Данные внесены");
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            data.SaveDataInXml(data.currentYear, data.currentMonth);
            data.IncrementMonth();
            SetDataLabel();
            ShowDataInGrid();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            data.SaveDataInXml(data.currentYear, data.currentMonth);
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

        private void requestAcceptButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null || !(clickedButton.Tag is KeyValuePair<string, DateTime> date))
                return;

            var controlsToRemove = tabPage2.Controls
                .Cast<Control>()
                .Where(c => c.Tag != null && c.Tag.Equals(date))
                .ToList();

            foreach (var control in controlsToRemove)
            {
                tabPage2.Controls.Remove(control);
                control.Dispose();
            }

            data.RemoveDateFromJson(date.Key, date.Value);

            RearrangeControls();

            data.AddDateToXml(date.Key, date.Value);
            ShowDataInGrid();
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
