using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2// birbirlerini görebilmek için aynı naamesipacede olmali
{
    internal class program
    {
         static void Main(string[] args)
         {
            int sayi = 5;
            sut sut = new sut();
            sut.diyetmi = true;
            sut.hacim = "1 lt";
            sut.urunfiyati.tutar = 20;
            sut.urunfiyati.hakkinda();
            Console.WriteLine(sut.baslik);
            
            pil pil = new pil();
            pil.urunfiyati.tutar = 10;
          
            Console.WriteLine(pil.baslik);
            pil.urunfiyati.hakkinda();
            
            


         }
    }
}
