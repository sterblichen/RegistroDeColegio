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

namespace RegistroDeColegio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text.Trim();
            string nombre = TBNombre.Text.Trim();
            string edad = TBEdad.Text.Trim();
            DateTime fecha = dateTimePicker1.Value;
            string fecha_1 = fecha.ToString();

            string query = "Insert INTO dbo.login(id,nombreAlumno,edad,fechaDeNacimiento)values( "+ id +" ,'" + nombre + "','" + edad + "','" + fecha_1 + "')";
            try
            {
                SqlConnection conexion = new SqlConnection("server = STERBLICHEN;database=Login;integrated security = true");
                conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                int resultado = cmd.ExecuteNonQuery();
                if (resultado == 0)
                {
                    MessageBox.Show("Registro no insertado");
                }
                else
                {
                    MessageBox.Show("Registro agregado exitosamente");
                }
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text.Trim();
            string nombre = TBNombre.Text.Trim();
            string edad = TBEdad.Text.Trim();
            DateTime fecha = dateTimePicker1.Value;
            string fecha_1 = fecha.ToString();

            string query = "UPDATE dbo.login SET nombreAlumno = '"+nombre+"', edad = '"+edad+"', fechaDeNacimiento = '"+fecha_1+"' where id = "+id+" ";

            try
            {
                SqlConnection conexion = new SqlConnection("server = STERBLICHEN;database=Login;integrated security = true");
                conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                int resultado = cmd.ExecuteNonQuery();
                if (resultado == 0)
                {
                    MessageBox.Show("Registro no insertado");
                }
                else
                {
                    MessageBox.Show("Se Actualizo exitosamente");
                }
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            string id = textBox1.Text.Trim();
            string nombre = TBNombre.Text.Trim();
            string edad = TBEdad.Text.Trim();
            DateTime fecha = dateTimePicker1.Value;
            string fecha_1 = fecha.ToString();
            try
            {
                string query = "DELETE FROM login WHERE id = " + id + "";

                SqlConnection conexion = new SqlConnection("server = STERBLICHEN;database=Login;integrated security = true");
                conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                int resultado = cmd.ExecuteNonQuery();
                if (resultado == 0)
                {
                    MessageBox.Show("Registro no insertado");
                }
                else
                {
                    MessageBox.Show("Se Elimino exitosamente");
                }
                conexion.Close();

            }
            catch (Exception ex)
            {
               
            }
        }
    }
}
