using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class Form3 : Form
    {
        private static string connectionString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Результаты.accdb";
        private OleDbConnection myConnect;
        public Form3()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            myConnect = new OleDbConnection(connectionString);
            myConnect.Open();
            string find = textBox1.Text;
            string query = "SELECT Имя, Фамилия, Класс, Оценка FROM Результаты WHERE Фамилия LIKE '%" + find + "%'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnect);
            DataTable table = new DataTable();
            command.Fill(table);
            dataGridView1.DataSource =table;
            myConnect.Close();
        }
    }
}
