using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_ObjectOriented
{
    public class baba:dede
    {
        public string tc { get; set; }
        public override bilgileri_yazdır()
        {
            Console.WriteLine("dede = " + this.isim);
        }
    }
}
