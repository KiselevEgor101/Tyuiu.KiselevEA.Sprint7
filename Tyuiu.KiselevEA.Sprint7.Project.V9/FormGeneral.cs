using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KiselevEA.Sprint7.Project.V9.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.KiselevEA.Sprint7.Project.V9
{
    public partial class FormGeneral : Form
    {
        public FormGeneral()
        {

            InitializeComponent();
        }
        private int counter = 33;
        private int currentRowIndex = 32;

        DataService ds = new DataService();
        static string openFilePath;
        static int rows;
        static int cols;
        static string[,] matrix;


        private void buttonBackMenu_KEA_Click(object sender, EventArgs e)
        {

            using (FormMenu Formmenu = new FormMenu())
            {
                Formmenu.TopMost = true;
                Formmenu.ShowDialog();
            }

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpen_KEA_Click(object sender, EventArgs e)
        {
            // увеличиваем колонны
            dataGridViewData_KEA.Columns[1].Width = 200;
            dataGridViewData_KEA.Columns[5].Width = 200;
            dataGridViewData_KEA.Columns[9].Width = 150;

            // Уменьшаем колонны
            dataGridViewData_KEA.Columns[0].Width = 30;
            dataGridViewData_KEA.Columns[2].Width = 50;
            dataGridViewData_KEA.Columns[3].Width = 100;
            dataGridViewData_KEA.Columns[7].Width = 50;
            dataGridViewData_KEA.Columns[8].Width = 70;


            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "CSV Files|*.csv|All Files|*.*";
                    openFileDialog.Title = "Выберите CSV файл";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                        // Читаем данные из CSV файла
                        var lines = File.ReadAllLines(filePath);
                        foreach (var line in lines)
                        {
                            // Используем метод Split для деления строки на значения
                            var values = line.Split(';', StringSplitOptions.RemoveEmptyEntries);

                            // Добавляем строку в dataGridView
                            dataGridViewData_KEA.Rows.Add(values);
                        }
                        MessageBox.Show("Данные успешно загружены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxSave_KEA_Click(object sender, EventArgs e)
        {

        }

        private void FormGeneral_Load(object sender, EventArgs e)
        {

        }

        public void dataGridViewData_KEA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonSave_KEA_Click(object sender, EventArgs e)
        {
            saveFileDialogData_KEA.FileName = "DataSetProject.csv";
            saveFileDialogData_KEA.InitialDirectory = Directory.GetCurrentDirectory();

            if (saveFileDialogData_KEA.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialogData_KEA.FileName;

                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                int rows = dataGridViewData_KEA.RowCount;
                int columns = dataGridViewData_KEA.ColumnCount;

                StringBuilder strBuilder = new StringBuilder();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        strBuilder.Append(dataGridViewData_KEA.Rows[i].Cells[j].Value);

                        if (j != columns - 1)
                        {
                            strBuilder.Append(";");
                        }
                    }

                    strBuilder.AppendLine();
                }

                File.WriteAllText(path, strBuilder.ToString(), Encoding.UTF8);

                MessageBox.Show("Файл успешно сохранен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void saveFileDialogData_KEA_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonOpenGraph_KEA_Click(object sender, EventArgs e)
        {
            FormGraphx Formgraphx = new FormGraphx();

            Formgraphx.TopMost = true;
            Formgraphx.ShowDialog();



        }



        private void комедияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewData_KEA.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для фильтрации.");
                return;
            }

            List<DataGridViewRow> filteredRows = new List<DataGridViewRow>();
            Regex regex = new Regex(@"(?i)комедия"); // Регистронезависимый поиск 

            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {
                if (row.Cells[6].Value != null &&
                    regex.IsMatch(row.Cells[6].Value.ToString().Trim()))
                {
                    filteredRows.Add((DataGridViewRow)row.Clone());
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        filteredRows[filteredRows.Count - 1].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }

            dataGridViewData_KEA.Rows.Clear();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Нет фильтрованных данных для отображения.");
                return;
            }

            foreach (var filteredRow in filteredRows)
            {
                dataGridViewData_KEA.Rows.Add(filteredRow);
            }

        }

        private void драмаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewData_KEA.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для фильтрации.");
                return;
            }

            List<DataGridViewRow> filteredRows = new List<DataGridViewRow>();
            Regex regex = new Regex(@"(?i)драма"); 

            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {
                if (row.Cells[6].Value != null &&
                    regex.IsMatch(row.Cells[6].Value.ToString().Trim()))
                {
                    filteredRows.Add((DataGridViewRow)row.Clone());
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        filteredRows[filteredRows.Count - 1].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }

            dataGridViewData_KEA.Rows.Clear();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Нет фильтрованных данных для отображения.");
                return;
            }

            foreach (var filteredRow in filteredRows)
            {
                dataGridViewData_KEA.Rows.Add(filteredRow);
            }
        }

        private void buttonClear_KEA_Click(object sender, EventArgs e)
        {
            dataGridViewData_KEA.Rows.Clear();
        }

        private void фантастикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewData_KEA.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для фильтрации.");
                return;
            }

            List<DataGridViewRow> filteredRows = new List<DataGridViewRow>();
            Regex regex = new Regex(@"(?i)фантастика"); 

            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {
                if (row.Cells[6].Value != null &&
                    regex.IsMatch(row.Cells[6].Value.ToString().Trim()))
                {
                    filteredRows.Add((DataGridViewRow)row.Clone());
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        filteredRows[filteredRows.Count - 1].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }

            dataGridViewData_KEA.Rows.Clear();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Нет фильтрованных данных для отображения.");
                return;
            }

            foreach (var filteredRow in filteredRows)
            {
                dataGridViewData_KEA.Rows.Add(filteredRow);
            }
        }

        private void мультфильмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewData_KEA.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для фильтрации.");
                return;
            }

            List<DataGridViewRow> filteredRows = new List<DataGridViewRow>();
            Regex regex = new Regex(@"(?i)мультфильм"); 

            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {

                if (row.Cells[5].Value != null &&
                    regex.IsMatch(row.Cells[5].Value.ToString().Trim()))
                {
                    filteredRows.Add((DataGridViewRow)row.Clone());
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        filteredRows[filteredRows.Count - 1].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }

            dataGridViewData_KEA.Rows.Clear();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Нет фильтрованных данных для отображения.");
                return;
            }

            foreach (var filteredRow in filteredRows)
            {
                dataGridViewData_KEA.Rows.Add(filteredRow);
            }
        }

        private void полнометражныйФильмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewData_KEA.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для фильтрации.");
                return;
            }

            List<DataGridViewRow> filteredRows = new List<DataGridViewRow>();
            Regex regex = new Regex(@"(?i)полнометражный фильм"); 

            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {

                if (row.Cells[5].Value != null &&
                    regex.IsMatch(row.Cells[5].Value.ToString().Trim()))
                {
                    filteredRows.Add((DataGridViewRow)row.Clone());
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        filteredRows[filteredRows.Count - 1].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }

            dataGridViewData_KEA.Rows.Clear();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Нет фильтрованных данных для отображения.");
                return;
            }

            foreach (var filteredRow in filteredRows)
            {
                dataGridViewData_KEA.Rows.Add(filteredRow);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_KEA_Click(object sender, EventArgs e)
        {

            string nameValue = textBoxName_KEA.Text;
            string timeValue = textBoxTime_KEA.Text;
            string weighValue = textBoxWeigh_KEA.Text;
            string FormatValue = textBox4.Text;
            string CategoryValue = textBoxCategory_KEA.Text;
            string GenreValue = textBoxGenre_KEA.Text;
            string YearValue = textBoxYear_KEA.Text;
            string MoneyValue = textBoxMoney_KEA.Text;
            string DirectorValue = textBoxDirector_KEA.Text;

            string formattedNameValue = $"\"\"\"{nameValue}\"\"\"";

            if (string.IsNullOrWhiteSpace(textBoxName_KEA.Text) ||
            string.IsNullOrWhiteSpace(textBoxTime_KEA.Text) ||
            string.IsNullOrWhiteSpace(textBoxWeigh_KEA.Text) ||
            string.IsNullOrWhiteSpace(textBox4.Text) ||
            string.IsNullOrWhiteSpace(textBoxCategory_KEA.Text) ||
            string.IsNullOrWhiteSpace(textBoxGenre_KEA.Text) ||
            string.IsNullOrWhiteSpace(textBoxYear_KEA.Text) ||
            string.IsNullOrWhiteSpace(textBoxMoney_KEA.Text) ||
            string.IsNullOrWhiteSpace(textBoxDirector_KEA.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return; 
            }

            int rowIndex = dataGridViewData_KEA.Rows.Add();


            dataGridViewData_KEA.Rows[rowIndex].Cells[1].Value = formattedNameValue;


            dataGridViewData_KEA.Rows[rowIndex].Cells[2].Value = timeValue;


            dataGridViewData_KEA.Rows[rowIndex].Cells[3].Value = weighValue;

            dataGridViewData_KEA.Rows[rowIndex].Cells[4].Value = FormatValue;

            dataGridViewData_KEA.Rows[rowIndex].Cells[5].Value = CategoryValue;

            dataGridViewData_KEA.Rows[rowIndex].Cells[6].Value = GenreValue;

            dataGridViewData_KEA.Rows[rowIndex].Cells[7].Value = YearValue;

            dataGridViewData_KEA.Rows[rowIndex].Cells[8].Value = MoneyValue;

            dataGridViewData_KEA.Rows[rowIndex].Cells[9].Value = DirectorValue;

            
            if (currentRowIndex < dataGridViewData_KEA.Rows.Count)
            {
                dataGridViewData_KEA.Rows[currentRowIndex].Cells[0].Value = counter + 0; 
                counter++;
                currentRowIndex++;
            }
            else
            {
                MessageBox.Show("Все строки заполнены или их нет.");
                
                dataGridViewData_KEA.Rows.Add();
                
                currentRowIndex = 31;
            }
            textBoxName_KEA.Clear();
            textBoxTime_KEA.Clear();
            textBoxWeigh_KEA.Clear();
            textBox4.Clear();
            textBoxCategory_KEA.Clear();
            textBoxGenre_KEA.Clear();
            textBoxYear_KEA.Clear();
            textBoxMoney_KEA.Clear();
            textBoxDirector_KEA.Clear();
        }

        private void textBoxName_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTime_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void боевикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewData_KEA.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для фильтрации.");
                return;
            }

            List<DataGridViewRow> filteredRows = new List<DataGridViewRow>();
            Regex regex = new Regex(@"(?i)боевик");

            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {

                if (row.Cells[6].Value != null &&
                    regex.IsMatch(row.Cells[6].Value.ToString().Trim()))
                {
                    filteredRows.Add((DataGridViewRow)row.Clone());
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        filteredRows[filteredRows.Count - 1].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }

            dataGridViewData_KEA.Rows.Clear();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Нет фильтрованных данных для отображения.");
                return;
            }

            foreach (var filteredRow in filteredRows)
            {
                dataGridViewData_KEA.Rows.Add(filteredRow);
            }
        }

        private void textBoxCategory_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void триллерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewData_KEA.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для фильтрации.");
                return;
            }

            List<DataGridViewRow> filteredRows = new List<DataGridViewRow>();
            Regex regex = new Regex(@"(?i)триллер");

            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {

                if (row.Cells[6].Value != null &&
                    regex.IsMatch(row.Cells[6].Value.ToString().Trim()))
                {
                    filteredRows.Add((DataGridViewRow)row.Clone());
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        filteredRows[filteredRows.Count - 1].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }

            dataGridViewData_KEA.Rows.Clear();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Нет фильтрованных данных для отображения.");
                return;
            }

            foreach (var filteredRow in filteredRows)
            {
                dataGridViewData_KEA.Rows.Add(filteredRow);
            }
        }

        private void мультфильмToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void мультфильмToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            if (dataGridViewData_KEA.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для фильтрации.");
                return;
            }

            List<DataGridViewRow> filteredRows = new List<DataGridViewRow>();
            Regex regex = new Regex(@"(?i)мультфильм");

            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {

                if (row.Cells[5].Value != null &&
                    regex.IsMatch(row.Cells[5].Value.ToString().Trim()))
                {
                    filteredRows.Add((DataGridViewRow)row.Clone());
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        filteredRows[filteredRows.Count - 1].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }

            dataGridViewData_KEA.Rows.Clear();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Нет фильтрованных данных для отображения.");
                return;
            }

            foreach (var filteredRow in filteredRows)
            {
                dataGridViewData_KEA.Rows.Add(filteredRow);
            }
        }

        private void россияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewData_KEA.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для фильтрации.");
                return;
            }

            List<DataGridViewRow> filteredRows = new List<DataGridViewRow>();
            Regex regex = new Regex(@"(?i)Россия");

            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {

                if (row.Cells[4].Value != null &&
                    regex.IsMatch(row.Cells[4].Value.ToString().Trim()))
                {
                    filteredRows.Add((DataGridViewRow)row.Clone());
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        filteredRows[filteredRows.Count - 1].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }

            dataGridViewData_KEA.Rows.Clear();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Нет фильтрованных данных для отображения.");
                return;
            }

            foreach (var filteredRow in filteredRows)
            {
                dataGridViewData_KEA.Rows.Add(filteredRow);
            }
        }

        private void сШАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewData_KEA.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для фильтрации.");
                return;
            }

            List<DataGridViewRow> filteredRows = new List<DataGridViewRow>();
            Regex regex = new Regex(@"(?i)сша");

            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {

                if (row.Cells[4].Value != null &&
                    regex.IsMatch(row.Cells[4].Value.ToString().Trim()))
                {
                    filteredRows.Add((DataGridViewRow)row.Clone());
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        filteredRows[filteredRows.Count - 1].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }

            dataGridViewData_KEA.Rows.Clear();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Нет фильтрованных данных для отображения.");
                return;
            }

            foreach (var filteredRow in filteredRows)
            {
                dataGridViewData_KEA.Rows.Add(filteredRow);
            }
        }

        private void францияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewData_KEA.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для фильтрации.");
                return;
            }

            List<DataGridViewRow> filteredRows = new List<DataGridViewRow>();
            Regex regex = new Regex(@"(?i)франция");

            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {

                if (row.Cells[4].Value != null &&
                    regex.IsMatch(row.Cells[4].Value.ToString().Trim()))
                {
                    filteredRows.Add((DataGridViewRow)row.Clone());
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        filteredRows[filteredRows.Count - 1].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }

            dataGridViewData_KEA.Rows.Clear();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Нет фильтрованных данных для отображения.");
                return;
            }

            foreach (var filteredRow in filteredRows)
            {
                dataGridViewData_KEA.Rows.Add(filteredRow);
            }
        }

        private void меньшеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<(TimeSpan duration, DataGridViewRow row)> durations = new List<(TimeSpan, DataGridViewRow)>();

            // Извлечение значений из третьей колонки
            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {
                if (row.Cells[2].Value != null) // Проверка есть ли знач
                {
                    TimeSpan time;
                    // Попробуем распарсить значение в TimeSpan
                    if (TimeSpan.TryParse(row.Cells[2].Value.ToString(), out time))
                    {
                        durations.Add((time, row));
                    }
                }
            }

            // Проверяем найдены ли длительности
            if (durations.Count == 0)
            {
                MessageBox.Show("В третьей колонне нет валидных значений для сортировки.");
                return;
            }

            // Сортируем список по убыванию
            var sortedDurations = durations.OrderByDescending(d => d.duration).ToList();

            // Очищаем dataGridView для добавления отсортированных данных
            dataGridViewData_KEA.Rows.Clear();

            // Заполняем dataGridView отсортированными строками
            foreach (var item in sortedDurations)
            {
                dataGridViewData_KEA.Rows.Add(
                    item.row.Cells[0].Value,
                    item.row.Cells[1].Value,
                    item.row.Cells[2].Value,
                    item.row.Cells[3].Value,
                    item.row.Cells[4].Value,
                    item.row.Cells[5].Value,
                    item.row.Cells[6].Value,
                    item.row.Cells[7].Value,
                    item.row.Cells[8].Value,
                    item.row.Cells[9].Value
                );
            }
        }

        private void большеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<(TimeSpan duration, DataGridViewRow row)> durations = new List<(TimeSpan, DataGridViewRow)>();

            // Извлечение значений из третьей колонки
            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {
                if (row.Cells[2].Value != null) // Проверка, есть ли значение
                {
                    TimeSpan time;
                    // Попробуем распарсить значение в TimeSpan
                    if (TimeSpan.TryParse(row.Cells[2].Value.ToString(), out time))
                    {
                        durations.Add((time, row));
                    }
                }
            }

            // Проверяем, найдены ли длительности
            if (durations.Count == 0)
            {
                MessageBox.Show("В третьей колонне нет валидных значений для сортировки.");
                return;
            }

            // Сортируем список по возрастанию
            var sortedDurations = durations.OrderBy(d => d.duration).ToList();

            // Очищаем dataGridView для добавления отсортированных данных
            dataGridViewData_KEA.Rows.Clear();

            // Заполняем dataGridView отсортированными строками
            foreach (var item in sortedDurations)
            {
                dataGridViewData_KEA.Rows.Add(
                    item.row.Cells[0].Value,
                    item.row.Cells[1].Value,
                    item.row.Cells[2].Value,
                    item.row.Cells[3].Value,
                    item.row.Cells[4].Value,
                    item.row.Cells[5].Value,
                    item.row.Cells[6].Value,
                    item.row.Cells[7].Value,
                    item.row.Cells[8].Value,
                    item.row.Cells[9].Value
                );
            }
        }

        private void большеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            List<(TimeSpan duration, DataGridViewRow row)> durations = new List<(TimeSpan, DataGridViewRow)>();

            // Извлечение значений из третьей колонки
            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {
                if (row.Cells[2].Value != null) // Проверка, есть ли значение
                {
                    TimeSpan time;
                    // Попробуем распарсить значение в TimeSpan
                    if (TimeSpan.TryParse(row.Cells[2].Value.ToString(), out time))
                    {
                        durations.Add((time, row));
                    }
                }
            }

            // Проверяем, найдены ли длительности
            if (durations.Count == 0)
            {
                MessageBox.Show("В третьей колонне нет валидных значений для сортировки.");
                return;
            }

            // Сортируем список по возрастанию
            var sortedDurations = durations.OrderBy(d => d.duration).ToList();

            // Очищаем dataGridView для добавления отсортированных данных
            dataGridViewData_KEA.Rows.Clear();

            // Заполняем dataGridView отсортированными строками
            foreach (var item in sortedDurations)
            {
                dataGridViewData_KEA.Rows.Add(
                    item.row.Cells[0].Value,
                    item.row.Cells[1].Value,
                    item.row.Cells[2].Value,
                    item.row.Cells[3].Value,
                    item.row.Cells[4].Value,
                    item.row.Cells[5].Value,
                    item.row.Cells[6].Value,
                    item.row.Cells[7].Value,
                    item.row.Cells[8].Value,
                    item.row.Cells[9].Value
                );
            }
        }

        private void меньшеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var rowsWithValues = new List<(DataGridViewRow Row, double SizeInGb)>();

            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    var value = row.Cells[3].Value.ToString();
                    double sizeInGb;

                    sizeInGb = double.TryParse(value.Replace(" Gb", "").Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out sizeInGb) ? sizeInGb : 0;
                    rowsWithValues.Add((row, sizeInGb));
                }
            }

            var sortedRows = rowsWithValues.OrderByDescending(r => r.SizeInGb).ToList();

            dataGridViewData_KEA.Rows.Clear();

            foreach (var item in sortedRows)
            {
                var row = item.Row;
                dataGridViewData_KEA.Rows.Add(
                    row.Cells[0].Value,
                    row.Cells[1].Value,
                    row.Cells[2].Value,
                    row.Cells[3].Value,
                    row.Cells[4].Value,
                    row.Cells[5].Value,
                    row.Cells[6].Value,
                    row.Cells[7].Value,
                    row.Cells[8].Value,
                    row.Cells[9].Value
                );
            }
        }

        private void большеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Объявляем переменную перед использованием
            var rowsWithValues = new List<(DataGridViewRow Row, double SizeInGb)>();

            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    var value = row.Cells[3].Value.ToString();
                    double sizeInGb;

                    sizeInGb = double.TryParse(value.Replace(" Gb", "").Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out sizeInGb) ? sizeInGb : 0;
                    rowsWithValues.Add((row, sizeInGb));
                }
            }

            // Сортируем по возрастанию
            var sortedRows = rowsWithValues.OrderBy(r => r.SizeInGb).ToList();

            dataGridViewData_KEA.Rows.Clear();

            foreach (var item in sortedRows)
            {
                var row = item.Row;
                dataGridViewData_KEA.Rows.Add(
                    row.Cells[0].Value,
                    row.Cells[1].Value,
                    row.Cells[2].Value,
                    row.Cells[3].Value,
                    row.Cells[4].Value,
                    row.Cells[5].Value,
                    row.Cells[6].Value,
                    row.Cells[7].Value,
                    row.Cells[8].Value,
                    row.Cells[9].Value
                );
            }

        }

        private void сШАToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewData_KEA.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для фильтрации.");
                return;
            }

            List<DataGridViewRow> filteredRows = new List<DataGridViewRow>();
            Regex regex = new Regex(@"(?i)сша"); // Регистронезависимый поиск "мультфильм"

            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {

                if (row.Cells[4].Value != null &&
                    regex.IsMatch(row.Cells[4].Value.ToString().Trim()))
                {
                    filteredRows.Add((DataGridViewRow)row.Clone());
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        filteredRows[filteredRows.Count - 1].Cells[i].Value = row.Cells[i].Value;
                    }
                }
            }

            dataGridViewData_KEA.Rows.Clear();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Нет фильтрованных данных для отображения.");
                return;
            }

            foreach (var filteredRow in filteredRows)
            {
                dataGridViewData_KEA.Rows.Add(filteredRow);
            }
        }

        private void меньшеToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли данные в DataGridView
            if (dataGridViewData_KEA.Rows.Count > 0)
            {
                // Сортируем 8 колонку по убыванию
                dataGridViewData_KEA.Sort(dataGridViewData_KEA.Columns[7], System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void большеToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли данные в DataGridView
            if (dataGridViewData_KEA.Rows.Count > 0)
            {
                // Сортируем 8 колонку по возрастанию
                dataGridViewData_KEA.Sort(dataGridViewData_KEA.Columns[7], System.ComponentModel.ListSortDirection.Ascending);
            }
        }

        private void меньшеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var rowsWithValues = new List<(DataGridViewRow Row, double SizeInGb)>();

            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {
                if (row.Cells[8].Value != null)
                {
                    var value = row.Cells[8].Value.ToString();
                    double sizeInGb;

                    sizeInGb = double.TryParse(value.Replace(" млн.", "").Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out sizeInGb) ? sizeInGb : 0;
                    rowsWithValues.Add((row, sizeInGb));
                }
            }

            var sortedRows = rowsWithValues.OrderByDescending(r => r.SizeInGb).ToList();

            dataGridViewData_KEA.Rows.Clear();

            foreach (var item in sortedRows)
            {
                var row = item.Row;
                dataGridViewData_KEA.Rows.Add(
                    row.Cells[0].Value,
                    row.Cells[1].Value,
                    row.Cells[2].Value,
                    row.Cells[3].Value,
                    row.Cells[4].Value,
                    row.Cells[5].Value,
                    row.Cells[6].Value,
                    row.Cells[7].Value,
                    row.Cells[8].Value,
                    row.Cells[9].Value
                );
            }
        }

        private void большеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Объявляем переменную перед использованием
            var rowsWithValues = new List<(DataGridViewRow Row, double SizeInGb)>();

            foreach (DataGridViewRow row in dataGridViewData_KEA.Rows)
            {
                if (row.Cells[8].Value != null)
                {
                    var value = row.Cells[8].Value.ToString();
                    double sizeInGb;

                    sizeInGb = double.TryParse(value.Replace(" млн.", "").Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out sizeInGb) ? sizeInGb : 0;
                    rowsWithValues.Add((row, sizeInGb));
                }
            }

            // Сортируем по возрастанию
            var sortedRows = rowsWithValues.OrderBy(r => r.SizeInGb).ToList();

            dataGridViewData_KEA.Rows.Clear();

            foreach (var item in sortedRows)
            {
                var row = item.Row;
                dataGridViewData_KEA.Rows.Add(
                    row.Cells[0].Value,
                    row.Cells[1].Value,
                    row.Cells[2].Value,
                    row.Cells[3].Value,
                    row.Cells[4].Value,
                    row.Cells[5].Value,
                    row.Cells[6].Value,
                    row.Cells[7].Value,
                    row.Cells[8].Value,
                    row.Cells[9].Value
                );
            }
        }

        private void buttonGuide_KEA_Click(object sender, EventArgs e)
        {
            FormGuides formGuides = new FormGuides();
            formGuides.TopMost = true;
            formGuides.ShowDialog();
        }

        private void buttonAbout_KEA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.TopMost = true;
            formAbout.ShowDialog();
        }
    }
}
