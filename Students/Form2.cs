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
        private static string connectionString= "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = List.mdb";
        private OleDbConnection myConnection;
        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
    }
}
