using System.ComponentModel;
using System.Globalization;

namespace LaTable
{
    public class AbstractCommunicatorProvider : TypeDescriptionProvider
    {
        public AbstractCommunicatorProvider() : base(TypeDescriptor.GetProvider(typeof(Form)))
        {
        }
        public override Type GetReflectionType(Type objectType, object instance)
        {
            return typeof(Form);
        }
        public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
        {
            objectType = typeof(Form);
            return base.CreateInstance(provider, objectType, argTypes, args);
        }
    }

    [TypeDescriptionProvider(typeof(AbstractCommunicatorProvider))]
    public abstract class BaseForm : Form
    {
        public Data data = new Data();
        public abstract DataGridView CalendarGrid { get; }
        public abstract Label DateLabel { get; }

        public BaseForm()
        {
            data.InitializeDate();
        }

        public virtual void SetDataLabel()
        {
            var currentDate = new DateTime(data.currentYear, data.currentMonth, 1);
            string monthName = currentDate.ToString("MMMM", new CultureInfo("ru-RU"));
            string capitalizedMonthName = char.ToUpper(monthName[0]) + monthName.Substring(1);
            DateLabel.Visible = false;
            DateLabel.Text = $"{capitalizedMonthName}, {data.currentYear}";
            DateLabel.Visible = true;
        }

        public virtual void ShowDataInGrid()
        {
            data.dataTable.Columns.Clear();
            data.dataTable.Rows.Clear();
            string xmlFilePath = data.GetXmlFilePath(data.currentYear, data.currentMonth);
            if (File.Exists(xmlFilePath))
            {
                data.dataTable.ReadXml(xmlFilePath);
            }
            else
            {
                data.CreateAndInitializeXml(data.currentYear, data.currentMonth);
            }
            CalendarGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            CalendarGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            CalendarGrid.DataSource = data.dataTable;
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

            UpdateCellColors();
        }

        public virtual void ForwardButtonClick(object sender, EventArgs e)
        {
            data.SaveDataInXml(data.currentYear, data.currentMonth);
            data.IncrementMonth();
            SetDataLabel();
            ShowDataInGrid();
        }

        public virtual void BackButtonClick(object sender, EventArgs e)
        {
            data.SaveDataInXml(data.currentYear, data.currentMonth);
            data.DecrementMonth();
            SetDataLabel();
            ShowDataInGrid();
        }

        public virtual void ExitButtonClick(object sender, EventArgs e)
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

        public virtual void CalendarGridCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = CalendarGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            UpdateCellColor(cell);
        }

        public virtual Color GetColorForValue(string value)
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

        public virtual void UpdateCellColor(DataGridViewCell cell)
        {
            string value = cell.Value?.ToString().ToUpper();
            cell.Style.BackColor = GetColorForValue(value);
        }

        public virtual void UpdateCellColors()
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
