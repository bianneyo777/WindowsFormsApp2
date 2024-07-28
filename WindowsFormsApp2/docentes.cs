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
    public partial class docentes : Form
    {
        public docentes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            string insertar = "Inser into Maestros(Nombrema,Nombrema2,Apellidoma,Apellidoma2,Direccionma,Cedularma, Celular_maestro,Fechaingresoma,FechaSalidaMa)"
                + "Values(@Nombrema, @Nombrema2, @Apellidoma, @Apellidoma2, @Direccionma, @Cedulama, @Celular_Maestro)";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
