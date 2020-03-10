using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimeticNikOO
{
    class Program
    {
        static void Main(string[] args)
        {

            float VisinaKataPr;

            Neboder Tower = new Neboder(200, 100);

            Tower.setVisina(Tower.getVisina() + 10);
            Tower.setBrojKatova(Tower.getBrojKatova() + 1);

            VisinaKataPr = Tower.getVisina() / Tower.getBrojKatova();
            Console.WriteLine("Prosjecna visina kata je:"+ VisinaKataPr);
            Console.ReadKey();
        }
    }
}
