using System.Windows.Forms;
using System.Xml.Linq;

namespace ExPulse
{
    public partial class TeacherForm : Form
    {
        private Data data = new Data();
        private GridConfigurator gridConfigurator = new GridConfigurator();

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
            examGrid.DataSource = data.GetExams();
            data.InitializeGradeGrid(gradeGrid);
            gridConfigurator.TranslateExamColumns(examGrid);
            gridConfigurator.ResizeGradeColumns(gradeGrid);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("Вы уверены, что хотите выйти?", "Подтверждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void AddExamButton_Click(object sender, EventArgs e)
        {
            data.AddExam(NameTextBox.Text, DateTextBox.Text, TimeTextBox.Text, AuditoriumTextBox.Text);
            MessageBox.Show("Данные успешно добавлены!");
            UpdateDataGridView();
        }

        private void SaveGradeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные успешно добавлены!");
        }
    }
}
