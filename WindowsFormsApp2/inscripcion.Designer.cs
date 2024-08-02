namespace WindowsFormsApp2
{
    partial class inscripcion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbgra = new System.Windows.Forms.ComboBox();
            this.cmbseccion = new System.Windows.Forms.ComboBox();
            this.cmbturno = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbal = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.escuela24DataSet5 = new WindowsFormsApp2.Escuela24DataSet5();
            this.mostrainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrainsTableAdapter = new WindowsFormsApp2.Escuela24DataSet5TableAdapters.mostrainsTableAdapter();
            this.inscripcionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoestudianteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombregrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreturnosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela24DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrainsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alumno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Turno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de Inscripcion";
            // 
            // cmbgra
            // 
            this.cmbgra.FormattingEnabled = true;
            this.cmbgra.Location = new System.Drawing.Point(8, 139);
            this.cmbgra.Margin = new System.Windows.Forms.Padding(4);
            this.cmbgra.Name = "cmbgra";
            this.cmbgra.Size = new System.Drawing.Size(145, 24);
            this.cmbgra.TabIndex = 12;
            // 
            // cmbseccion
            // 
            this.cmbseccion.FormattingEnabled = true;
            this.cmbseccion.Location = new System.Drawing.Point(433, 79);
            this.cmbseccion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbseccion.Name = "cmbseccion";
            this.cmbseccion.Size = new System.Drawing.Size(147, 24);
            this.cmbseccion.TabIndex = 13;
            // 
            // cmbturno
            // 
            this.cmbturno.FormattingEnabled = true;
            this.cmbturno.Location = new System.Drawing.Point(221, 79);
            this.cmbturno.Margin = new System.Windows.Forms.Padding(4);
            this.cmbturno.Name = "cmbturno";
            this.cmbturno.Size = new System.Drawing.Size(132, 24);
            this.cmbturno.TabIndex = 14;
            this.cmbturno.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbturno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbseccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbgra);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(69, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(713, 185);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmbal
            // 
            this.cmbal.FormattingEnabled = true;
            this.cmbal.Location = new System.Drawing.Point(19, 62);
            this.cmbal.Name = "cmbal";
            this.cmbal.Size = new System.Drawing.Size(121, 24);
            this.cmbal.TabIndex = 15;
            this.cmbal.SelectedIndexChanged += new System.EventHandler(this.cmbal_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inscripcionIDDataGridViewTextBoxColumn,
            this.nombrealDataGridViewTextBoxColumn,
            this.codigoestudianteDataGridViewTextBoxColumn,
            this.apellidoalDataGridViewTextBoxColumn,
            this.nombregrDataGridViewTextBoxColumn,
            this.nombreseDataGridViewTextBoxColumn,
            this.nombreturnosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mostrainsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 186);
            this.dataGridView1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(206, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // escuela24DataSet5
            // 
            this.escuela24DataSet5.DataSetName = "Escuela24DataSet5";
            this.escuela24DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostrainsBindingSource
            // 
            this.mostrainsBindingSource.DataMember = "mostrains";
            this.mostrainsBindingSource.DataSource = this.escuela24DataSet5;
            // 
            // mostrainsTableAdapter
            // 
            this.mostrainsTableAdapter.ClearBeforeFill = true;
            // 
            // inscripcionIDDataGridViewTextBoxColumn
            // 
            this.inscripcionIDDataGridViewTextBoxColumn.DataPropertyName = "InscripcionID";
            this.inscripcionIDDataGridViewTextBoxColumn.HeaderText = "InscripcionID";
            this.inscripcionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inscripcionIDDataGridViewTextBoxColumn.Name = "inscripcionIDDataGridViewTextBoxColumn";
            this.inscripcionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.inscripcionIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombrealDataGridViewTextBoxColumn
            // 
            this.nombrealDataGridViewTextBoxColumn.DataPropertyName = "Nombreal";
            this.nombrealDataGridViewTextBoxColumn.HeaderText = "Nombreal";
            this.nombrealDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombrealDataGridViewTextBoxColumn.Name = "nombrealDataGridViewTextBoxColumn";
            this.nombrealDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoestudianteDataGridViewTextBoxColumn
            // 
            this.codigoestudianteDataGridViewTextBoxColumn.DataPropertyName = "codigo_estudiante";
            this.codigoestudianteDataGridViewTextBoxColumn.HeaderText = "codigo_estudiante";
            this.codigoestudianteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoestudianteDataGridViewTextBoxColumn.Name = "codigoestudianteDataGridViewTextBoxColumn";
            this.codigoestudianteDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidoalDataGridViewTextBoxColumn
            // 
            this.apellidoalDataGridViewTextBoxColumn.DataPropertyName = "Apellidoal";
            this.apellidoalDataGridViewTextBoxColumn.HeaderText = "Apellidoal";
            this.apellidoalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoalDataGridViewTextBoxColumn.Name = "apellidoalDataGridViewTextBoxColumn";
            this.apellidoalDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombregrDataGridViewTextBoxColumn
            // 
            this.nombregrDataGridViewTextBoxColumn.DataPropertyName = "Nombregr";
            this.nombregrDataGridViewTextBoxColumn.HeaderText = "Nombregr";
            this.nombregrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombregrDataGridViewTextBoxColumn.Name = "nombregrDataGridViewTextBoxColumn";
            this.nombregrDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreseDataGridViewTextBoxColumn
            // 
            this.nombreseDataGridViewTextBoxColumn.DataPropertyName = "Nombrese";
            this.nombreseDataGridViewTextBoxColumn.HeaderText = "Nombrese";
            this.nombreseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreseDataGridViewTextBoxColumn.Name = "nombreseDataGridViewTextBoxColumn";
            this.nombreseDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreturnosDataGridViewTextBoxColumn
            // 
            this.nombreturnosDataGridViewTextBoxColumn.DataPropertyName = "Nombre_turnos";
            this.nombreturnosDataGridViewTextBoxColumn.HeaderText = "Nombre_turnos";
            this.nombreturnosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreturnosDataGridViewTextBoxColumn.Name = "nombreturnosDataGridViewTextBoxColumn";
            this.nombreturnosDataGridViewTextBoxColumn.Width = 125;
            // 
            // inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "inscripcion";
            this.Load += new System.EventHandler(this.inscripcion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela24DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrainsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbgra;
        private System.Windows.Forms.ComboBox cmbseccion;
        private System.Windows.Forms.ComboBox cmbturno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Escuela24DataSet5 escuela24DataSet5;
        private System.Windows.Forms.BindingSource mostrainsBindingSource;
        private Escuela24DataSet5TableAdapters.mostrainsTableAdapter mostrainsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscripcionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoestudianteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombregrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreturnosDataGridViewTextBoxColumn;
    }
}