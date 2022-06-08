using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSQL_CTO_Form
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_for_administrator_Click(object sender, EventArgs e)
        {
            Form_For_Administrator newForm = new Form_For_Administrator();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вихід із програми");
            this.Close();
        }
    }
}
