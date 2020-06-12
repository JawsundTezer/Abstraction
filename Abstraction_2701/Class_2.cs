using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Class2 : Class1, IDapatTerbang, IDapatLoncat
    {
        public Class2()
        {
            beratBadan = 5;
        }

        //Mengimplementasikan method MempertahankanDiri khas Ayam
        public override void MempertahankanDiri()
        {
            Console.WriteLine("Ayam mematuk dengan sangat keras ....!!!");
        }

        //Membuat method Terbang baru khas Ayam
        public void Terbang()
        {
            Console.WriteLine("Ayam sedang terbang ...!!!");
        }

        //Membuat method Loncat baru khas Ayam
        public void Loncat()
        {
            Console.WriteLine("Ayan sedang loncat ...!!!");
        }
    }
}