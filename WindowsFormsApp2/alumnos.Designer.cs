namespace WindowsFormsApp2
{
    partial class alumnos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.codestext = new System.Windows.Forms.TextBox();
            this.apellido2text = new System.Windows.Forms.TextBox();
            this.apellido1text = new System.Windows.Forms.TextBox();
            this.nombre2text = new System.Windows.Forms.TextBox();
            this.nombre1text = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechasa = new System.Windows.Forms.DateTimePicker();
            this.fechaing = new System.Windows.Forms.DateTimePicker();
            this.fechanaci = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alumnoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoestudianteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreal2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoal2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngresoalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalidaalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escuela24DataSet = new WindowsFormsApp2.Escuela24DataSet();
            this.alumnosTableAdapter = new WindowsFormsApp2.Escuela24DataSetTableAdapters.AlumnosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela24DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer Apellido";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Segundo Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Nacimiento ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de Ingreso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de Salida";
            // 
            // codestext
            // 
            this.codestext.Location = new System.Drawing.Point(6, 447);
            this.codestext.Name = "codestext";
            this.codestext.Size = new System.Drawing.Size(100, 20);
            this.codestext.TabIndex = 7;
            // 
            // apellido2text
            // 
            this.apellido2text.Location = new System.Drawing.Point(7, 203);
            this.apellido2text.Name = "apellido2text";
            this.apellido2text.Size = new System.Drawing.Size(87, 20);
            this.apellido2text.TabIndex = 11;
            // 
            // apellido1text
            // 
            this.apellido1text.Location = new System.Drawing.Point(7, 155);
            this.apellido1text.Name = "apellido1text";
            this.apellido1text.Size = new System.Drawing.Size(88, 20);
            this.apellido1text.TabIndex = 12;
            // 
            // nombre2text
            // 
            this.nombre2text.Location = new System.Drawing.Point(6, 98);
            this.nombre2text.Name = "nombre2text";
            this.nombre2text.Size = new System.Drawing.Size(87, 20);
            this.nombre2text.TabIndex = 13;
            // 
            // nombre1text
            // 
            this.nombre1text.Location = new System.Drawing.Point(6, 44);
            this.nombre1text.Name = "nombre1text";
            this.nombre1text.Size = new System.Drawing.Size(88, 20);
            this.nombre1text.TabIndex = 14;
            this.nombre1text.TextChanged += new System.EventHandler(this.nombre1text_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechasa);
            this.groupBox1.Controls.Add(this.fechaing);
            this.groupBox1.Controls.Add(this.fechanaci);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.codestext);
            this.groupBox1.Controls.Add(this.apellido2text);
            this.groupBox1.Controls.Add(this.apellido1text);
            this.groupBox1.Controls.Add(this.nombre2text);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nombre1text);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(31, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 477);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Alumnos";
            // 
            // fechasa
            // 
            this.fechasa.Location = new System.Drawing.Point(8, 383);
            this.fechasa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechasa.Name = "fechasa";
            this.fechasa.Size = new System.Drawing.Size(151, 20);
            this.fechasa.TabIndex = 18;
            // 
            // fechaing
            // 
            this.fechaing.Location = new System.Drawing.Point(8, 326);
            this.fechaing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaing.Name = "fechaing";
            this.fechaing.Size = new System.Drawing.Size(151, 20);
            this.fechaing.TabIndex = 17;
            // 
            // fechanaci
            // 
            this.fechanaci.Location = new System.Drawing.Point(5, 270);
            this.fechanaci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechanaci.Name = "fechanaci";
            this.fechanaci.Size = new System.Drawing.Size(151, 20);
            this.fechanaci.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Codigo de Estudiante";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Fluent Icons", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(249, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 35);
            this.label9.TabIndex = 16;
            this.label9.Text = "Alumnos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alumnoIDDataGridViewTextBoxColumn,
            this.codigoestudianteDataGridViewTextBoxColumn,
            this.nombrealDataGridViewTextBoxColumn,
            this.nombreal2DataGridViewTextBoxColumn,
            this.apellidoalDataGridViewTextBoxColumn,
            this.apellidoal2DataGridViewTextBoxColumn,
            this.fechanacimientoalDataGridViewTextBoxColumn,
            this.fechaIngresoalDataGridViewTextBoxColumn,
            this.fechaSalidaalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alumnosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(281, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(884, 323);
            this.dataGridView1.TabIndex = 17;
            // 
            // alumnoIDDataGridViewTextBoxColumn
            // 
            this.alumnoIDDataGridViewTextBoxColumn.DataPropertyName = "AlumnoID";
            this.alumnoIDDataGridViewTextBoxColumn.HeaderText = "AlumnoID";
            this.alumnoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alumnoIDDataGridViewTextBoxColumn.Name = "alumnoIDDataGridViewTextBoxColumn";
            this.alumnoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.alumnoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoestudianteDataGridViewTextBoxColumn
            // 
            this.codigoestudianteDataGridViewTextBoxColumn.DataPropertyName = "codigo_estudiante";
            this.codigoestudianteDataGridViewTextBoxColumn.HeaderText = "codigo_estudiante";
            this.codigoestudianteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoestudianteDataGridViewTextBoxColumn.Name = "codigoestudianteDataGridViewTextBoxColumn";
            this.codigoestudianteDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombrealDataGridViewTextBoxColumn
            // 
            this.nombrealDataGridViewTextBoxColumn.DataPropertyName = "Nombreal";
            this.nombrealDataGridViewTextBoxColumn.HeaderText = "Nombreal";
            this.nombrealDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombrealDataGridViewTextBoxColumn.Name = "nombrealDataGridViewTextBoxColumn";
            this.nombrealDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreal2DataGridViewTextBoxColumn
            // 
            this.nombreal2DataGridViewTextBoxColumn.DataPropertyName = "Nombreal2";
            this.nombreal2DataGridViewTextBoxColumn.HeaderText = "Nombreal2";
            this.nombreal2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreal2DataGridViewTextBoxColumn.Name = "nombreal2DataGridViewTextBoxColumn";
            this.nombreal2DataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidoalDataGridViewTextBoxColumn
            // 
            this.apellidoalDataGridViewTextBoxColumn.DataPropertyName = "Apellidoal";
            this.apellidoalDataGridViewTextBoxColumn.HeaderText = "Apellidoal";
            this.apellidoalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoalDataGridViewTextBoxColumn.Name = "apellidoalDataGridViewTextBoxColumn";
            this.apellidoalDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidoal2DataGridViewTextBoxColumn
            // 
            this.apellidoal2DataGridViewTextBoxColumn.DataPropertyName = "Apellidoal2";
            this.apellidoal2DataGridViewTextBoxColumn.HeaderText = "Apellidoal2";
            this.apellidoal2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoal2DataGridViewTextBoxColumn.Name = "apellidoal2DataGridViewTextBoxColumn";
            this.apellidoal2DataGridViewTextBoxColumn.Width = 125;
            // 
            // fechanacimientoalDataGridViewTextBoxColumn
            // 
            this.fechanacimientoalDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimientoal";
            this.fechanacimientoalDataGridViewTextBoxColumn.HeaderText = "fecha_nacimientoal";
            this.fechanacimientoalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechanacimientoalDataGridViewTextBoxColumn.Name = "fechanacimientoalDataGridViewTextBoxColumn";
            this.fechanacimientoalDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaIngresoalDataGridViewTextBoxColumn
            // 
            this.fechaIngresoalDataGridViewTextBoxColumn.DataPropertyName = "FechaIngresoal";
            this.fechaIngresoalDataGridViewTextBoxColumn.HeaderText = "FechaIngresoal";
            this.fechaIngresoalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaIngresoalDataGridViewTextBoxColumn.Name = "fechaIngresoalDataGridViewTextBoxColumn";
            this.fechaIngresoalDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaSalidaalDataGridViewTextBoxColumn
            // 
            this.fechaSalidaalDataGridViewTextBoxColumn.DataPropertyName = "FechaSalidaal";
            this.fechaSalidaalDataGridViewTextBoxColumn.HeaderText = "FechaSalidaal";
            this.fechaSalidaalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaSalidaalDataGridViewTextBoxColumn.Name = "fechaSalidaalDataGridViewTextBoxColumn";
            this.fechaSalidaalDataGridViewTextBoxColumn.Width = 125;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.escuela24DataSet;
            // 
            // escuela24DataSet
            // 
            this.escuela24DataSet.DataSetName = "Escuela24DataSet";
            this.escuela24DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 424);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "alumnos";
            this.Load += new System.EventHandler(this.alumnos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela24DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox codestext;
        private System.Windows.Forms.TextBox apellido2text;
        private System.Windows.Forms.TextBox apellido1text;
        private System.Windows.Forms.TextBox nombre2text;
        private System.Windows.Forms.TextBox nombre1text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Escuela24DataSet escuela24DataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private Escuela24DataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumnoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoestudianteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreal2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoal2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngresoalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalidaalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker fechasa;
        private System.Windows.Forms.DateTimePicker fechaing;
        private System.Windows.Forms.DateTimePicker fechanaci;
    }
}