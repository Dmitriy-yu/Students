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
    public partial class Form2 : Form
    { 
        private static string connectionString= "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Результаты.accdb";
        private OleDbConnection myConnection;
        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }  
        private void button1_Click(object sender, EventArgs e)
        {          
            string query= "INSERT INTO  Результаты( Имя, Фамилия, Класс, Оценка)" + "Values ('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" +textBox5.Text + "')"; 
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные были добавлены");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
