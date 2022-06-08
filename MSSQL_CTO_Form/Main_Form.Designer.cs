namespace MSSQL_CTO_Form
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Administrator = new System.Windows.Forms.Button();
            this.button_for_Exit_from_programm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Administrator
            // 
            this.Administrator.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Administrator.Location = new System.Drawing.Point(340, 45);
            this.Administrator.Name = "Administrator";
            this.Administrator.Size = new System.Drawing.Size(140, 51);
            this.Administrator.TabIndex = 0;
            this.Administrator.Text = "Адміністратор";
            this.Administrator.UseVisualStyleBackColor = true;
            this.Administrator.Click += new System.EventHandler(this.button_for_administrator_Click);
            // 
            // button_for_Exit_from_programm
            // 
            this.button_for_Exit_from_programm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_for_Exit_from_programm.Location = new System.Drawing.Point(327, 390);
            this.button_for_Exit_from_programm.Name = "button_for_Exit_from_programm";
            this.button_for_Exit_from_programm.Size = new System.Drawing.Size(153, 33);
            this.button_for_Exit_from_programm.TabIndex = 1;
            this.button_for_Exit_from_programm.Text = "Вихід із програми";
            this.button_for_Exit_from_programm.UseVisualStyleBackColor = true;
            this.button_for_Exit_from_programm.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_for_Exit_from_programm);
            this.Controls.Add(this.Administrator);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.Text = "Company_CTO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Administrator;
        private System.Windows.Forms.Button button_for_Exit_from_programm;
    }
}

