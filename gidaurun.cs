using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    abstract class gidaurun:urun
    {
        public bool diyetmi { get; set; }
        public override decimal vergiorani { get { return 0.07m; } }

        public override string baslikbelirle()
        {
            string sonuc = base.baslikbelirle() + " ";
            if (diyetmi)
            {
                sonuc += "diyet";
            }


            return sonuc;
        }



    }
}
