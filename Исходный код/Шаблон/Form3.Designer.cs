namespace Шаблон
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.textBox_opisanie = new System.Windows.Forms.TextBox();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(149, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 36);
            this.label6.TabIndex = 25;
            this.label6.Text = "Статус заявки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(152, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 36);
            this.label5.TabIndex = 24;
            this.label5.Text = "Содержание заявки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(158, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 36);
            this.label4.TabIndex = 23;
            this.label4.Text = "ФИО клиента";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(198)))));
            this.save.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.ForeColor = System.Drawing.Color.Black;
            this.save.Location = new System.Drawing.Point(764, 59);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(222, 46);
            this.save.TabIndex = 22;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // textBox_opisanie
            // 
            this.textBox_opisanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_opisanie.Location = new System.Drawing.Point(155, 261);
            this.textBox_opisanie.Multiline = true;
            this.textBox_opisanie.Name = "textBox_opisanie";
            this.textBox_opisanie.Size = new System.Drawing.Size(620, 162);
            this.textBox_opisanie.TabIndex = 21;
            // 
            // textBox_fio
            // 
            this.textBox_fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_fio.Location = new System.Drawing.Point(155, 161);
            this.textBox_fio.Name = "textBox_fio";
            this.textBox_fio.Size = new System.Drawing.Size(550, 41);
            this.textBox_fio.TabIndex = 20;
            // 
            // comboBox_status
            // 
            this.comboBox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "Создание карточки клиента",
            "Оформление сделки",
            "Проведение оплаты"});
            this.comboBox_status.Location = new System.Drawing.Point(155, 480);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(361, 44);
            this.comboBox_status.TabIndex = 19;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1022, 630);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBox_opisanie);
            this.Controls.Add(this.textBox_fio);
            this.Controls.Add(this.comboBox_status);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "CRM";
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox textBox_opisanie;
        private System.Windows.Forms.TextBox textBox_fio;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
    }
}