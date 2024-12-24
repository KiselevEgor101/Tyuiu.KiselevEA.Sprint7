using System.Data;
using System.Text;

namespace Tyuiu.KiselevEA.Sprint7.Project.V9.Lib
{
    public class DataService
    {
        public DataTable ReadCsvToDataTable(string filePath)
        {
            DataTable dataTable = new DataTable();
            string[] lines = File.ReadAllLines(filePath);

            // Обработка заголовков
            if (lines.Length > 0)
            {
                string[] header = lines[0].Split(';');
                foreach (var column in header)
                {
                    dataTable.Columns.Add(column);
                }

                // Заполнение данных
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] rows = lines[i].Split(';');
                    dataTable.Rows.Add(rows);
                }
            }

            return dataTable;

        }
    }
}
