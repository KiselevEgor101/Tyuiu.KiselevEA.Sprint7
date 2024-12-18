using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KiselevEA.Sprint7.Project.V9
{
    public partial class FormGuides : Form
    {
        public FormGuides()
        {
            InitializeComponent();
        }

        private void buttonGuidesClose_KEA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMenu_KEA_Click(object sender, EventArgs e)
        {
            string menuText = "Главное меню:\n\n" +
                      "Кнопка \"Руководство\" - открывает краткое руководство для пользователя с пояснением всех функций\n" +
                      "Кнопка \"О программе\" - открывает окно с информацией о программе и разработчике\n" +
                      "Кнопка \"Запустить программу\" - открывает главный интерфейс программы\n" +
                      "Кнопка \"Выход\" - закрывает окно главного меню.";

            textBoxGuidesMenu_KEA.Text = menuText;
        }

        private void textBoxGuidesMenu_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GenText = "Приложение:\n\n" +
                      "Кнопка \"Открыть файл\" - открывает меню с выбором файла для открытия в программе\n" +
                      "Кнопка \"Сохранить файл\" - открывает меню с выбором пути для сохранения файла\n" +
                      "Кнопка \"Очистить\" - очищает таблицу\n" +
                      "Кнопка \"Фильтр\" - открывает меню с выбором категории фильтрации\n" +
                      "Кнопка \"Добавить\" - добавляет в таблицу новые значения из заполненных строк\n" +
                      "Кнопка \"Назад в меню\" - Возвращает в главное меню.";

            textBoxGuidesMenu_KEA.Text = GenText;
        }
    }
}
