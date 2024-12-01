namespace Шаблон
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.logIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aAAAAAAAAAAAAADataSet1 = new Шаблон.AAAAAAAAAAAAAADataSet1();
            this.менеджерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.менеджерыTableAdapter1 = new Шаблон.AAAAAAAAAAAAAADataSet1TableAdapters.менеджерыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAAAAAAAAAAAAADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(299, 181);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(420, 56);
            this.textBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(299, 340);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(420, 56);
            this.textBox_password.TabIndex = 1;
            // 
            // logIn
            // 
            this.logIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(198)))));
            this.logIn.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logIn.Location = new System.Drawing.Point(299, 450);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(420, 82);
            this.logIn.TabIndex = 2;
            this.logIn.Text = "Войти";
            this.logIn.UseVisualStyleBackColor = false;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(301, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(410, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Авторизация";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.aAAAAAAAAAAAAADataSet1;
            this.bindingSource1.Position = 0;
            // 
            // aAAAAAAAAAAAAADataSet1
            // 
            this.aAAAAAAAAAAAAADataSet1.DataSetName = "AAAAAAAAAAAAAADataSet1";
            this.aAAAAAAAAAAAAADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // менеджерыBindingSource
            // 
            this.менеджерыBindingSource.DataMember = "менеджеры";
            this.менеджерыBindingSource.DataSource = this.bindingSource1;
            // 
            // менеджерыTableAdapter1
            // 
            this.менеджерыTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1044, 617);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CRM";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAAAAAAAAAAAAADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AAAAAAAAAAAAAADataSet1 aAAAAAAAAAAAAADataSet1;
        private AAAAAAAAAAAAAADataSet1TableAdapters.менеджерыTableAdapter менеджерыTableAdapter;
        private System.Windows.Forms.BindingSource менеджерыBindingSource;
        private AAAAAAAAAAAAAADataSet1TableAdapters.менеджерыTableAdapter менеджерыTableAdapter1;
    }
}

