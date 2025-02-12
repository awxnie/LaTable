using System.ComponentModel;
using System.Data;

namespace LaTable
{
    public partial class AdminForm : MiddleForm
    {
        private int yOffset = 10;
        public override DataGridView CalendarGrid => calendarGrid;
        public override Label DateLabel => dateLabel;

        public AdminForm()
        {
            InitializeComponent();
            nameLabel.Text = "Admin";
            SetDataLabel();

            forwardButton.Click += ForwardButtonClick;
            backButton.Click += BackButtonClick;
            exitButton.Click += ExitButtonClick;
            calendarGrid.CellValueChanged += CalendarGridCellValueChanged;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            ShowDataInGrid();
            data.LoadDatesToList();
            AddDateControls();
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите очистить всё?", "Подтверждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                data.ClearDataInXml(data.currentYear, data.currentMonth);
                ShowDataInGrid();
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
