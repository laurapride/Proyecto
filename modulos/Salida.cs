using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamientoSistema.modulos
{
    public partial class Salida : UserControl
    {
        public string GetApiData(string url)
        {

            using (var httpClient = new HttpClient())
            {
                string contentType = "application/json";
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                var userAgent = "d-fens HttpClient";
                httpClient.DefaultRequestHeaders.Add("User-Agent", userAgent);

                var response = httpClient.GetStringAsync(new Uri(url)).Result;

                return response;
            }
        }
        
        List<ListaVehiculos> Mylist = new List<ListaVehiculos>();
        public Salida()
        {
            InitializeComponent();
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {

        }
        private void limpiarcontroles()
        {
            txtbusqueda.Clear();
            txtDueño.Clear();
            txtcolor.Clear();
            txtmodelo.Clear();
            cbIdtipo.SelectedIndex = 0;
        }
        private bool validarplaca()
        {
            if (string.IsNullOrEmpty(txtbusqueda.Text))
            {
                errorProvider1.SetError(txtbusqueda, "This is some Text that I wanted to show");
                return false;

            }
            else
            {
                errorProvider1.SetError(txtbusqueda, " ");
                return true;
            }
        }
        private ListaVehiculos getplaca(string nombre)
        {
            return Mylist.Find(bplaca => bplaca.placas.Contains(nombre));
        }
      

        private void buscar_Click(object sender, EventArgs e)
        {
            var output = GetApiData("http://localhost:8080/api/v1/employees/" + txtbusqueda.Text);

            IEnumerable<ListaVehiculos> result = JsonConvert.DeserializeObject<IEnumerable<ListaVehiculos>>(output);

            if (result.Count() > 0)
            {
                //nombre de datos 
                txtbusqueda.Text = result.First().placa;
                cbIdtipo.SelectedItem =result.First().idvehiculo;
                txtDueño.Text = result.First().dueno;
                txtcolor.Text = result.First().color;
                txtmodelo.Text = result.First().modelo;
            }
            else
            {
                limpiarcontroles();
                txtbusqueda.Focus();
                MessageBox.Show("Sin datos");
            }
            //if (validarplaca() == false)
            // {
            //     return;
            // }
            // ListaVehiculos myplaca = ge tplaca(txtbusqueda.Text);
            // if (myplaca == null)
            // {
            //     errorProvider1.SetError(txtmodelo, "Placa No Encontrada");
            //    
            //     return;

            // }
            // else
            // {
            //     errorProvider1.SetError(txtmodelo, " ");
            //     txtbusqueda.Text = myplaca.placas;
            //     cbIdtipo.SelectedItem = myplaca.idvehiculo;
            //     txtDueño.Text = myplaca.dueno;
            //     txtcolor.Text = myplaca.color;
            //     txtmodelo.Text = myplaca.modelo;
            // }
        }
        private void salir_Click(object sender, EventArgs e)
        {

        }
    }
}
