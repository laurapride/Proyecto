using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoSistema
{
    class ListaVehiculos
    {
        [JsonProperty("id")]
        public string placas { get; set; }
        [JsonProperty("id")]
        public string idvehiculo { get; set; }
        [JsonProperty("id")]
        public string dueno { get; set; }
        [JsonProperty("id")]
        public string color { get; set; }
        [JsonProperty("id")]
        public string modelo { get; set; }
        [JsonProperty("id")]
        public int status { get; set; }



    }
}
