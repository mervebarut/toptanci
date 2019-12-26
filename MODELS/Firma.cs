using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    class Firma
    {
        public int Firma_ID { get; set; }
        public string Firma_Adi { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Fax{ get; set; }
        public string ePosta { get; set; }
        public ICollection<Urun> SepettekiUrunler { get; set; }

    }
}
