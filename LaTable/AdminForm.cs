using System.Data;
using System.Globalization;

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
            UpdateDateLabel();
            ShowDataInGrid();
            nameLabel.Text = "Admin";
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            data.LoadDatesToList();
            AddDateControls();
        }

        private void UpdateDateLabel()
        {
            var currentDate = new DateTime(data.currentYear, data.currentMonth, 1);
            dateLabel.Text = currentDate.ToString("MMMM", new CultureInfo("ru-RU")) + $", {data.currentYear}";
        }

        private void ShowDataInGrid()
        {
            data.dataTable.Columns.Clear();
            data.dataTable.Rows.Clear();
            try
            {
                data.dataTable.ReadXml(data.GetXmlFilePath(data.currentYear, data.currentMonth));
            }
            catch
            {
                data.CreateAndInitializeXml(data.currentYear, data.currentMonth);
            }
            calendarGrid.DataSource = null;
            calendarGrid.DataSource = data.dataTable;
            calendarGrid.Refresh();
        }

        private void AddDateControls()
        {
            foreach (var item in data.dateList)
            {
                Label nameLabel = new Label
                {
                    Text = item.Key,
                    Size = new System.Drawing.Size(120, 50),
                    Location = new System.Drawing.Point(10, yOffset),
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Tag = item
                };
                tabPage2.Controls.Add(nameLabel);

                Label timeLabel = new Label
                {
                    Text = item.Value.ToShortDateString(),
                    Size = new System.Drawing.Size(120, 50),
                    Location = new System.Drawing.Point(140, yOffset),
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Tag = item
                };
                tabPage2.Controls.Add(timeLabel);

                Button actionButton = new Button
                {
                    Text = "Согласовать",
                    Size = new System.Drawing.Size(120, 50),
                    Location = new System.Drawing.Point(270, yOffset),
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
                    control.Location = new System.Drawing.Point(control.Location.X, yOffset);

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
    }
}
