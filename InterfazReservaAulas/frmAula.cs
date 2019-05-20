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
    public partial class frmAula : Form
    {
        public frmAula()
        {
            InitializeComponent();
        }

        private void txtNombreApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAula_Load(object sender, EventArgs e)
        {
            cboTipoAula.DataSource = Enum.GetValues(typeof(Tipo_Aula));
            cboPiso.DataSource = Enum.GetValues(typeof(Piso));
            cboPiso.SelectedItem = null;
            cboTipoAula.SelectedItem = null;

        }

       
        private Aula1 ObtenerAulaFormulario()
        {
            Aula1 aula = new Aula1();
            aula.Nro_Aula = (txtNroAula_ID.Text.Trim());
            aula.Cant_Alumnos = (txtCantidadAlumnos.Text);
            aula.Venum_Tipo_aula = (Tipo_Aula)cboTipoAula.SelectedItem;
            aula.Venum_piso = (Piso)cboPiso.SelectedItem;
            //profesor.Venum_tipoDocumento = (Profesor.TipoDocumento)cboTipoDocumento.SelectedItem;
            aula.Proyector = rdbPoseeProyector.Checked;

            return aula;
        }
      
        private void ActualizarListaAula()
        {

            dgvAula.DataSource = null;
            dgvAula.DataSource = Aula1.ObtenerAulas();
        }

        private void LimpiarFormulario()
        {
            txtCantidadAlumnos.Text = "";
            txtNroAula_ID.Text = "";
            cboPiso.SelectedItem = null;
            cboTipoAula.SelectedItem = null;
            rdbPoseeProyector.Checked = true;

        }

       

        private void dgvAula_Click(object sender, EventArgs e)
        {
            int index = dgvAula.CurrentCell.RowIndex;
            Aula1.listaAulas[index] = ObtenerAulaFormulario();



        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Aula1 Aula = ObtenerAulaFormulario();
            Aula1.AgregarAula(Aula);
            ActualizarListaAula();
            LimpiarFormulario();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int index = dgvAula.CurrentCell.RowIndex;
            Aula1.listaAulas[index] = ObtenerAulaFormulario();
            ActualizarListaAula();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Aula1 Aula = (Aula1)dgvAula.CurrentRow.DataBoundItem;
            Aula1.EliminarAula(Aula);
            ActualizarListaAula();
            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dgvAula_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

