namespace LaTable
{
    public partial class AuthForm : Form
    {
        private AdminForm adminForm = new AdminForm();
        private UserForm userForm;
        private UserService userService = new UserService();
 
        public AuthForm()
        {
            InitializeComponent();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "admin" && passwordTextBox.Text == "123")
            {
                adminForm.FormClosed += (s, args) => this.Close();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                User user = userService.Authenticate(loginTextBox.Text, passwordTextBox.Text);
                if (user != null)
                {
                    userForm = new UserForm(user);
                    userForm.FormClosed += (s, args) => this.Close();
                    userForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}