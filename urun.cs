using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class urun
    {
        public abstract string marka { get;  }
        public abstract string tip { get; }
        public abstract decimal vergiorani { get;  }// degişebilen abstract virtual

        public string baslik { get { return baslikbelirle(); } }

            public virtual string baslikbelirle()
        {
            return marka + " " + tip;


        }
        public urunfiyati urunfiyati { get; set; } 

        public urun()
        {
            urunfiyati = new urunfiyati(vergiorani);

        }




        
    }
}
