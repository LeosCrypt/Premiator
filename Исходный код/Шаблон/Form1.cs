using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace Шаблон
{
    public partial class Form1 : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\BD\AAAAAAAAAAAAAA.accdb;"; // Строка подключения к базе данных Access(путь указывает к самому файлу БД)
        public int idТекущегоМенеджера; // Хранит ID текущего менеджера после успешной авторизации

        public Form1()
        {
            InitializeComponent();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            // Получаем логин и пароль из текстовых полей
            string login = textBox_login.Text;
            string password = textBox_password.Text;

            // Проверка, заполнены ли поля логина и пароля
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            try
            {
                // соединение с базой данных.
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    // Открытие соединение
                    connection.Open();
                    // SQL-запрос для проверки логина и пароля в таблице "менеджеры"
                    string query = "SELECT Код FROM менеджеры WHERE логин = ? AND пароль = ?"; // Запрос для Access
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Добавление параметров в запрос 
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);             
                        object result = command.ExecuteScalar(); // Выполняем запрос и получаем результат (ID менеджера)

                        if (result != null)// Если результат не null, то авторизация успешна.
                        {
                            idТекущегоМенеджера = Convert.ToInt32(result);
                            Form2 form2 = new Form2(idТекущегоМенеджера, connectionString, this); // Передаем connectionString в Form2
                            // Показываем форму Form2 и скрываем текущую форму
                            form2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль.");
                        }
                    }
                }
            }
            catch (OleDbException ex) // Обработка исключений OleDbException (ошибки базы данных)
            {
                MessageBox.Show($"Ошибка авторизации: {ex.Message}");
            }
            catch (Exception ex) // Обработка других исключений.
            {
                MessageBox.Show($"Непредвиденная ошибка: {ex.Message}");
            }
        }
    }
}