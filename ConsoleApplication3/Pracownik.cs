using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Pracownik:IComparable<Pracownik>
    {
        private DateTime dataZatrudnienia;
        private string imie;
        private double pensja;
        private int staz;

        public Pracownik() { }
        public Pracownik(int staz, string imie, double pensja, DateTime dataZatrudnienia)
        {
            this.staz = staz;
            this.imie = imie;
            this.pensja = pensja;
            this.dataZatrudnienia = dataZatrudnienia;

            DateTime NowTime = DateTime.Now;
            DateTime t = DateTime.Now;
            DateTime d = dataZatrudnienia;
            TimeSpan res = d - t;
            staz = Convert.ToInt32(res);

        }

        public virtual double Dodatek(int nadgodziny)
        {
           
            return nadgodziny * (50 + staz) * 120;
        }
        public virtual string ToString(string imie)
        {
            return "Imie : {imie}";
        }
        public virtual string ToString(string imie, int staz)
        {
            return "Imie : {imie} , Staż : {staz}";
        }
        public virtual string ToString(string imie, int staz, double pensja)
        {
            return "Imie : {imie} , Staż : {staz} Pensja z dodatkiem {pensja}";
        }





        public int CompareTo(Pracownik other)
        {
            throw new NotImplementedException();
        }
    }
}
