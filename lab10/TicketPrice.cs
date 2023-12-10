using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public enum TicketType
    {
        Economy,
        Business,
        FirstClass
    }

    internal class TicketPrice
    {
        public int Id {  get; set; }
        public int Price {  get; set; }
        public TicketType Type { get; set; }
    }
}
