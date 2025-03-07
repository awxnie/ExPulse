using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExPulse
{
    public partial class TeacherForm : Form
    {
        private Data data = new Data();

        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            examGrid.DataSource = data.GetExamTableData();
            gradeGrid.DataSource = data.GetGradeTableData();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("Вы уверены, что хотите выйти?", "Подтверждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.FormClosed += (s, args) => this.Close();
                loginForm.Show();
                this.Hide();
            }
        }

        private void AddExamButton_Click(object sender, EventArgs e)
        {
            if(data.AddExam(NameTextBox.Text, DateTextBox.Text, TimeTextBox.Text, AuditoriumTextBox.Text))
            {
                NameTextBox.Clear();
                DateTextBox.Clear();
                TimeTextBox.Clear();
                AuditoriumTextBox.Clear();
                UpdateDataGridView();
            }
        }

        private void SaveGradeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные успешно добавлены!");
        }
    }
}
