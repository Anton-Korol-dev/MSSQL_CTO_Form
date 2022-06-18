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
        static string connectionString = "Data Source=ANTON-DESKTOP\\CTO_SERVER;Database=CTO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";
        SqlConnection connection = new SqlConnection(connectionString);
        DataTable table = new DataTable();
        DataTable column_of_Ordering = new DataTable();

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
            var temp_for_button_of_insert_for_Client = 0;
            try
            {
                temp_for_button_of_insert_for_Client = Example_of_command_inserting.ExecuteNonQuery();
                Example_of_Transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Example_of_Transaction.Rollback();
                return;
            }
            update_datagrid();
            MessageBox.Show($"К-сть задіяних рядків: {temp_for_button_of_insert_for_Client}");

        }
        void update_datagrid()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select *From Client", connection);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                SqlDataAdapter adapter1 = new SqlDataAdapter
                    ("Select Ordering.Code_Of_Ordering, List_of_works.work From List_of_works Join Ordering on Ordering.Code_Of_Ordering = List_of_works.Code_of_orderings", connection);
                adapter1.Fill(column_of_Ordering);
                dataGridView2.DataSource = column_of_Ordering;
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

        private void button_for_Exit_from_admin_form_Click(object sender, EventArgs e)
        {
            connection.Close();
            MessageBox.Show("З'єдання закрите. Вихід з вікна адміністратора");
            this.Close();
        }

        private void button_for_updating_for_Client_Click(object sender, EventArgs e)
        {
            SqlCommand command_update = new SqlCommand("Update Client Set Client_Code = '130' Where Client_Code = 40", connection);
            var temp_for_button_of_update_for_Client = command_update.ExecuteNonQuery();
            update_datagrid();
            MessageBox.Show($"К-сть задіяних рядків: {temp_for_button_of_update_for_Client}");
        }

        private void button_for_deleting_Client_Click(object sender, EventArgs e)
        {
            SqlCommand command_delete = new SqlCommand("delete from Client where ClientID_card = 'IDUKR110002886970'", connection);
            var temp_for_button_of_deleting_for_Client = command_delete.ExecuteNonQuery();
            update_datagrid();
            MessageBox.Show($"К-сть задіяних рядків: {temp_for_button_of_deleting_for_Client}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_for_sql_reader_Click(object sender, EventArgs e)
        {
            SqlCommand use_select = new SqlCommand("Select *From Car", connection);
            SqlDataReader reader = use_select.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int i = 0;
                    string text = default;
                    while (reader.FieldCount != i)
                    {
                        text += reader.GetValue(i).ToString() + ' ';
                        i++;
                    }
                    listBox1.Items.Add(text);
                }
            }
            reader.Close();
        }

        private void button_for_max_price_Click(object sender, EventArgs e)
        {
            SqlCommand command_search_avg = new SqlCommand("Select MAX(List_of_works.price) AS Max_price From List_of_works", connection);
            var temp_for_max_price_from_List_of_works = command_search_avg.ExecuteScalar();
            MessageBox.Show($"Максимальна ціна серед робіт:{Convert.ToInt32(temp_for_max_price_from_List_of_works)}");
        }

        private void button_for_get_count_Click(object sender, EventArgs e)
        {
            var cnt = new SqlParameter("@Count", SqlDbType.Int);
            cnt.Direction = ParameterDirection.Output;
            SqlCommand use_proc = new SqlCommand("Number_Of_Works_Performed_By_The_Worker", connection);
            use_proc.CommandType = CommandType.StoredProcedure;
            use_proc.Parameters.Add(new SqlParameter("@Worker_Code", SqlDbType.Int));
            use_proc.Parameters.Add(cnt);
            use_proc.Parameters["@Worker_Code"].Value = 12;
            use_proc.ExecuteNonQuery();
            MessageBox.Show($"Count by Works: {Convert.ToString(use_proc.Parameters["@Count"].Value)}");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
