using System.Globalization;

namespace LaTable
{
    public partial class UserForm : BaseForm
    {
        private User user;

        public UserForm(User User)
        {
            InitializeComponent();
            SetDataLabel(dateLabel);
            user = User;
            nameLabel.Text = user.GetName();

            forwardButton.Click += (sender, e) => ForwardButtonClick(sender, e, dateLabel, calendarGrid);
            backButton.Click += (sender, e) => ForwardButtonClick(sender, e, dateLabel, calendarGrid);
            calendarGrid.CellValueChanged += (sender, e) => CalendarGridCellValueChanged(sender, e, calendarGrid);
            exitButton.Click += ExitButtonClick;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            ShowDataInGrid(calendarGrid);
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.ParseExact(dateTextBox.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                data.AddDateToList(user.GetName(), date);

                if (!File.Exists($"Data/{date.Year}{date.Month}.xml"))
                {
                    data.CreateAndInitializeXml();
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
