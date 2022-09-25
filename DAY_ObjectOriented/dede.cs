using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_ObjectOriented
{
    public class dede
    {
        public string isim { get; set; }    
        public string soyisim { get; set; }
        public string yas { get; set; }
        public string maas { get; set; }

        public virtual void bilgileri_yazdır()
        {
            Console.WriteLine("dede = "+ this.isim);
        }
    }
}
