using ReservaDeAulas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaDeAulasInterfaz
{
    public partial class frmProfesor : Form
    {
        public frmProfesor()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Profesor profesor = ObtenerProfesorFormulario();
            Profesor.AgregarProfesor(profesor);
            ActualizarDatagrid();
            LimpiarFormulario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = dgvProfesores.CurrentCell.RowIndex;
            Profesor.listaProfesor[index] = ObtenerProfesorFormulario();
            ActualizarDatagrid();
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Profesor profesor = (Profesor)dgvProfesores.CurrentRow.DataBoundItem;
            Profesor.EliminarProfesor(profesor);
            ActualizarDatagrid();
            LimpiarFormulario();
        }

        private void ActualizarDatagrid()
        {
            dgvProfesores.DataSource = null;
            dgvProfesores.DataSource = Profesor.listaProfesor;
        }

        private void LimpiarFormulario()
        {
            txtProfesor_ID.Text = "";
            txtNroDoc.Text = "";
            txtNombreApellido.Text = "";
            txtEmail.Text = "";
            cboTipoDocumento.SelectedItem = null;
            dtpFechaNac.Value = System.DateTime.Now;
        }


        private Profesor ObtenerProfesorFormulario()
        {
            Profesor profesor = new Profesor();
            profesor.Profesor_ID = Convert.ToInt16(txtProfesor_ID.Text);
            profesor.NombreApellido = txtNombreApellido.Text;
            profesor.NroDocumento = txtNroDoc.Text;
            profesor.Email = txtEmail.Text;
            profesor.FechaNacimiento = dtpFechaNac.Value;
            profesor.Venum_tipoDocumento = (Profesor.TipoDocumento)cboTipoDocumento.SelectedItem;

            return profesor;
        }

        private void dgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Profesor profesor = (Profesor)dgvProfesores.CurrentRow.DataBoundItem;
            txtProfesor_ID.Text = Convert.ToString(profesor.Profesor_ID);
            txtNroDoc.Text = profesor.NroDocumento;
            txtNombreApellido.Text = profesor.NombreApellido;
            txtEmail.Text = profesor.Email;
            cboTipoDocumento.DataSource = Enum.GetValues(typeof(Profesor.TipoDocumento));
            dtpFechaNac.Value = profesor.FechaNacimiento;
        }

        private void frmProfesor_Load(object sender, EventArgs e)
        {
            cboTipoDocumento.DataSource = Enum.GetValues(typeof(Profesor.TipoDocumento));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
