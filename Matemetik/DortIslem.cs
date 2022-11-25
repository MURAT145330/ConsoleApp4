using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matemetik
{
    public class DortIslem
    {
        public void  Topla(int sayi1, int sayi2)
        {
          int sonuc=  sayi1 + sayi2;
            Console.WriteLine(sonuc);
        }
    public    int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        int Böl(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }
        int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

    }
}
