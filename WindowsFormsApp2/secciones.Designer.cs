namespace WindowsFormsApp2
{
    partial class secciones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.escuela24DataSet4 = new WindowsFormsApp2.Escuela24DataSet4();
            this.seccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seccionesTableAdapter = new WindowsFormsApp2.Escuela24DataSet4TableAdapters.SeccionesTableAdapter();
            this.seccionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela24DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seccionIDDataGridViewTextBoxColumn,
            this.nombreseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seccionesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(279, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(447, 156);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ingresar secciones";
            // 
            // escuela24DataSet4
            // 
            this.escuela24DataSet4.DataSetName = "Escuela24DataSet4";
            this.escuela24DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seccionesBindingSource
            // 
            this.seccionesBindingSource.DataMember = "Secciones";
            this.seccionesBindingSource.DataSource = this.escuela24DataSet4;
            // 
            // seccionesTableAdapter
            // 
            this.seccionesTableAdapter.ClearBeforeFill = true;
            // 
            // seccionIDDataGridViewTextBoxColumn
            // 
            this.seccionIDDataGridViewTextBoxColumn.DataPropertyName = "SeccionID";
            this.seccionIDDataGridViewTextBoxColumn.HeaderText = "SeccionID";
            this.seccionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seccionIDDataGridViewTextBoxColumn.Name = "seccionIDDataGridViewTextBoxColumn";
            this.seccionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.seccionIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreseDataGridViewTextBoxColumn
            // 
            this.nombreseDataGridViewTextBoxColumn.DataPropertyName = "Nombrese";
            this.nombreseDataGridViewTextBoxColumn.HeaderText = "Nombrese";
            this.nombreseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreseDataGridViewTextBoxColumn.Name = "nombreseDataGridViewTextBoxColumn";
            this.nombreseDataGridViewTextBoxColumn.Width = 125;
            // 
            // secciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "secciones";
            this.Text = "secciones";
            this.Load += new System.EventHandler(this.secciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela24DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Escuela24DataSet4 escuela24DataSet4;
        private System.Windows.Forms.BindingSource seccionesBindingSource;
        private Escuela24DataSet4TableAdapters.SeccionesTableAdapter seccionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreseDataGridViewTextBoxColumn;
    }
}