namespace ExPulse
{
    internal class GridConfigurator
    {
        public void TranslateExamColumns(DataGridView examGrid)
        {
            foreach (DataGridViewColumn column in examGrid.Columns)
            {
                switch (column.Name)
                {
                    case "Name":
                        column.HeaderText = "Название";
                        break;
                    case "Date":
                        column.HeaderText = "Дата";
                        column.DefaultCellStyle.Format = "dd.MM.yyyy";
                        break;
                    case "Time":
                        column.HeaderText = "Время";
                        column.DefaultCellStyle.Format = @"hh\:mm";
                        break;
                    case "Auditorium":
                        column.HeaderText = "Аудитория";
                        break;
                }
            }
        }

        public void ResizeGradeColumns(DataGridView gradeGrid)
        {
            gradeGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            for (int i = 1; i < gradeGrid.Columns.Count; i++)
            {
                gradeGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
