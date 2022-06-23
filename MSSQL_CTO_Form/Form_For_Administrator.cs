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
//using System.Data.SqlClient;
namespace MSSQL_CTO_Form
{
    public partial class Form_For_Administrator : Form
    {
        static string connectionString = "Data Source=ANTON-DESKTOP\\CTO_SERVER;Database=CTO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";
        SqlConnection connection = new SqlConnection(connectionString);
        //DataTable table = new DataTable();
        //DataTable column_of_Ordering = new DataTable();
        DataRelation rd1;
        DataSet ds = new DataSet();

        DataRelation rd2;
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        SqlDataAdapter adapter1;
        SqlDataAdapter adapter2;
        //SqlCommandBuilder commandBuilder1;

        public Form_For_Administrator()
        {
            InitializeComponent();

            //dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select *From Client", connection);
            adapter.Fill(ds, "Client");
            dataGridView1.DataSource = ds.Tables["Client"];
            adapter.Dispose();
            adapter = new SqlDataAdapter("Select *From Ordering", connection);
            adapter.Fill(ds, "Ordering");
            ds.Tables["Client"].Constraints.Add("Client_Code", ds.Tables["Client"].Columns[6], true);
            DataColumn parent = ds.Tables["Client"].Columns["Client_Code"];
            DataColumn child = ds.Tables["Ordering"].Columns["Client_Code"];
            rd1 = new DataRelation("By_Client_Code", parent, child);
            ds.Relations.Add(rd1);
            //////////////////////////////////////////////////////////////////
            SqlDataAdapter adapter2 = new SqlDataAdapter("Select *From Ordering", connection);
            adapter2.Fill(ds1, "Ordering");
            dataGridView2.DataSource = ds1.Tables["Ordering"];
            adapter2.Dispose();
            adapter2 = new SqlDataAdapter("Select *From List_of_works", connection);
            adapter2.Fill(ds1, "List_of_works");
            ds1.Tables["Ordering"].Constraints.Add("Code_Of_Ordering", ds1.Tables["Ordering"].Columns[2], true);
            DataColumn parent1 = ds1.Tables["Ordering"].Columns["Code_Of_Ordering"];
            DataColumn child1 = ds1.Tables["List_of_works"].Columns["Code_of_orderings"];
            rd2 = new DataRelation("By_Code_of_ordering", parent1, child1);
            ds1.Relations.Add(rd2);

            //update_datagrid();
            MessageBox.Show("З'єднання відкрите");

           

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter2 = new SqlDataAdapter("select * from List_of_works", connection);
                ds2 = new DataSet();
                adapter2.Fill(ds2);
                //dataGridView3.DataSource = ds2.Tables[0];
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
                adapter.Fill(ds, "Client");
                dataGridView1.DataSource = ds.Tables["Client"];
                adapter.Dispose();
                adapter = new SqlDataAdapter("Select *From Ordering", connection);
                adapter.Fill(ds, "Ordering");
               // dataGridView2.DataSource = column_of_Ordering;
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
            //DataView dv = new DataView(ds.Tables["Client"]);
            //DataRowView line = dv[dataGridView1.CurrentRow.Index];
            //dataGridView2.DataSource = line.CreateChildView(rd1);
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter2 = new SqlDataAdapter("Select *From List_of_works", connection);
                ds2 = new DataSet();
                adapter2.Fill(ds2);
                dataGridView3.DataSource = ds2.Tables[0];
            }
            SqlCommand use_select = new SqlCommand("Select *From List_of_works", connection);
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

        private void button1_Click(object sender, EventArgs e)
        {
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    adapter1 = new SqlDataAdapter("select * from Ordering", connection);
            //    //ds = new DataSet();
            //    //adapter1.Fill(ds);
            //    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter1);
            //    adapter1.InsertCommand = new SqlCommand("addOrdering", connection);
            //    adapter1.InsertCommand.CommandType = CommandType.StoredProcedure;
            //    adapter1.InsertCommand.Parameters.Add(new SqlParameter("@Client_Code", SqlDbType.Int, 0, "Client_Code"));
            //    adapter1.InsertCommand.Parameters.Add(new SqlParameter("@Manager", SqlDbType.Int, 0, "Manager"));
            //    adapter1.InsertCommand.Parameters.Add(new SqlParameter("@Code_of_ordering", SqlDbType.Int, 0, "Code_Of_Ordering"));
            //    adapter1.InsertCommand.Parameters.Add(new SqlParameter("@VIN_number", SqlDbType.Int, 0, "VIN_numbers"));

            //    adapter1.Update(ds1);
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataView dv = new DataView(ds.Tables["Client"]);
            DataRowView line = dv[dataGridView1.CurrentRow.Index];
            dataGridView2.DataSource = line.CreateChildView(rd1);
            //dataGridView3.Rows.Clear();
            //dataGridView2.CurrentRow
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataView dv1 = new DataView(ds1.Tables["Ordering"]);
                DataRowView line1 = dv1[dataGridView2.CurrentRow.Index];
                dataGridView3.DataSource = line1.CreateChildView(rd2);
            }
            catch
            {
                MessageBox.Show($"Виникла помилка");
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter2 = new SqlDataAdapter("select * from List_of_works", connection);
                //ds = new DataSet();
                //adapter1.Fill(ds);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter2);
                adapter2.InsertCommand = new SqlCommand("addList_of_works", connection);
                adapter2.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter2.InsertCommand.Parameters.Add(new SqlParameter("@Code", SqlDbType.Int, 0, "Code"));
                adapter2.InsertCommand.Parameters.Add(new SqlParameter("@work", SqlDbType.Int, 0, "work"));
                adapter2.InsertCommand.Parameters.Add(new SqlParameter("@duration_of_work", SqlDbType.Int, 0, "duration_of_work"));
                adapter2.InsertCommand.Parameters.Add(new SqlParameter("@Code_of_orderings", SqlDbType.Int, 0, "Code_of_orderings"));
                adapter2.InsertCommand.Parameters.Add(new SqlParameter("@price", SqlDbType.Int, 0, "price"));
                adapter2.InsertCommand.Parameters.Add(new SqlParameter("@worker_Code", SqlDbType.Int, 0, "worker_Code"));

                adapter2.Update(ds2);
            }
        }
    }
}
