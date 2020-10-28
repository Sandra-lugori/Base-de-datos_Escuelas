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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sesion()
        {
            string connect = "datasource=localhost;port=3306;username=root;password=;database=tienda";
            string query = "SELECT * FROM empleado where user = '" + userTxtBox.Text + "' AND password = '" + pwTxtBox.Text + "' ";
            MySqlConnection databaseConnection = new MySqlConnection(connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 10;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Que hubo pequeñin!");
                }
                else
                {
                    MessageBox.Show("Try again baby!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void butlog_Click(object sender, EventArgs e)
        {
            Sesion();
        }

        private void butreg_Click(object sender, EventArgs e)
        {
            Form2 registrar = new Form2();
            registrar.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
