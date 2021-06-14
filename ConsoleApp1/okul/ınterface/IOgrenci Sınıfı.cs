using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okul.ınterface
{
    interface IOgrenci_Sınıfı
    {
        public string ogrencıno{ get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }

        public DateTime dogumtarihi { get; set; }
        public string bölümü { get; set; }
        public string sınıfı{ get; set; }
        public string notortalaması { get; set; }



    }
}
