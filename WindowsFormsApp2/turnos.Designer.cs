namespace WindowsFormsApp2
{
    partial class turnos
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
            this.escuela24DataSet3 = new WindowsFormsApp2.Escuela24DataSet3();
            this.turnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turnosTableAdapter = new WindowsFormsApp2.Escuela24DataSet3TableAdapters.TurnosTableAdapter();
            this.turnoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreturnosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela24DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turnoIDDataGridViewTextBoxColumn,
            this.nombreturnosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.turnosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(253, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(447, 156);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ingresar turnos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // escuela24DataSet3
            // 
            this.escuela24DataSet3.DataSetName = "Escuela24DataSet3";
            this.escuela24DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turnosBindingSource
            // 
            this.turnosBindingSource.DataMember = "Turnos";
            this.turnosBindingSource.DataSource = this.escuela24DataSet3;
            // 
            // turnosTableAdapter
            // 
            this.turnosTableAdapter.ClearBeforeFill = true;
            // 
            // turnoIDDataGridViewTextBoxColumn
            // 
            this.turnoIDDataGridViewTextBoxColumn.DataPropertyName = "TurnoID";
            this.turnoIDDataGridViewTextBoxColumn.HeaderText = "TurnoID";
            this.turnoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turnoIDDataGridViewTextBoxColumn.Name = "turnoIDDataGridViewTextBoxColumn";
            this.turnoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.turnoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreturnosDataGridViewTextBoxColumn
            // 
            this.nombreturnosDataGridViewTextBoxColumn.DataPropertyName = "Nombre_turnos";
            this.nombreturnosDataGridViewTextBoxColumn.HeaderText = "Nombre_turnos";
            this.nombreturnosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreturnosDataGridViewTextBoxColumn.Name = "nombreturnosDataGridViewTextBoxColumn";
            this.nombreturnosDataGridViewTextBoxColumn.Width = 125;
            // 
            // turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "turnos";
            this.Text = "turnos";
            this.Load += new System.EventHandler(this.turnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela24DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Escuela24DataSet3 escuela24DataSet3;
        private System.Windows.Forms.BindingSource turnosBindingSource;
        private Escuela24DataSet3TableAdapters.TurnosTableAdapter turnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreturnosDataGridViewTextBoxColumn;
    }
}