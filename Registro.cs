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

namespace Projecto_Login_04_11_2024
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {
            if (DatosValidos())
            {
                using (SqlConnection conexion = new SqlConnection(@"Data Source=OSCAR-VICTUS;Initial Catalog=EstudiantesUCT;Integrated Security=True;"))
                { 
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("CrearEstudiante", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@RUT", rutInput.Text);
                        cmd.Parameters.AddWithValue("@Nombre", nombreInput.Text);
                        cmd.Parameters.AddWithValue("@Apellido", apellidoInput.Text);
                        cmd.Parameters.AddWithValue("@Direccion", direccionInput.Text);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseñaInput.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                Form1 inicio = new Form1();
                this.Dispose();
                inicio.Show();
            }

        }

        bool DatosValidos()
        {
            if (rutInput.TextLength == 9 &&
                nombreInput.TextLength < 50 &&
                nombreInput.TextLength > 2 &&
                apellidoInput.TextLength < 50 &&
                apellidoInput.TextLength > 2 &&
                direccionInput.TextLength < 50 &&
                direccionInput.TextLength > 2 &&
                contraseñaInput.TextLength < 32 &&
                contraseñaInput.TextLength > 2)
            { return true; }
            return false;
        }
    }
}
