using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Loginbd
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void userTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void butreg_Click(object sender, EventArgs e)
        {
            string connect = "datasource=localhost;port=3306;username=root;password=;database=tienda";
            string query = "SELECT * FROM empleado where user = '" + userTxtBox.Text + "' AND password = '" + pwTxtBox.Text + "' "; //Es insert no select
            MySqlConnection databaseConnection = new MySqlConnection(connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 10;
            
            
            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Bienvenido, te has registrado :D ");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
