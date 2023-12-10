using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public enum TrainCategory
    {
        Regional,
        Intercity,
        HighSpeed
    }

    internal class TrainType
    {
        public int Id { get; set; }
        public TrainCategory Category { get; set; }
    }
}
