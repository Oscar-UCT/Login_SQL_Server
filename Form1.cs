using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_Login_04_11_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }

        private void ingresarBtn_Click(object sender, EventArgs e)
        {
            if (rutInput.Text == "admin" && contraseñaInput.Text == "pass")
            {
                Administrador adminsitracionForm = new Administrador();
                adminsitracionForm.Show();
                this.Hide();
            }

            using (SqlConnection conexion = new SqlConnection(@"Data Source=OSCAR-VICTUS;Initial Catalog=EstudiantesUCT;Integrated Security=True;"))
            {
                conexion.Open();
                SqlCommand command = conexion.CreateCommand();
                command.CommandText = "SELECT RUT, Contraseña FROM Estudiantes";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    bool usuarioEncontrado = false;
                    while (reader.Read())
                    {
                        if (reader.GetString(0) == rutInput.Text && reader.GetString(1) == contraseñaInput.Text)
                        {
                            usuarioEncontrado = true;
                            MessageBox.Show("Ingreso Exitoso");
                            break;
                        }
                    }
                    if (!usuarioEncontrado)
                    {
                        MessageBox.Show("Credenciales Inválidas");
                    }
                }
            }


        }
    }
}
