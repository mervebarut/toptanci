using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Urun
    {
        public int Urun_ID { get; set; }

        public string Urun_Adi { get; set; }
       
        public string Kategori_ID { get; set; }
       
        public string Firma_ID { get; set; }
        public Firma Firmasi { get; set; }
    }
}
