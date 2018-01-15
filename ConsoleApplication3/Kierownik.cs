using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Kierownik:Pracownik
    {
        public int staz { get; set; }
        public Kierownik() { }
        public override double Dodatek (int nadgodziny)
        {
            base.Dodatek(nadgodziny);
            return nadgodziny * (50 + staz) * 120 + 500;
        }
        public override string ToString()
        {

            return "Imie : {imie} , Staż : {staz}, Pensja : {pensja} *Kierownik*";

        }



    }
}
