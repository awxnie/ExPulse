using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace ExPulse
{
    public partial class StudentForm : Form
    {
        private Data data = new Data();

        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
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
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.FormClosed += (s, args) => this.Close();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
