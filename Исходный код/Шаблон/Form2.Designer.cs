namespace Шаблон
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.exit = new System.Windows.Forms.Button();
            this.createR = new System.Windows.Forms.Button();
            this.aAAAAAAAAAAAAADataSet1 = new Шаблон.AAAAAAAAAAAAAADataSet1();
            this.aAAAAAAAAAAAAADataSet = new Шаблон.AAAAAAAAAAAAAADataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодменеджераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new Шаблон.AAAAAAAAAAAAAADataSet1TableAdapters.клиентыTableAdapter();
            this.label_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aAAAAAAAAAAAAADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAAAAAAAAAAAAADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(198)))));
            this.exit.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(887, 45);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(166, 50);
            this.exit.TabIndex = 15;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // createR
            // 
            this.createR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(198)))));
            this.createR.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createR.Location = new System.Drawing.Point(12, 45);
            this.createR.Name = "createR";
            this.createR.Size = new System.Drawing.Size(284, 50);
            this.createR.TabIndex = 14;
            this.createR.Text = "Создать заявку";
            this.createR.UseVisualStyleBackColor = false;
            this.createR.Click += new System.EventHandler(this.createR_Click);
            // 
            // aAAAAAAAAAAAAADataSet1
            // 
            this.aAAAAAAAAAAAAADataSet1.DataSetName = "AAAAAAAAAAAAAADataSet1";
            this.aAAAAAAAAAAAAADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aAAAAAAAAAAAAADataSet
            // 
            this.aAAAAAAAAAAAAADataSet.DataSetName = "AAAAAAAAAAAAAADataSet";
            this.aAAAAAAAAAAAAADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.кодменеджераDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиентыBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(111, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(906, 488);
            this.dataGridView1.TabIndex = 16;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 125;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "описание";
            this.описаниеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.Width = 125;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "статус";
            this.статусDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодменеджераDataGridViewTextBoxColumn
            // 
            this.кодменеджераDataGridViewTextBoxColumn.DataPropertyName = "код_менеджера";
            this.кодменеджераDataGridViewTextBoxColumn.HeaderText = "код_менеджера";
            this.кодменеджераDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодменеджераDataGridViewTextBoxColumn.Name = "кодменеджераDataGridViewTextBoxColumn";
            this.кодменеджераDataGridViewTextBoxColumn.Width = 125;
            // 
            // клиентыBindingSource1
            // 
            this.клиентыBindingSource1.DataMember = "клиенты";
            this.клиентыBindingSource1.DataSource = this.aAAAAAAAAAAAAADataSet1;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "клиенты";
            this.клиентыBindingSource.DataSource = this.aAAAAAAAAAAAAADataSet1;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(399, 59);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(107, 36);
            this.label_name.TabIndex = 17;
            this.label_name.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1106, 644);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.createR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "CRM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aAAAAAAAAAAAAADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAAAAAAAAAAAAADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button createR;
        private AAAAAAAAAAAAAADataSet1 aAAAAAAAAAAAAADataSet1;
        private AAAAAAAAAAAAAADataSet aAAAAAAAAAAAAADataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private AAAAAAAAAAAAAADataSet1TableAdapters.клиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодменеджераDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource клиентыBindingSource1;
        private System.Windows.Forms.Label label_name;
    }
}