using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        inscripcio objinscripcion = new inscripcio();
        public inscripcion()
        {
            InitializeComponent();
        }
        public static SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection("server=MSI\\SQLEXPRESS;database= escuela24; integrated security= true");
            cn.Open();
            return cn;
        }
        public DataTable llenar_grid()
        {
            conexion.conectar();
            DataTable dt = new DataTable();
            string consulta = "exec mostrains";
            SqlCommand cmd = new SqlCommand(consulta, conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void inscripcion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'escuela24DataSet5.mostrains' Puede moverla o quitarla según sea necesario.
            this.mostrainsTableAdapter.Fill(this.escuela24DataSet5.mostrains);
            listaralumno();
            listargrados();
            listarturno();
            listarseccione();
            mostrains();
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
            inscripcio objtur = new inscripcio();
            cmbturno.DataSource = objtur.listarturno();
            cmbturno.DisplayMember = "Nombre_turnos";
            cmbturno.ValueMember = "TurnoID";
        }

        private void listarseccione()
        {
            inscripcio objsec = new inscripcio();
            cmbseccion.DataSource = objsec.listarseccione();
            cmbseccion.DisplayMember = "Nombrese";
            cmbseccion.ValueMember = "SeccionID";
        }

        private void listaralumno()
        {
            inscripcio objal = new inscripcio();
            cmbal.DataSource = objal.listaralumno();
            cmbal.DisplayMember = "codigo_estudiante";
            cmbal.ValueMember = "AlumnoID";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            objinscripcion.insertarincripcion(Convert.ToInt32(cmbal.SelectedValue),
                Convert.ToInt32(cmbgra.SelectedValue),
                Convert.ToInt32(cmbseccion.SelectedValue),
                Convert.ToInt32(cmbturno.SelectedValue),
                dateTimePicker1.Value);
            MessageBox.Show("agregado correctamente");
            mostrains();
            dataGridView1.DataSource = llenar_grid();


        }

        private void mostrains()
        {
            inscripcio objins = new inscripcio();
            dataGridView1 = new DataGridView();
        }

        private void cmbal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
