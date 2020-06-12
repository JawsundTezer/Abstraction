using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Class1
    {
        private int _beratBadan;

        public int beratBadan
        {
            get { return _beratBadan; }
            set
            {
                if (value <= 0)
                    value = 1;
                else
                    _beratBadan = value;
            }
        }
        //Ini adalah abstract method
        public abstract void MempertahankanDiri();
    }
}
