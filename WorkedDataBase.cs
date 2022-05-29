using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using APIAPI;

namespace APITestForm
{
    public partial class WorkedDataBase : Form
    {
        List<Employee> EmployeesList = new List<Employee>();
        public static string connection = "Data Source=DESKTOP-T1T7I8T\\SQLEXPRESS;Initial Catalog=Fitnes;Integrated Security=True";
        //public static string connection = "Server=localhost;Database=Fitnes; User iD = MicrosoftAccount\\nikita.strel.2002@mail.ru; Trusted_Connection=True;";

        SqlConnection sqlConnection = new SqlConnection(connection);
        public WorkedDataBase()
        {
            InitializeComponent();
            sqlConnection.Open();
        }

        private  void Download_Click(object sender, EventArgs e)
        {
            RequestTable();
        }

        public void DownloadDatagrid()
        {
            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Employees";
            command.Connection = sqlConnection;
            dataTable.Load(command.ExecuteReader());
            dataGridView1.DataSource = dataTable;
        }

        public void RequestTable()
        {
            try
            {
                //SqlDataAdapter adapter = new SqlDataAdapter();
                //adapter.SelectCommand = command;
                ////Заполнение таблицы
                //adapter.Fill(respons);
                //Объект для хранения ответа
                DataSet data = new DataSet();
                DataTable respons = new DataTable();//Так же можно и DataTable если возвращает одну таблицу
                string sqlCommand = $"SELECT * FROM Employees";
                //Создание команды, Выполнение команды 
                SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                //Передача данных в адаптер
                data.Load(command.ExecuteReader());
                //respons.Load();
                dataGridView1.DataSource = data.Tables[0];
                //Заполнение модели Employee
                EmployeesList = respons.AsEnumerable().Select(m => new Employee()
                {
                    Id = m.Field<long>("Id"),
                    Name = m.Field<string>("Name"),
                    FirstName = m.Field<string>("FirstName"),
                    MiddleName = m.Field<string>("MiddleName")
                }).ToList();
            }
            catch 
            { 
                MessageBox.Show("Проверьте данные");
            }
        }

        private void Postbt_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlCommand = $"INSERT INTO [dbo].[Employees]([ID],[Name],[FirstName],[MiddleName])" +
                    $"VALUES({IdText.Text},'{NameText.Text}','{FirstNameText.Text}','{MiddleNameText.Text}')";
                //Создание команды 
                SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                MessageBox.Show($"Затронуто {command.ExecuteNonQuery()}");
                RequestTable();
            }
            catch
            {
                MessageBox.Show("Проверьте данные");
            }
        }

        private void UpdateBT_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlCommand = $"UPDATE [dbo].[Employees] SET " +
                    $"[Name] = '{NameText.Text}'," +
                    $"[FirstName] = '{FirstNameText.Text}'," +
                    $"[MiddleName] = '{MiddleNameText.Text}' " +
                    $"WHERE ID ={IdText.Text}";
                //Создание команды 
                SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                MessageBox.Show($"Затронуто {command.ExecuteNonQuery()}");
                RequestTable();
            }
            catch
            {
                MessageBox.Show("Проверьте данные");
            }
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlCommand = $"DELETE FROM [dbo].[Employees] WHERE ID ={dataGridView1.CurrentRow.Cells[0].Value}";
                //Создание команды 
                SqlCommand command = new SqlCommand(sqlCommand, sqlConnection);
                MessageBox.Show($"Затронуто {command.ExecuteNonQuery()}");
                RequestTable();
            }
            catch
            {
                MessageBox.Show("Проверьте данные");
            }
        }
        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Employee> sortEmployee = new List<Employee>();
            foreach (Employee employee in EmployeesList)
            {
                if (employee.Id == ((KeyValuePair<long, string>)comboBoxName.SelectedItem).Key)
                {
                    sortEmployee.Add(employee);
                }
            }
            dataGridView1.DataSource = sortEmployee;
        }

        private void SourseText_TextChanged(object sender, EventArgs e)
        {
            List<Employee> sortEmployee = new List<Employee>();
            foreach (Employee employee in EmployeesList)
            {
                int Index = employee.Name.IndexOf(SourseText.Text);
                int IndexFirs = employee.FirstName.IndexOf(SourseText.Text);

                if (Index > -1 || IndexFirs > -1)
                {
                    sortEmployee.Add(employee);
                }
            }
            dataGridView1.DataSource = sortEmployee;
        }
    }
}
