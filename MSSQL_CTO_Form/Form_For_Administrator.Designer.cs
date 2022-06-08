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
            this.button1 = new System.Windows.Forms.Button();
            this.button_for_inserting_CTO = new System.Windows.Forms.Button();
            this.button_for_Exit_from_admin_form = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(653, 237);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(184, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update into Client";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_for_inserting_CTO
            // 
            this.button_for_inserting_CTO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_for_inserting_CTO.Location = new System.Drawing.Point(12, 260);
            this.button_for_inserting_CTO.Name = "button_for_inserting_CTO";
            this.button_for_inserting_CTO.Size = new System.Drawing.Size(137, 41);
            this.button_for_inserting_CTO.TabIndex = 3;
            this.button_for_inserting_CTO.Text = "Insert into CTO";
            this.button_for_inserting_CTO.UseVisualStyleBackColor = true;
            this.button_for_inserting_CTO.Click += new System.EventHandler(this.button_for_inserting_for_CTO_Click);
            // 
            // button_for_Exit_from_admin_form
            // 
            this.button_for_Exit_from_admin_form.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_for_Exit_from_admin_form.Location = new System.Drawing.Point(527, 635);
            this.button_for_Exit_from_admin_form.Name = "button_for_Exit_from_admin_form";
            this.button_for_Exit_from_admin_form.Size = new System.Drawing.Size(153, 33);
            this.button_for_Exit_from_admin_form.TabIndex = 4;
            this.button_for_Exit_from_admin_form.Text = "Вихід із програми";
            this.button_for_Exit_from_admin_form.UseVisualStyleBackColor = true;
            this.button_for_Exit_from_admin_form.Click += new System.EventHandler(this.button_for_Exit_from_admin_form_Click);
            // 
            // Form_For_Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1242, 701);
            this.Controls.Add(this.button_for_Exit_from_admin_form);
            this.Controls.Add(this.button_for_inserting_CTO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_for_inserting_Client);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_For_Administrator";
            this.Text = "Form_For_Administrator";
            this.Load += new System.EventHandler(this.Form_For_Administrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_for_inserting_Client;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_for_inserting_CTO;
        private System.Windows.Forms.Button button_for_Exit_from_admin_form;
    }
}