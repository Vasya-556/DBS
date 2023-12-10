using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    [FirestoreData]
    internal class Checks
    {
        [FirestoreProperty("fSum")]
        public float fSum { get; set; }

        [FirestoreProperty("fdate")]
        public string fdate { get; set; }

        [FirestoreProperty("fk_goods")]
        public int fk_goods { get; set; }

        [FirestoreProperty("fk_worker")]
        public int fk_worker { get; set; }
    }
}
