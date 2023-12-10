using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    internal class Checks
    {
        [JsonProperty("id_c")]
        public int Id_c { get; set; }

        [JsonProperty("fSum")]
        public double FSum { get; set; }

        [JsonProperty("fdate")]
        public DateTime FDate { get; set; }
    }
}
