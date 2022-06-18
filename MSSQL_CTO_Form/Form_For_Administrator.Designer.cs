namespace MSSQL_CTO_Form
{
    partial class Form_For_Administrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_For_Administrator));
            this.button_for_inserting_Client = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_for_updating_Client = new System.Windows.Forms.Button();
            this.button_for_Exit_from_admin_form = new System.Windows.Forms.Button();
            this.button_for_deleting_Client = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_for_sql_reader = new System.Windows.Forms.Button();
            this.button_for_max_price = new System.Windows.Forms.Button();
            this.button_for_get_count = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_for_inserting_Client
            // 
            this.button_for_inserting_Client.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_for_inserting_Client.Location = new System.Drawing.Point(12, 55);
            this.button_for_inserting_Client.Name = "button_for_inserting_Client";
            this.button_for_inserting_Client.Size = new System.Drawing.Size(137, 41);
            this.button_for_inserting_Client.TabIndex = 0;
            this.button_for_inserting_Client.Text = "Insert into Client";
            this.button_for_inserting_Client.UseVisualStyleBackColor = true;
            this.button_for_inserting_Client.Click += new System.EventHandler(this.button_for_inserting_for_Client_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(590, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 287);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_for_updating_Client
            // 
            this.button_for_updating_Client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_for_updating_Client.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_for_updating_Client.Location = new System.Drawing.Point(179, 55);
            this.button_for_updating_Client.Name = "button_for_updating_Client";
            this.button_for_updating_Client.Size = new System.Drawing.Size(137, 41);
            this.button_for_updating_Client.TabIndex = 2;
            this.button_for_updating_Client.Text = "Update in Client";
            this.button_for_updating_Client.UseVisualStyleBackColor = true;
            this.button_for_updating_Client.Click += new System.EventHandler(this.button_for_updating_for_Client_Click);
            // 
            // button_for_Exit_from_admin_form
            // 
            this.button_for_Exit_from_admin_form.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_for_Exit_from_admin_form.Location = new System.Drawing.Point(179, 674);
            this.button_for_Exit_from_admin_form.Name = "button_for_Exit_from_admin_form";
            this.button_for_Exit_from_admin_form.Size = new System.Drawing.Size(153, 33);
            this.button_for_Exit_from_admin_form.TabIndex = 4;
            this.button_for_Exit_from_admin_form.Text = "Вихід із програми";
            this.button_for_Exit_from_admin_form.UseVisualStyleBackColor = true;
            this.button_for_Exit_from_admin_form.Click += new System.EventHandler(this.button_for_Exit_from_admin_form_Click);
            // 
            // button_for_deleting_Client
            // 
            this.button_for_deleting_Client.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_for_deleting_Client.Location = new System.Drawing.Point(348, 55);
            this.button_for_deleting_Client.Name = "button_for_deleting_Client";
            this.button_for_deleting_Client.Size = new System.Drawing.Size(137, 41);
            this.button_for_deleting_Client.TabIndex = 5;
            this.button_for_deleting_Client.Text = "Delete in Client";
            this.button_for_deleting_Client.UseVisualStyleBackColor = true;
            this.button_for_deleting_Client.Click += new System.EventHandler(this.button_for_deleting_Client_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "SqlReader"});
            this.listBox1.Location = new System.Drawing.Point(12, 436);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(473, 160);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_for_sql_reader
            // 
            this.button_for_sql_reader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_for_sql_reader.Location = new System.Drawing.Point(179, 171);
            this.button_for_sql_reader.Name = "button_for_sql_reader";
            this.button_for_sql_reader.Size = new System.Drawing.Size(137, 41);
            this.button_for_sql_reader.TabIndex = 8;
            this.button_for_sql_reader.Text = "SQL_Reader";
            this.button_for_sql_reader.UseVisualStyleBackColor = true;
            this.button_for_sql_reader.Click += new System.EventHandler(this.button_for_sql_reader_Click);
            // 
            // button_for_max_price
            // 
            this.button_for_max_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_for_max_price.Location = new System.Drawing.Point(348, 156);
            this.button_for_max_price.Name = "button_for_max_price";
            this.button_for_max_price.Size = new System.Drawing.Size(137, 71);
            this.button_for_max_price.TabIndex = 9;
            this.button_for_max_price.Text = "The max price among all List_of_works";
            this.button_for_max_price.UseVisualStyleBackColor = true;
            this.button_for_max_price.Click += new System.EventHandler(this.button_for_max_price_Click);
            // 
            // button_for_get_count
            // 
            this.button_for_get_count.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_for_get_count.Location = new System.Drawing.Point(12, 171);
            this.button_for_get_count.Name = "button_for_get_count";
            this.button_for_get_count.Size = new System.Drawing.Size(137, 41);
            this.button_for_get_count.TabIndex = 10;
            this.button_for_get_count.Text = "Get_count";
            this.button_for_get_count.UseVisualStyleBackColor = true;
            this.button_for_get_count.Click += new System.EventHandler(this.button_for_get_count_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(590, 467);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(711, 287);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Form_For_Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1306, 806);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button_for_get_count);
            this.Controls.Add(this.button_for_max_price);
            this.Controls.Add(this.button_for_sql_reader);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_for_deleting_Client);
            this.Controls.Add(this.button_for_Exit_from_admin_form);
            this.Controls.Add(this.button_for_updating_Client);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_for_inserting_Client);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_For_Administrator";
            this.Text = "Form_For_Administrator";
            this.Load += new System.EventHandler(this.Form_For_Administrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_for_inserting_Client;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_for_updating_Client;
        private System.Windows.Forms.Button button_for_Exit_from_admin_form;
        private System.Windows.Forms.Button button_for_deleting_Client;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_for_sql_reader;
        private System.Windows.Forms.Button button_for_max_price;
        private System.Windows.Forms.Button button_for_get_count;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}