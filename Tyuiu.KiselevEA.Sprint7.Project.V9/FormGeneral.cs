using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private int counter = 5;
        private int currentRowIndex = 4;

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
            Regex regex = new Regex(@"(?i)комедия"); // Регистронезависимый поиск "комедия"

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
            Regex regex = new Regex(@"(?i)драма"); // Регистронезависимый поиск "комедия"

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
            Regex regex = new Regex(@"(?i)фантастика"); // Регистронезависимый поиск "комедия"

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
            Regex regex = new Regex(@"(?i)мультфильм"); // 

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
            Regex regex = new Regex(@"(?i)полнометражный фильм"); // Регистронезависимый поиск "мультфильм"

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

            // Проверяем, есть ли достаточно строк
            if (currentRowIndex < dataGridViewData_KEA.Rows.Count)
            {
                dataGridViewData_KEA.Rows[currentRowIndex].Cells[0].Value = counter + 0; // Начинаем с 5
                counter++;
                currentRowIndex++;
            }
            else
            {
                MessageBox.Show("Все строки заполнены или их нет.");
                // Добавляем новую строку, если их недостаточно
                dataGridViewData_KEA.Rows.Add();
                // Сбрасываем индекс на 4, чтобы продолжить с 5-й строки
                currentRowIndex = 4;
            }


        }

        private void textBoxName_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTime_KEA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
