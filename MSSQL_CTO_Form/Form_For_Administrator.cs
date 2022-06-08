using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System;
using System.Threading.Tasks;

namespace MSSQL_CTO_Form
{
    public partial class Form_For_Administrator : Form
    {
        static string connectionString = "Data Source=ANTON-DESKTOP\\CTO_SERVER;Initial Catalog=CTO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = new SqlConnection(connectionString);
        DataTable table = new DataTable();
        public Form_For_Administrator()
        {
            InitializeComponent();

            try
            {
                connection.Open();
                update_datagrid();
                MessageBox.Show("З'єднання відкрите");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_for_inserting_for_Client_Click(object sender, EventArgs e)
        {
            SqlTransaction Example_of_Transaction = connection.BeginTransaction();
            //('Mykyta','Dmytrovych', 'Ostapec', 0992295845, 'IDUKR110002245879', 'Mykola Zakrevskoho Street, 95V, Kyiv', 60)
            SqlCommand Example_of_command_inserting = new SqlCommand("Insert into Client (FirstName, MiddleName, LastName, PhoneNumber, ClientID_card, Client_Adress, Client_Code) values('Tom', 'Dmytrovych', 'Pronenko', 0995345298, 'IDUKR110002886970', 'Mykola Zakrevskoho Street, 95V, Kyiv', 40)", connection);
            Example_of_command_inserting.Transaction = Example_of_Transaction;
            var temp = 0;
            try
            {
                temp = Example_of_command_inserting.ExecuteNonQuery();
                Example_of_Transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Example_of_Transaction.Rollback();
                return;
            }
            update_datagrid();
            MessageBox.Show($"К-сть задіяних рядків: {temp}");

        }
        void update_datagrid()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select *From Client", connection);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void Form_For_Administrator_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_for_inserting_for_CTO_Click(object sender, EventArgs e)
        {
            SqlTransaction Example_of_Transaction = connection.BeginTransaction();
            SqlCommand Example_of_command_inserting = new SqlCommand("Insert into CTO (CTO_ID, Name_of_CTO, Amount_of_workers) values(10, 'CTO_King_10', 10)", connection);
            Example_of_command_inserting.Transaction = Example_of_Transaction;
            var temp = 0;
            try
            {
                temp = Example_of_command_inserting.ExecuteNonQuery();
                Example_of_Transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Example_of_Transaction.Rollback();
                return;
            }
            update_datagrid();
            MessageBox.Show($"К-сть задіяних рядків: {temp}");
        }

        private void button_for_Exit_from_admin_form_Click(object sender, EventArgs e)
        {
            connection.Close();
            MessageBox.Show("З'єдання закрите. Вихід з вікна адміністратора");
            this.Close();
        }
    }
}
