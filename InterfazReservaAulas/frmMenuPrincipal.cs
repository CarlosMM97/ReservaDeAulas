using ReservaDeAulasInterfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazReservaAulas
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void tsmAbmAula_Click(object sender, EventArgs e)
        {
            frmAula form = new frmAula();
            form.Show();
        }

        private void tsmMateria_Click(object sender, EventArgs e)
        {
            frmMateria form = new frmMateria();
            form.Show();
        }

        private void tsmAbmProfesores_Click(object sender, EventArgs e)
        {
            frmProfesor  form = new frmProfesor();
            form.Show();
        }
    }
}
