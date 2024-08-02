namespace WindowsFormsApp2
{
    partial class docentes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechasali = new System.Windows.Forms.DateTimePicker();
            this.fechain = new System.Windows.Forms.DateTimePicker();
            this.Cedulatext = new System.Windows.Forms.TextBox();
            this.Celulartext = new System.Windows.Forms.TextBox();
            this.Direcciontext = new System.Windows.Forms.TextBox();
            this.SApellidotext = new System.Windows.Forms.TextBox();
            this.PApellidotext = new System.Windows.Forms.TextBox();
            this.SNombretext = new System.Windows.Forms.TextBox();
            this.PNombretext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maestrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escuela24DataSet1 = new WindowsFormsApp2.Escuela24DataSet1();
            this.maestrosTableAdapter = new WindowsFormsApp2.Escuela24DataSet1TableAdapters.MaestrosTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maestrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela24DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechasali);
            this.groupBox1.Controls.Add(this.fechain);
            this.groupBox1.Controls.Add(this.Cedulatext);
            this.groupBox1.Controls.Add(this.Celulartext);
            this.groupBox1.Controls.Add(this.Direcciontext);
            this.groupBox1.Controls.Add(this.SApellidotext);
            this.groupBox1.Controls.Add(this.PApellidotext);
            this.groupBox1.Controls.Add(this.SNombretext);
            this.groupBox1.Controls.Add(this.PNombretext);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(491, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Docente";
            // 
            // fechasali
            // 
            this.fechasali.Location = new System.Drawing.Point(224, 303);
            this.fechasali.Margin = new System.Windows.Forms.Padding(4);
            this.fechasali.Name = "fechasali";
            this.fechasali.Size = new System.Drawing.Size(265, 22);
            this.fechasali.TabIndex = 17;
            // 
            // fechain
            // 
            this.fechain.Location = new System.Drawing.Point(224, 226);
            this.fechain.Margin = new System.Windows.Forms.Padding(4);
            this.fechain.Name = "fechain";
            this.fechain.Size = new System.Drawing.Size(265, 22);
            this.fechain.TabIndex = 16;
            // 
            // Cedulatext
            // 
            this.Cedulatext.Location = new System.Drawing.Point(349, 153);
            this.Cedulatext.Margin = new System.Windows.Forms.Padding(4);
            this.Cedulatext.Name = "Cedulatext";
            this.Cedulatext.Size = new System.Drawing.Size(132, 22);
            this.Cedulatext.TabIndex = 15;
            // 
            // Celulartext
            // 
            this.Celulartext.Location = new System.Drawing.Point(349, 105);
            this.Celulartext.Margin = new System.Windows.Forms.Padding(4);
            this.Celulartext.Name = "Celulartext";
            this.Celulartext.Size = new System.Drawing.Size(132, 22);
            this.Celulartext.TabIndex = 14;
            // 
            // Direcciontext
            // 
            this.Direcciontext.Location = new System.Drawing.Point(357, 39);
            this.Direcciontext.Margin = new System.Windows.Forms.Padding(4);
            this.Direcciontext.Name = "Direcciontext";
            this.Direcciontext.Size = new System.Drawing.Size(132, 22);
            this.Direcciontext.TabIndex = 13;
            // 
            // SApellidotext
            // 
            this.SApellidotext.Location = new System.Drawing.Point(23, 278);
            this.SApellidotext.Margin = new System.Windows.Forms.Padding(4);
            this.SApellidotext.Name = "SApellidotext";
            this.SApellidotext.Size = new System.Drawing.Size(132, 22);
            this.SApellidotext.TabIndex = 12;
            // 
            // PApellidotext
            // 
            this.PApellidotext.Location = new System.Drawing.Point(31, 186);
            this.PApellidotext.Margin = new System.Windows.Forms.Padding(4);
            this.PApellidotext.Name = "PApellidotext";
            this.PApellidotext.Size = new System.Drawing.Size(132, 22);
            this.PApellidotext.TabIndex = 11;
            // 
            // SNombretext
            // 
            this.SNombretext.Location = new System.Drawing.Point(31, 105);
            this.SNombretext.Margin = new System.Windows.Forms.Padding(4);
            this.SNombretext.Name = "SNombretext";
            this.SNombretext.Size = new System.Drawing.Size(132, 22);
            this.SNombretext.TabIndex = 10;
            // 
            // PNombretext
            // 
            this.PNombretext.Location = new System.Drawing.Point(45, 39);
            this.PNombretext.Margin = new System.Windows.Forms.Padding(4);
            this.PNombretext.Name = "PNombretext";
            this.PNombretext.Size = new System.Drawing.Size(132, 22);
            this.PNombretext.TabIndex = 9;
            this.PNombretext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(335, 279);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha de salida";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(325, 204);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha de ingreso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(400, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cedula";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primer Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(681, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Docente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 301);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maestrosBindingSource
            // 
            this.maestrosBindingSource.DataMember = "Maestros";
            this.maestrosBindingSource.DataSource = this.escuela24DataSet1;
            // 
            // escuela24DataSet1
            // 
            this.escuela24DataSet1.DataSetName = "Escuela24DataSet1";
            this.escuela24DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maestrosTableAdapter
            // 
            this.maestrosTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(569, 121);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 145);
            this.reportViewer1.TabIndex = 19;
            // 
            // docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "docentes";
            this.Text = "docentes";
            this.Load += new System.EventHandler(this.docentes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maestrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela24DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox PNombretext;
        private System.Windows.Forms.TextBox SNombretext;
        private System.Windows.Forms.TextBox Cedulatext;
        private System.Windows.Forms.TextBox Celulartext;
        private System.Windows.Forms.TextBox Direcciontext;
        private System.Windows.Forms.TextBox SApellidotext;
        private System.Windows.Forms.TextBox PApellidotext;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker fechasali;
        private System.Windows.Forms.DateTimePicker fechain;
        private Escuela24DataSet1 escuela24DataSet1;
        private System.Windows.Forms.BindingSource maestrosBindingSource;
        private Escuela24DataSet1TableAdapters.MaestrosTableAdapter maestrosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}