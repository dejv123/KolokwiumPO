using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class ListaPlac:IPlace
    {
        public List<Pracownik> pracownicy = new List<Pracownik>();

        public void DodajPracownika(int staz, string imie, double pensja, DateTime dataZatrudnienia)
        {
        }
        public void DodajKierownika(int staz, string imie, double pensja, DateTime dataZatrudnienia)
        {
        }

    }

}
