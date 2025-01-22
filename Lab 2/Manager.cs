using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Manager : Employee
    {
        private List<Employee> podwladni = new List<Employee>();
        
        public Manager(string imie, string nazwisko, decimal pensja): base(imie, nazwisko, pensja) { }

        public override decimal podajPensje()
        {
            decimal sumaPensji = pensja;
            foreach (var emp in podwladni)
            {
                sumaPensji += emp.podajPensje();
            }
            return sumaPensji;
        }
        public override void wypiszInfo()
        {
            Console.WriteLine($"Manager: {imie} {nazwisko}");
            foreach (var emp in podwladni)
            {
                emp.wypiszInfo();
            }
        }
        public override void Add(Employee emp)
        {
            podwladni.Add(emp);
        }
        public override void Remove(string imie, string nazwisko)
        {
            podwladni.RemoveAll(e => e.czyPasuje(imie,nazwisko));
        }
    }
}
