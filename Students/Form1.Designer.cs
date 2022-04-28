
namespace Students
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kлассDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценкаЗаГодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listDataSet = new Students.ListDataSet();
            this.listTableAdapter = new Students.ListDataSetTableAdapters.ListTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.kлассDataGridViewTextBoxColumn,
            this.оценкаЗаГодDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // kлассDataGridViewTextBoxColumn
            // 
            this.kлассDataGridViewTextBoxColumn.DataPropertyName = "Kласс";
            this.kлассDataGridViewTextBoxColumn.HeaderText = "Kласс";
            this.kлассDataGridViewTextBoxColumn.Name = "kлассDataGridViewTextBoxColumn";
            // 
            // оценкаЗаГодDataGridViewTextBoxColumn
            // 
            this.оценкаЗаГодDataGridViewTextBoxColumn.DataPropertyName = "Оценка за год";
            this.оценкаЗаГодDataGridViewTextBoxColumn.HeaderText = "Оценка за год";
            this.оценкаЗаГодDataGridViewTextBoxColumn.Name = "оценкаЗаГодDataGridViewTextBoxColumn";
            // 
            // listBindingSource
            // 
            this.listBindingSource.DataMember = "List";
            this.listBindingSource.DataSource = this.listDataSetBindingSource;
            // 
            // listDataSetBindingSource
            // 
            this.listDataSetBindingSource.DataSource = this.listDataSet;
            this.listDataSetBindingSource.Position = 0;
            // 
            // listDataSet
            // 
            this.listDataSet.DataSetName = "ListDataSet";
            this.listDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listTableAdapter
            // 
            this.listTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер учащегося";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBindingSource1
            // 
            this.listBindingSource1.DataMember = "List";
            this.listBindingSource1.DataSource = this.listDataSetBindingSource;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 60);
            this.button2.TabIndex = 7;
            this.button2.Text = "Добавить учащихся";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 266);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource listDataSetBindingSource;
        private ListDataSet listDataSet;
        private System.Windows.Forms.BindingSource listBindingSource;
        private ListDataSetTableAdapters.ListTableAdapter listTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kлассDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкаЗаГодDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource listBindingSource1;
        private System.Windows.Forms.Button button2;
    }
}

