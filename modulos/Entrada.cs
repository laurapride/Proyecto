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
    public partial class Entrada : UserControl
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
        public Entrada()
        {
            InitializeComponent();
            tcconsultar.Enabled = false;
            tseliminar.Enabled = false;
            tslactualizar.Enabled = false;
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        /* -----------------Proceso de validacion de los datos de entrada-----------------------------------------------------------------------------------------------------
         */
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

            if (validarplaca() == false)
            {
                return;
            }
            if (validaridtipo() == false)
            {
                return;
            }
            if (validardueño() == false)
            {
                return;
            }
            if (validarcolor() == false)
            {
                return;
            }
            if (validarmodelo() == false)
            {
                return;
            }

            //Objeto de la Clase List Vehiculos
            ListaVehiculos myvehiculo = new ListaVehiculos();



            myvehiculo.placas = txtbusqueda.Text;
            myvehiculo.idvehiculo = cbIdtipo.SelectedItem.ToString();
            myvehiculo.dueno = txtDueño.Text;
            myvehiculo.color = txtcolor.Text;
            myvehiculo.modelo = txtmodelo.Text;
            myvehiculo.status = 1;
            Mylist.Add(myvehiculo);
            dgvdatos.DataSource = null;
            dgvdatos.DataSource = Mylist;
            limpiarcontroles();
                txtbusqueda.Focus();
                tcconsultar.Enabled = true;

            
           
        }

        //Metodo para limpiar controles
        private void limpiarcontroles()
        {
            txtbusqueda.Clear();
            txtDueño.Clear();
            txtcolor.Clear();
            txtmodelo.Clear();
            cbIdtipo.SelectedIndex = 0;
        }

        /* -----------------Placa--------------------------------------------------------------------------------------------------------------------
        */

        //Metodo para validar placa
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
        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        /* -----------------Tipo de Vehiculo--------------------------------------------------------------------------------------------------------------------
        */
        //Metodo para validar tipo de vehiculo
        private bool validaridtipo()
        {
            if (string.IsNullOrEmpty(cbIdtipo.Text))
            {
                errorProvider1.SetError(cbIdtipo, "This is some Text that I wanted to show");
                return false;

            }
            else
            {
                errorProvider1.SetError(cbIdtipo, " ");
                return true;
            }
        }

        private void cbIdtipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /* -----------------Dueño--------------------------------------------------------------------------------------------------------------------
        */
        //Metodo para validar dueño
        private bool validardueño()
        {
            if (string.IsNullOrEmpty(txtDueño.Text))
            {
                errorProvider1.SetError(txtDueño, "This is some Text that I wanted to show");
                return false;

            }
            else
            {
                errorProvider1.SetError(txtDueño, " ");
                return true;
            }
        }

        /* -----------------Color--------------------------------------------------------------------------------------------------------------------
        */
        //Metodo para validar color
        private bool validarcolor()
        {
            if (string.IsNullOrEmpty(txtcolor.Text))
            {
                errorProvider1.SetError(txtcolor, "This is some Text that I wanted to show");
                return false;

            }
            else
            {
                errorProvider1.SetError(txtcolor, " ");
                return true;
            }
        }
        /* -----------------Modelo--------------------------------------------------------------------------------------------------------------------
        */
        //Metodo para validar modelo
        private bool validarmodelo()
        {
            if (string.IsNullOrEmpty(txtmodelo.Text))
            {
                errorProvider1.SetError(txtmodelo, "This is some Text that I wanted to show");
                return false;

            }
            else
            {
                errorProvider1.SetError(txtmodelo, " ");
                return true;
            }
        }
        /* -----------------Evento Buscar------------------------------------------------------------------------------------------------------------------
        */
        private void tcconsultar_Click(object sender, EventArgs e)
        {
            
            var output = GetApiData("http://localhost:8080/api/v1/employees/" + txtbusqueda.Text);

                IEnumerable<ListaVehiculos> result = JsonConvert.DeserializeObject<IEnumerable<ListaVehiculos>>(output);

                if (result.Count() > 0)
                {
                    //nombre de datos 
                    txtbusqueda.Text = result.First().placa;
                    cbIdtipo.SelectedItem = result.First().idvehiculo;
                    txtDueño.Text = result.First().dueno;
                    txtcolor.Text = result.First().color;
                    txtmodelo.Text = result.First().modelo;
                }
                else
                {
                    MessageBox.Show("Sin datos");
                }
               
                //txtbusqueda.Text = myplaca.placas;
                //cbIdtipo.SelectedItem = myplaca.idvehiculo;
                //txtDueño.Text = myplaca.dueno;
                //txtcolor.Text = myplaca.color;
                //txtmodelo.Text = myplaca.modelo;
                tseliminar.Enabled = true;
                tslactualizar.Enabled = true;
            
        }
        //metodo consultar vehiculo
        private ListaVehiculos getplaca(string nombre)
        {
            return Mylist.Find(bplaca => bplaca.placas.Contains(nombre));
        }
        /* -----------------Evento Eliminar------------------------------------------------------------------------------------------------------------------
        */
        private void tseliminar_Click(object sender, EventArgs e)
        {
            var output = GetApiData("http://localhost:8080/api/v1/employees/" + txtbusqueda.Text);

            IEnumerable<ListaVehiculos> result = JsonConvert.DeserializeObject<IEnumerable<ListaVehiculos>>(output);

            if (result.Count() > 0)
            {
                DialogResult Respuesta = MessageBox.Show("Seguro de Eliminar", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Respuesta == DialogResult.Yes)
                {
                    foreach (ListaVehiculos myplaca in Mylist)
                    {
                        if (myplaca.placas == txtbusqueda.Text)
                        {
                            //Mylist.Remove(myplaca);
                            //break;
                        }
                    }
                    limpiarcontroles();
                    //dgvdatos.DataSource = null;
                    //dgvdatos.DataSource = Mylist;
                }
                //nombre de datos 
                //txtbusqueda.Text = result.First().placa;
                //cbIdtipo.SelectedItem = result.First().idvehiculo;
                //txtDueño.Text = result.First().dueno;
                //txtcolor.Text = result.First().color;
                //txtmodelo.Text = result.First().modelo;
            }
            else
            {
                MessageBox.Show("Sin datos");
            }            
               
            

        }
       

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tslactualizar_Click(object sender, EventArgs e)
        {
            if (txtbusqueda.Text == "")
            {
                errorProvider1.SetError(txtmodelo, "Debe consultar la placa a editar");
                limpiarcontroles();
                txtbusqueda.Focus();
                tslactualizar.Enabled = false;
                return;

            }
        }
    }
}

