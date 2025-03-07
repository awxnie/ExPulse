using MySql.Data.MySqlClient;

namespace ExPulse
{
    public partial class LoginForm : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=examdb;Username=root;Password=root;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            AuthUser(login, password);
        }

        private void AuthUser(string login, string password)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = $"SELECT role FROM users WHERE login = @login AND password = @password";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string userRole = reader["role"].ToString();

                switch (userRole)
                {
                    case "teacher":
                        TeacherForm teacherForm = new TeacherForm();
                        teacherForm.FormClosed += (s, args) => this.Close();
                        teacherForm.Show();
                        this.Hide();
                        break;
                    case "student":
                        StudentForm studentForm = new StudentForm();
                        studentForm.FormClosed += (s, args) => this.Close();
                        studentForm.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            connection.Close();
        }
    }
}