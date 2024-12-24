using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.KiselevEA.Sprint7.Project.V9.Lib;

namespace Tyuiu.KiselevEA.Sprint7.Project.V9
{
    public partial class FormGraphx : Form
    {


        public FormGraphx()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            
        }

        DataService ds = new DataService();

        private void buttonBack_KEA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void годВыпускаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogGraphx_KEA = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
            };

            if (openFileDialogGraphx_KEA.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialogGraphx_KEA.FileName;
                var dataTable = ds.ReadCsvToDataTable(filePath);
                dataGridView1.DataSource = dataTable;

                
                chartGraphx_KEA.Series.Clear();

                // Сбор данных для графика
                var titles = dataTable.AsEnumerable()
                    .Select(row => row.Field<string>(1)) // Второй столбец
                    .ToList();

                var values = dataTable.AsEnumerable()
                    .Select(row =>
                    {
                        string valueStr = row.Field<string>(7); // Восьмой столбец
                        return Convert.ToDouble(valueStr.Replace(" млн.", "").Trim());
                    })
                    .ToList();

                
                var colors = new List<System.Drawing.Color>
        {
            System.Drawing.Color.Red,
            System.Drawing.Color.Blue,
            System.Drawing.Color.Green,
            System.Drawing.Color.Yellow,
            System.Drawing.Color.Orange,
            System.Drawing.Color.Purple,
            System.Drawing.Color.Brown,
            System.Drawing.Color.Teal,
            System.Drawing.Color.Pink
        };

                // Настройка графиков
                for (int i = 0; i < titles.Count; i++)
                {
                    var series = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = titles[i],
                        Color = colors[i % colors.Count], 
                        IsValueShownAsLabel = true
                    };
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                    
                    series.Points.AddXY(titles[i], values[i]);
                    chartGraphx_KEA.Series.Add(series);
                }

                // Увеличение расстояний между столбцами
                chartGraphx_KEA.ChartAreas[0].AxisX.Interval = 1; 
                chartGraphx_KEA.ChartAreas[0].AxisX.IsInterlaced = true;
                foreach (var series in chartGraphx_KEA.Series)
                {
                    series["PointWidth"] = "2"; 
                }
                chartGraphx_KEA.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            }
        }

        private void chartGraphx_KEA_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void бюджетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogGraphx_KEA = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
            };

            if (openFileDialogGraphx_KEA.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialogGraphx_KEA.FileName;
                var dataTable = ds.ReadCsvToDataTable(filePath);
                dataGridView1.DataSource = dataTable;

                // Очистка предыдущих графиков
                chartGraphx_KEA.Series.Clear();

                // Сбор данных для графика
                var titles = dataTable.AsEnumerable()
                    .Select(row => row.Field<string>(1)) // Второй столбец
                    .ToList();

                var prices = dataTable.AsEnumerable()
                    .Select(row =>
                    {
                        string priceStr = row.Field<string>(8); // Девятый столбец
                        return Convert.ToDouble(priceStr.Replace(" млн.", "").Trim());
                    })
                    .ToList();

                // Определение массива цветов
                var colors = new List<System.Drawing.Color>
        {
            System.Drawing.Color.Red,
            System.Drawing.Color.Blue,
            System.Drawing.Color.Green,
            System.Drawing.Color.Yellow,
            System.Drawing.Color.Orange,
            System.Drawing.Color.Purple,
            System.Drawing.Color.Brown,
            System.Drawing.Color.Teal,
            System.Drawing.Color.Pink
        };

                // Настройка графиков
                for (int i = 0; i < titles.Count; i++)
                {
                    var series = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = titles[i],
                        Color = colors[i % colors.Count], // Присваиваем цвет по порядку
                        IsValueShownAsLabel = true
                    };
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    series.Points.AddXY(titles[i], prices[i]);
                    chartGraphx_KEA.Series.Add(series);
                }
            }
        }
    }
}
        

