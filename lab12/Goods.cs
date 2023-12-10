using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    [FirestoreData]
    internal class Goods
    {
        [FirestoreProperty("fName")]
        public string fName { get; set; }

        [FirestoreProperty("fCount")]
        public int fCount { get; set; }

        [FirestoreProperty("Price")]
        public int Price { get; set; }

        [FirestoreProperty("fk_checks")]
        public int fk_checks { get; set; }

        [FirestoreProperty("fk_distributor")]
        public int fk_distributor { get; set; }
    }
}
