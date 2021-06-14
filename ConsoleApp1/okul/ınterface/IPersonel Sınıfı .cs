using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okul.ınterface
{
    interface IPersonel_Sınıfı
    {
        public string kımlıkno { get; set; }
        
        public string ad { get; set; }
        public string soyad { get; set; }
        public DateTime dogumtarihi { get; set; }
        public Enum2.departman {get; set;} - enum2.departman.    // enum kullanmaya çalıştım

        public Enum2.gorev {get; set;} - enum2.gorev.    // enum kullanmaya çalıştım
        public DateTime baslamatarıhı{ get; set; }










    }
}
