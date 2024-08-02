using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class reporte : Form
    {
        public reporte()
        {
            InitializeComponent();
        }

        private void reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'escuela24DataSet1.Maestros' Puede moverla o quitarla según sea necesario.
            this.maestrosTableAdapter.Fill(this.escuela24DataSet1.Maestros);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsFormsApp2.reporte rpt1 = new WindowsFormsApp2.reporte();
          
            this.reportViewer1.RefreshReport();
        }
    }
}
