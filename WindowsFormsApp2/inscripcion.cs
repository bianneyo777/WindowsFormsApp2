using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.capadatos;

namespace WindowsFormsApp2
{
    public partial class inscripcion : Form
    {
        public inscripcion()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void inscripcion_Load(object sender, EventArgs e)
        {
            listargrados();
            listarturno();
            listarseccione();

        }

        private void listargrados()
        {
            inscripcio objgrad = new inscripcio();
            cmbgra.DataSource = objgrad.listargrados();
            cmbgra.DisplayMember = "Nombregr";
            cmbgra.ValueMember = "GradoID";
        }
        private void listarturno()
        {
            inscripcio objgrad = new inscripcio();
            cmbturno.DataSource = objgrad.listarturno();
            cmbturno.DisplayMember = "Nombre_turnos";
            cmbturno.ValueMember = "TurnoID";
        }

        private void listarseccione()
        {
            inscripcio objgrad = new inscripcio();
            cmbseccion.DataSource = objgrad.listarseccione();
            cmbseccion.DisplayMember = "Nombrese";
            cmbseccion.ValueMember = "SeccionID";
        }

        private void listaralumno()
        {
            inscripcio objgrad = new inscripcio();
            cmbal.DataSource = objgrad.listaralumno();
            cmbal.DisplayMember = "codigo_estudiante";
            cmbal.ValueMember = "AlumnoId";
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
