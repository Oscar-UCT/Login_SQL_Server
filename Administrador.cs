using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_Login_04_11_2024
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estudiantesUCTDataSet.Estudiantes' table. You can move, or remove it, as needed.
            this.estudiantesTableAdapter.Fill(this.estudiantesUCTDataSet.Estudiantes);

        }
    }
}
