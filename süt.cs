using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{


    internal class sut:gidaurun
    {
        public override string tip { get { return "süüt"; } }
        public override string marka { get { return "pınar"; } }
        public override decimal vergiorani { get {return 0.18m; }  }

        public string hacim { get; set; }

        public override string baslikbelirle()
        {
            string sonuc = base.baslikbelirle() + " ";
            sonuc += hacim + " ";
            return sonuc;
        }


    }
}
