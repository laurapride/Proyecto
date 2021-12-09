using EstacionamientoSistema.controlesPersonalizados;
using EstacionamientoSistema.modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamientoSistema
{
    public partial class Dashboard : Form
    {
        Form1 inicioSesion = null;
        DashboardGeneral dashboardGeneral;
        Entrada entradaVehiculos;
        Salida salidaVehiculos;
        Registro registrosVehiculos;
        Usuario usuarios;

        public Dashboard(Form1 form)
        {
            InitializeComponent();
            inicioSesion = form;
            dashboardGeneral = new DashboardGeneral();
            entradaVehiculos = new Entrada();
            salidaVehiculos = new Salida();
            registrosVehiculos = new Registro();
            usuarios = new Usuario();
            panelGeneral.Controls.Add(dashboardGeneral);
        }

        //eventos en botones
        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            inicioSesion.Visible = true;
            this.Dispose();
        }

        private void botonesMenu_Click(object sender, EventArgs e)
        {
            RJButton botonAuxiliar = (RJButton)sender;
            cambiarColor(int.Parse(botonAuxiliar.Tag.ToString()));
        }

        //eventos de actualización

        private void cambiarColor(int modulo)
        {
            panelGeneral.Controls.Clear();
            btn_dashboard.BackColor = Color.RoyalBlue;
            btn_entrada.BackColor = Color.RoyalBlue;
            btn_salida.BackColor = Color.RoyalBlue;
            btn_registro.BackColor = Color.RoyalBlue;
            btn_usuario.BackColor = Color.RoyalBlue;
            switch (modulo)
            {
                case 1: 
                    btn_dashboard.BackColor = Color.DarkBlue;
                    panelGeneral.Controls.Add(dashboardGeneral);
                    break;
                case 2: 
                    btn_entrada.BackColor = Color.DarkBlue;
                    panelGeneral.Controls.Add(entradaVehiculos);
                    break;
                case 3: 
                    btn_salida.BackColor = Color.DarkBlue;
                    panelGeneral.Controls.Add(salidaVehiculos);
                    break;
                case 4: 
                    btn_registro.BackColor = Color.DarkBlue;
                    panelGeneral.Controls.Add(registrosVehiculos);
                    break;
                case 5: 
                    btn_usuario.BackColor = Color.DarkBlue;
                    panelGeneral.Controls.Add(usuarios);
                    break;
            }
        }
    }
}
