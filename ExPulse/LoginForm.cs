namespace ExPulse
{
    public partial class LoginForm : Form
    {
        private Dictionary<string, string> teacherCredentials;
        private Dictionary<string, string> studentCredentials;

        public LoginForm()
        {
            InitializeComponent();

            teacherCredentials = new Dictionary<string, string>
            {
                { "zxc", "123" },
                { "smaga", "1111" },
                { "negodaev", "1111" },
            };

            studentCredentials = new Dictionary<string, string>
            {
                { "asd", "123" },
                { "leha", "1111" },
                { "miha", "1111" },
                { "roma", "1111" },
            };
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (teacherCredentials.ContainsKey(login) && 
                teacherCredentials[login] == password)
            {
                TeacherForm teacherForm = new TeacherForm();
                teacherForm.FormClosed += (s, args) => this.Close();
                teacherForm.Show();
                this.Hide();
            }
            else if (studentCredentials.ContainsKey(login) && 
                studentCredentials[login] == password)
            {
                StudentForm studentForm = new StudentForm();
                studentForm.FormClosed += (s, args) => this.Close();
                studentForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}