using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace LaTable
{
    public partial class AdminForm : BaseForm
    {
        private int yOffset = 10;

        public AdminForm()
        {
            InitializeComponent();
            nameLabel.Text = "Admin";
            SetDataLabel(dateLabel);

            forwardButton.Click += (sender, e) => ForwardButtonClick(sender, e, dateLabel, calendarGrid);
            backButton.Click += (sender, e) => BackButtonClick(sender, e, dateLabel, calendarGrid);
            calendarGrid.CellValueChanged += (sender, e) => CalendarGridCellValueChanged(sender, e, calendarGrid);
            exitButton.Click += ExitButtonClick;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            ShowDataInGrid(calendarGrid);
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

                Label timeLabel = new Label
                {
                    Text = item.Value.ToShortDateString(),
                    Size = new Size(120, 50),
                    Location = new Point(140, yOffset),
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = item
                };

                Button actionButton = new Button
                {
                    Text = "Согласовать",
                    Size = new Size(120, 50),
                    Location = new Point(270, yOffset),
                    Tag = item
                };
                actionButton.Click += requestAcceptButton_Click;

                datePanel.Controls.Add(timeLabel);
                datePanel.Controls.Add(nameLabel);
                datePanel.Controls.Add(actionButton);

                yOffset += 60;
            }
        }

        private void RearrangeControls()
        {
            yOffset = 10;
            foreach (Control control in datePanel.Controls)
            {
                if (control is Label || control is Button)
                {
                    control.Location = new Point(control.Location.X, yOffset);

                    if (control is Button)
                    {
                        yOffset += 60;
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            data.SaveDataInXml();
            MessageBox.Show("Данные внесены");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите очистить всё?", "Подтверждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                data.ClearDataInXml();
                ShowDataInGrid(calendarGrid);
            }
        }

        private void requestAcceptButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null || !(clickedButton.Tag is KeyValuePair<string, DateTime> date))
                return;

            var controlsToRemove = datePanel.Controls
                .Cast<Control>()
                .Where(c => c.Tag != null && c.Tag.Equals(date))
                .ToList();

            foreach (var control in controlsToRemove)
            {
                datePanel.Controls.Remove(control);
                control.Dispose();
            }

            data.RemoveDateFromJson(date.Key, date.Value);

            RearrangeControls();

            data.AddDateToXml(date.Key, date.Value);
            ShowDataInGrid(calendarGrid);
        }

        private void makeButton_Click(object sender, EventArgs e)
        {
            data.AddShifts();
            UpdateCellColors(calendarGrid);
        }
    }
}
