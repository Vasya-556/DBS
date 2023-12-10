using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    [FirestoreData]
    internal class Distributor
    {
        [FirestoreProperty("fName")]
        public string fName { get; set; }

        [FirestoreProperty("phone")]
        public int phone { get; set; }

        [FirestoreProperty("fk_goods")]
        public int fk_goods { get; set; }
    }
}
