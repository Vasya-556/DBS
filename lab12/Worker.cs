using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace lab12
{
    [FirestoreData]
    internal class Worker
    {
        [FirestoreProperty("Initial")]
        public string Initial { get; set; }

        [FirestoreProperty("position")]
        public string position { get; set; }

        [FirestoreProperty("fk_goods")]
        public int fk_goods { get; set; }

        [FirestoreProperty("fk_checks")]
        public int fk_checks { get; set; }
    }
}
