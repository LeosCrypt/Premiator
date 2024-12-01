using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Шаблон
{
    public partial class Form2 : Form
    {
        private readonly int _managerId;
        public readonly string _connectionString;
        private readonly Form1 _form1;

        public Form2(int managerId, string connectionString, Form1 form1)
        {
            InitializeComponent();
            _managerId = managerId; // ID менеджера, которому принадлежат отображаемые данные.
            _connectionString = connectionString;  // Строка подключения к базе данных.
            _form1 = form1; // Ссылка на форму Form1 (для возврата на форму авторизации)
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadClientData(); // Загружаем данные клиентов при загрузке формы
        }

        private void LoadClientData() // Метод для загрузки данных клиентов из базы данных.
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(_connectionString))
                {
                    string sql = "SELECT * FROM клиенты WHERE код_менеджера = ?"; // Запрос с фильтром по managerId
                    OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@код_менеджера", _managerId); // SQL-запрос для выборки клиентов, принадлежащих текущему менеджеру
                    DataTable dt = new DataTable();  // Создаем таблицу данных для хранения результатов запроса.
                    adapter.Fill(dt); 
                    dataGridView1.DataSource = dt; // Устанавливаем источник данных для DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных клиентов: " + ex.Message);
            }
            switch(_managerId)  // Устанавливаем имя менеджера в Label в зависимости от его ID
            {
                case 1:
                    label_name.Text = "Кездекбаев Леонид";
                    break;
                case 2:
                    label_name.Text = "Колегов Данил";
                    break;
                case 3:
                    label_name.Text = "Архипов Захар";
                    break;
                case 4:
                    label_name.Text = "Бамбурова Дарья";
                    break;
                case 5:
                    label_name.Text = "Белкин Тимофей";
                    break;
            }
        }

        private void createR_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "Создать запись"
        {
            Form3 form3 = new Form3(_managerId, _connectionString);
            form3.ShowDialog(); // Показываем форму Form3 в модальном режиме
            LoadClientData(); // Перезагружаем данные после закрытия Form3.
        }

        private void exit_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "Выйти"(подразумевает выход из аккаунта)
        {
            // Показываем форму Form1 и скрываем текущую форму
            _form1.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Close(); // Закрываем форму Form1, когда закрывается Form2.
        }
    }
}