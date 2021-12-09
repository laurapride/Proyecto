using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamientoSistema.modulos
{
    public partial class Usuario : UserControl
    {
        public Usuario()
        {
            InitializeComponent();
            tablaUsuarios.Rows.Clear();
            tablaUsuarios.Rows.Add();
            tablaUsuarios[0, 0].Value = "Pedro";
            tablaUsuarios[1, 0].Value = "pedro@correo.com";
            tablaUsuarios[2, 0].Value = "848-948-4692";
            tablaUsuarios[3, 0].Value = "xxxx-xxxx-xxxx-9865";
        }

        private void tablaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
