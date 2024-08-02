namespace WindowsFormsApp2
{
    partial class grado
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.escuela24DataSet2 = new WindowsFormsApp2.Escuela24DataSet2();
            this.gradosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradosTableAdapter = new WindowsFormsApp2.Escuela24DataSet2TableAdapters.GradosTableAdapter();
            this.gradoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombregrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela24DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingresar grado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gradoIDDataGridViewTextBoxColumn,
            this.nombregrDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gradosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(341, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(447, 156);
            this.dataGridView1.TabIndex = 3;
            // 
            // escuela24DataSet2
            // 
            this.escuela24DataSet2.DataSetName = "Escuela24DataSet2";
            this.escuela24DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradosBindingSource
            // 
            this.gradosBindingSource.DataMember = "Grados";
            this.gradosBindingSource.DataSource = this.escuela24DataSet2;
            // 
            // gradosTableAdapter
            // 
            this.gradosTableAdapter.ClearBeforeFill = true;
            // 
            // gradoIDDataGridViewTextBoxColumn
            // 
            this.gradoIDDataGridViewTextBoxColumn.DataPropertyName = "GradoID";
            this.gradoIDDataGridViewTextBoxColumn.HeaderText = "GradoID";
            this.gradoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradoIDDataGridViewTextBoxColumn.Name = "gradoIDDataGridViewTextBoxColumn";
            this.gradoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombregrDataGridViewTextBoxColumn
            // 
            this.nombregrDataGridViewTextBoxColumn.DataPropertyName = "Nombregr";
            this.nombregrDataGridViewTextBoxColumn.HeaderText = "Nombregr";
            this.nombregrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombregrDataGridViewTextBoxColumn.Name = "nombregrDataGridViewTextBoxColumn";
            this.nombregrDataGridViewTextBoxColumn.Width = 125;
            // 
            // grado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "grado";
            this.Text = "grado";
            this.Load += new System.EventHandler(this.grado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela24DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Escuela24DataSet2 escuela24DataSet2;
        private System.Windows.Forms.BindingSource gradosBindingSource;
        private Escuela24DataSet2TableAdapters.GradosTableAdapter gradosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombregrDataGridViewTextBoxColumn;
    }
}