using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    internal class urunfiyati
    {
        public decimal tutar { get; set; }
        private decimal _vergiorani;
        public decimal vergiorani { get { return _vergiorani; } }

        public decimal vergitutari { get { return tutar * vergiorani; } }

        public decimal fiyat { get { return tutar + vergitutari; } }
        public urunfiyati(decimal vergioran)
        {
            _vergiorani = vergioran;



        }
        public void hakkinda()
        {
            Console.WriteLine("tutar={0} vergioranı= {1} vergi tutarı= {2} fiyat= {3}", tutar, vergiorani, vergitutari, fiyat);


        }

    }
}
