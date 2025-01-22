using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Worker : Employee
    {
        public Worker(string imie, string nazwisko, decimal pensja) : base(imie, nazwisko, pensja) { }

        public override decimal podajPensje()
        {
            return pensja;
        }
        public override void wypiszInfo()
        {
            Console.WriteLine($"{imie} {nazwisko}");
        }
    }
}
