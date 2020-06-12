using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 siImoet = new Class2();

            siImoet.MempertahankanDiri();
            siImoet.Terbang();
            siImoet.Loncat();

            Console.WriteLine("Berat badan siImoet : {0}", siImoet.beratBadan);
        }
    }
}