using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autonevter.futtathato
{
    class Program
    {
        static void Main (string[] args)
        {
            int darabszam = 2;
            Auto[] auto = new Auto[darabszam];
            auto[0] = new Auto ("Skoda", "superb", 2018, "1.8");
        }
    }
}
