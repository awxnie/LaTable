using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace LaTable
{
    public class BaseForm : Form
    {
        public Data data = new Data();

        public BaseForm()
        {
            data.InitializeDate();
        }

        public void SetDataLabel(Label DateLabel)
        {
            var currentDate = new DateTime(data.currentYear, data.currentMonth, 1);
            string monthName = currentDate.ToString("MMMM", new CultureInfo("ru-RU"));
            string capitalizedMonthName = char.ToUpper(monthName[0]) + monthName.Substring(1);
            DateLabel.Visible = false;
            DateLabel.Text = $"{capitalizedMonthName}, {data.currentYear}";
            DateLabel.Visible = true;
        }

        public void ShowDataInGrid(DataGridView CalendarGrid)
        {
            data.dateTable.Columns.Clear();
            data.dateTable.Rows.Clear();
            string xmlFilePath = data.GetXmlFilePath();
            if (File.Exists(xmlFilePath))
            {
                data.dateTable.ReadXml(xmlFilePath);
            }
            else
            {
                data.CreateAndInitializeXml();
            }
            CalendarGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            CalendarGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            CalendarGrid.DataSource = data.dateTable;
            foreach (DataGridViewColumn column in CalendarGrid.Columns)
            {
                column.HeaderText = column.HeaderText.Substring(0, column.HeaderText.Length - 2);
            }
            CalendarGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CalendarGrid.Columns[0].ReadOnly = true;
            for (int i = 1; i < CalendarGrid.Columns.Count; i++)
            {
                CalendarGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            foreach (DataGridViewColumn column in CalendarGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            UpdateCellColors(CalendarGrid);
        }

        public void ForwardButtonClick(object sender, EventArgs e, Label DateLabel, DataGridView CalendarGrid)
        {
            data.SaveDataInXml();
            data.IncrementMonth();
            SetDataLabel(DateLabel);
            ShowDataInGrid(CalendarGrid);
        }

        public void BackButtonClick(object sender, EventArgs e, Label DateLabel, DataGridView CalendarGrid)
        {
            data.SaveDataInXml();
            data.DecrementMonth();
            SetDataLabel(DateLabel);
            ShowDataInGrid(CalendarGrid);
        }

        public void ExitButtonClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                AuthForm authForm = new AuthForm();
                authForm.FormClosed += (s, args) => this.Close();
                authForm.Show();
                this.Hide();
            }
        }

        public void CalendarGridCellValueChanged(object sender, DataGridViewCellEventArgs e, DataGridView CalendarGrid)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < CalendarGrid.Rows.Count && e.ColumnIndex < CalendarGrid.Columns.Count)
            {
                DataGridViewCell cell = CalendarGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                UpdateCellColor(cell);
            }
        }

        public Color GetColorForValue(string value)
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
                case "О":
                    return Color.Pink;
                default:
                    return Color.White;
            }
        }

        public void UpdateCellColor(DataGridViewCell cell)
        {
            string value = cell.Value?.ToString().ToUpper();
            cell.Style.BackColor = GetColorForValue(value);
        }

        public void UpdateCellColors(DataGridView CalendarGrid)
        {
            foreach (DataGridViewRow row in CalendarGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    UpdateCellColor(cell);
                }
            }
        }
    }
}
