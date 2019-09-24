using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ADO.Net
{
    public partial class Form1 : Form
    {
        private string connectionString;
        private MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            connectionString = @"host=localhost; user=root; database=employees";
            connection = new MySqlConnection(connectionString);
            ConnectToDB();
        }

        private void ConnectToDB()
        {
            try
            {
                connection.Open();
                MessageBox.Show("Connection established.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
