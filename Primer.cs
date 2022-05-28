using APIAPI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APITestForm
{
    public partial class Form2 : Form
    {
        List<Employee> EmployeesList = new List<Employee>();
        public Form2()
        {
            InitializeComponent();
        }
        
        public HttpClient httpClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44320/");
            return httpClient;
        }

        private void Download_Click(object sender, EventArgs e)
        {
            HttpResponseMessage httpResponseMessage = httpClient().GetAsync("/api/Employees").Result;
            var model = httpResponseMessage.Content.ReadAsStringAsync().Result;
            EmployeesList = JsonConvert.DeserializeObject<List<Employee>>(model);
            dataGridView1.DataSource = EmployeesList;
            Dictionary<long, string> nameCombo = new Dictionary<long, string>();
            foreach(Employee employee in EmployeesList)
            {
                nameCombo.Add(employee.Id, employee.Name +" "+ employee.FirstName);
            }
            comboBoxName.DataSource = new BindingSource(nameCombo, null);
            comboBoxName.DisplayMember = "Value";
            comboBoxName.ValueMember = "Key";
        }

        private void Postbt_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                Id = Convert.ToInt32(IdText.Text),
                Name = NameText.Text,
                FirstName = FirstNameText.Text,
                MiddleName = MiddleNameText.Text
            };
            HttpContent content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponseMessage = httpClient().PostAsync("/api/Employees", content).GetAwaiter().GetResult();
            Code.Text = httpResponseMessage.StatusCode.ToString();
        }

        private void UpdateBT_Click(object sender, EventArgs e)
        {
            int IdSelect = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Employee employee = new Employee
            {
                //Ебала ебаная
                Id = IdSelect,
                Name = NameText.Text,
                FirstName = FirstNameText.Text,
                MiddleName = MiddleNameText.Text
            };
            HttpContent content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponseMessage = httpClient().PutAsync($"/api/Employees/{IdSelect}", content).GetAwaiter().GetResult();
            Code.Text = httpResponseMessage.StatusCode.ToString();
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            int IdSelect = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            HttpResponseMessage httpResponseMessage = httpClient().DeleteAsync($"/api/Employees/{IdSelect}").Result;
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<Employee> sortEmployee = new List<Employee>();
            //foreach (Employee employee in EmployeesList)
            //{
            //    if (employee.Id == ((KeyValuePair<long, string>)comboBoxName.SelectedItem).Key)
            //    {
            //        sortEmployee.Add(employee);
            //    }
            //}
            //dataGridView1.DataSource = sortEmployee;
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
