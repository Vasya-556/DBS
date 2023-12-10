using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    internal class Worker
    {
        [JsonProperty("id_w")]
        public int Id_w { get; set; }

        [JsonProperty("Initial")]
        public string Initial { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }
}
