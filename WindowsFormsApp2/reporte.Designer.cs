namespace WindowsFormsApp2
{
    partial class reporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.escuela24DataSet1 = new WindowsFormsApp2.Escuela24DataSet1();
            this.escuela24DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maestrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maestrosTableAdapter = new WindowsFormsApp2.Escuela24DataSet1TableAdapters.MaestrosTableAdapter();
            this.maestrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.escuela24DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela24DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestrosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.maestrosBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(44, 96);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(636, 246);
            this.reportViewer1.TabIndex = 2;
            // 
            // escuela24DataSet1
            // 
            this.escuela24DataSet1.DataSetName = "Escuela24DataSet1";
            this.escuela24DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // escuela24DataSet1BindingSource
            // 
            this.escuela24DataSet1BindingSource.DataSource = this.escuela24DataSet1;
            this.escuela24DataSet1BindingSource.Position = 0;
            // 
            // maestrosBindingSource
            // 
            this.maestrosBindingSource.DataMember = "Maestros";
            this.maestrosBindingSource.DataSource = this.escuela24DataSet1BindingSource;
            // 
            // maestrosTableAdapter
            // 
            this.maestrosTableAdapter.ClearBeforeFill = true;
            // 
            // maestrosBindingSource1
            // 
            this.maestrosBindingSource1.DataMember = "Maestros";
            this.maestrosBindingSource1.DataSource = this.escuela24DataSet1BindingSource;
            // 
            // reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 499);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reporte";
            this.Text = "reporte";
            this.Load += new System.EventHandler(this.reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.escuela24DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuela24DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestrosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Escuela24DataSet1 escuela24DataSet1;
        private System.Windows.Forms.BindingSource escuela24DataSet1BindingSource;
        private System.Windows.Forms.BindingSource maestrosBindingSource;
        private Escuela24DataSet1TableAdapters.MaestrosTableAdapter maestrosTableAdapter;
        private System.Windows.Forms.BindingSource maestrosBindingSource1;
    }
}