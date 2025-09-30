using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academia.Domain.Model;

namespace Academia.WindowsForms.Forms
{
    public partial class FormAlumnoABM : Form
    {
        public Alumno Alumno { get; private set; }

        public FormAlumnoABM()
        {
            InitializeComponent();
            Alumno = new Alumno();
        }

        public FormAlumnoABM(Alumno alumno) : this()
        {
            Alumno = alumno;
            txtBoxNombre.Text = alumno.Nombre;
            txtBoxApellido.Text = alumno.Apellido;
            txtBoxDNI.Text = alumno.Dni;
            dTPFechaNac.Value = alumno.FechaNacimiento;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Alumno.Nombre = txtBoxNombre.Text;
            Alumno.Apellido = txtBoxApellido.Text;
            Alumno.Dni = txtBoxDNI.Text;
            Alumno.FechaNacimiento = dTPFechaNac.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}

