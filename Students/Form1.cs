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
    public partial class Form1 : Form
    {
        private static string connectionString ="Provider = Microsoft.Jet.OLEDB.4.0; Data Source = List.mdb";
        private OleDbConnection myConnect;
        public Form1()
        {
            InitializeComponent();
            myConnect = new OleDbConnection(connectionString);
            myConnect.Open();    

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "listDataSet.List". При необходимости она может быть перемещена или удалена.
            this.listTableAdapter.Fill(this.listDataSet.List);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM List Where [Номер]=" + kod;
            OleDbCommand command = new OleDbCommand(query, myConnect);
            command.ExecuteNonQuery();
            this.listTableAdapter.Fill(this.listDataSet.List);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
