using System.Globalization;

namespace LaTable
{
    public partial class UserForm : MiddleForm
    {
        private User user;

        public override DataGridView CalendarGrid => calendarGrid;
        public override Label DateLabel => dateLabel;

        public UserForm(User User)
        {
            InitializeComponent();
            SetDataLabel();
            user = User;
            nameLabel.Text = user.GetName();

            forwardButton.Click += ForwardButtonClick;
            backButton.Click += BackButtonClick;
            exitButton.Click += ExitButtonClick;
            calendarGrid.CellValueChanged += CalendarGridCellValueChanged;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            ShowDataInGrid();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.ParseExact(dateTextBox.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                data.AddDateToList(user.GetName(), date);

                if (!File.Exists($"Data/{date.Year}{date.Month}.xml"))
                {
                    data.CreateAndInitializeXml(date.Year, date.Month);
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
