using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using System.IO;
using Academia.Domain.Model;
using Academia.Data.Repositories;
using Academia.WindowsForms.Forms;
using Academia.Data.EF;
using Microsoft.EntityFrameworkCore; 



namespace Academia.WindowsForms
{
    public partial class FormAlumno : Form
    {
        private readonly AlumnoRepositoryEF _alumnoRepository;

        public FormAlumno()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<AcademiaContext>()
                .UseSqlServer("Server=PC-Jere\\SQLEXPRESS;Database=Academia;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

            var context = new AcademiaContext(options);

            _alumnoRepository = new AlumnoRepositoryEF(context);
        }


        private void FormAlumno_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void CargarAlumnos()
        {
            var alumnos = _alumnoRepository.GetAll();
            dgvAlumnos.DataSource = alumnos.ToList();
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            var form = new FormAlumnoABM();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _alumnoRepository.Add(form.Alumno);
                CargarAlumnos();
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow != null)
            {
                var alumno = (Alumno)dgvAlumnos.CurrentRow.DataBoundItem;
                var form = new FormAlumnoABM(alumno);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _alumnoRepository.Update(form.Alumno);
                    CargarAlumnos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un alumno para editar.");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow != null)
            {
                var alumno = (Alumno)dgvAlumnos.CurrentRow.DataBoundItem;

                var result = MessageBox.Show(
                    $"¿Está seguro que desea eliminar a {alumno.Nombre} {alumno.Apellido}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    _alumnoRepository.Delete(alumno.IdAlumno);
                    CargarAlumnos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un alumno para eliminar.");
            }
        }
    }
}
