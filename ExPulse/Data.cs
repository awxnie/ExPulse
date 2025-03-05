using System;
using System.Data;
using System.Data.SqlClient;

namespace ExPulse
{
    internal class Data
    {
        private string connectionString;
        public List<string> exams = new List<string>();
        public List<string> students = new List<string>();

        public Data()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        }

        public void AddExam(string name, string date, string time, string auditorium)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Exams (Name, Date, Time, Auditorium) VALUES (@Name, @Date, @Time, @Auditorium)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@Time", time);
                    command.Parameters.AddWithValue("@Auditorium", auditorium);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public DataTable GetExams()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, Date, Time, Auditorium FROM Exams";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public List<string> GetExamNames()
        {
            List<string> examNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name FROM Exams";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string examName = reader.GetString(0);
                            examNames.Add(examName);
                        }
                    }
                }
            }

            return examNames;
        }

        public void InitializeGradeGrid(DataGridView gradeGrid)
        {
            gradeGrid.Columns.Clear();
            gradeGrid.Rows.Clear();
            exams = GetExamNames();
            students = new List<string>()
            {
                "Фламберг Алексей Вадимович",
                "Чернявский Михаил Александрович",
                "Рябков Максим Бракич",
                "Бахин Максим Баха",
                "Егоров Роман Сакутин"
            };

            gradeGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Ученик",
                ReadOnly = true
            });

            foreach (var exam in exams)
            {
                gradeGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = exam,
                    HeaderText = exam
                });
            }

            foreach (var student in students)
            {
                int rowIndex = gradeGrid.Rows.Add();
                gradeGrid.Rows[rowIndex].Cells["Name"].Value = student;
            }        
        }
    }
}
