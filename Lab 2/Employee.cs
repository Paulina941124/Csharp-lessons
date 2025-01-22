using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    abstract class Employee
    {
        protected string imie;
        protected string nazwisko;
        protected decimal pensja;

        public Employee(string imie, string nazwisko, decimal pensja)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pensja = pensja;
        }
        public virtual void Add(Employee emp)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(string imie, string nazwisko)
        {
            throw new NotImplementedException();
        }
        public abstract decimal podajPensje();

        public abstract void wypiszInfo();

        // metoda pomocnicza dla klasy manager do usuwania, gdyż potrezbne tam pola sa chronione w employee
        public bool czyPasuje(string imie, string nazwisko)
        {
            return this.imie == imie && this.nazwisko == nazwisko;
        }
    }
}
