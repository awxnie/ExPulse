using MySql.Data.MySqlClient;
using System.Data;

namespace ExPulse
{
    internal class Data
    {
        string connectionString = 
        "Server=localhost;Port=3306;Database=examdb;Username=root;Password=root;";

        public DataTable GetGradeTableData()
        {
            List<string> exams = new List<string>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT name FROM exams", connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                exams.Add(reader["name"].ToString());
            }
            reader.Close();

            List<string> caseStatements = new List<string>();
            foreach (string exam in exams)
            {
                caseStatements.Add($"MAX(CASE WHEN e.name = '{exam}' THEN g.value END) AS `{exam}`");
            }
            string query = $@"
            SELECT 
                s.fullname AS Студент,
                {string.Join(", ", caseStatements)}
                FROM students s
                LEFT JOIN grades g ON s.idstudents = g.idstudent
                LEFT JOIN exams e ON g.idexam = e.idexam
                GROUP BY s.idstudents, s.fullname";

            command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
        public DataTable GetExamTableData()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT " +
                                                    "name AS 'Название', " +
                                                    "date AS 'Дата', " +
                                                    "time AS 'Время', " +
                                                    "auditorium AS 'Аудитория' " +
                                                    $"FROM exams", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            reader.Close();
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public bool AddExam(string Name, string Date, string Time, string Auditorium)
        {
            string name = Name;
            string date = Date;
            string time = Time;
            string auiditoruim = Auditorium;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO exams (name, date, time, auditorium)" +
                "VALUES(@name, @date, @time, @auditorium)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@time", time);
            command.Parameters.AddWithValue("@auditorium", auiditoruim);
            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                MessageBox.Show("Запись успешно добавлена");
                return true;
            }
            catch
            {
                MessageBox.Show("Некорректный ввод");
                return false;
            }
        }

    }
}
