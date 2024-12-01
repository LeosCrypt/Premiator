using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Шаблон
{
    public partial class Form3 : Form
    {
        private readonly int _managerId; // ID менеджера, которому будет приписана новая заявка
        private readonly string _connectionString;  // Строка подключения к базе данных

        public Form3(int managerId, string connectionString)
        {
            InitializeComponent();
            _managerId = managerId;
            _connectionString = connectionString;
        }

        private void save_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "Сохранить"
        {
            // Получение данных из полей ввода
            string имя = textBox_fio.Text;
            string описание = textBox_opisanie.Text;
            string статус = comboBox_status.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(имя) || string.IsNullOrEmpty(описание) || string.IsNullOrEmpty(статус))  // Проверка, заполнены ли все поля
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO клиенты (имя, описание, статус, код_менеджера) VALUES (?, ?, ?, ?)"; // SQL-запрос для добавления нового клиента в таблицу "клиенты"
                    using (OleDbCommand command = new OleDbCommand(sql, connection)) // Создаем команду для выполнения запроса на обновление
                    {
                        // Добавление параметров к запросу
                        command.Parameters.AddWithValue("@имя", textBox_fio.Text);
                        command.Parameters.AddWithValue("@описание", textBox_opisanie.Text);
                        command.Parameters.AddWithValue("@статус", comboBox_status.Text);
                        command.Parameters.AddWithValue("@код_менеджера", _managerId);
                        command.ExecuteNonQuery(); // Выполняем запрос на обновление
                    }
                    int bonusPoints = GetBonusPointsFromComboBox(comboBox_status.SelectedItem.ToString()); // Получаем бонусные баллы

                    string sqlUpdateManager = "UPDATE менеджеры SET балл = балл + ? WHERE Код = ?"; // SQL-запрос для обновления количества баллов у менеджера
                    using (OleDbCommand commandUpdateManager = new OleDbCommand(sqlUpdateManager, connection)) // Создаем команду для выполнения запроса на обновление
                    {
                        // Добавление параметров к запросу
                        commandUpdateManager.Parameters.AddWithValue("@bonusPoints", bonusPoints);
                        commandUpdateManager.Parameters.AddWithValue("@Код", _managerId);
                        commandUpdateManager.ExecuteNonQuery(); // Выполняем запрос на обновление
                    }
                }
                
                MessageBox.Show("Клиент успешно добавлен!"); // Отображение сообщения об успешном добавлении клиента
                this.Close(); //закрытие формы
            }
            catch (Exception ex) // Обработка исключений
            {
                MessageBox.Show("Ошибка при добавлении клиента: " + ex.Message);
            }
        }
        private int GetBonusPointsFromComboBox(string selectedStatus) // Метод для получения количества бонусных баллов в зависимости от выбранного статуса
        {
            selectedStatus = comboBox_status.Text;
            switch (selectedStatus)
            {
                case "Создание карточки клиента": return 1;
                case "Оформление сделки": return 2;
                case "Проведение оплаты": return 3;
                default: return 0;
            }
        }
    }
}