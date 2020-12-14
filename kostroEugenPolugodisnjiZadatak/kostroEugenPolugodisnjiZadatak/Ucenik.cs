using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenPolugodisnjiZadatak
{
    class Ucenik
    {
        string Ime, Prezime, Godina, Razred, Smjer;

        public string Ime1 { get => Ime; set => Ime = value; }
        public string Prezime1 { get => Prezime; set => Prezime = value; }
        public string Godina1 { get => Godina; set => Godina = value; }
        public string Razred1 { get => Razred; set => Razred = value; }
        public string Smjer1 { get => Smjer; set => Smjer = value; }


        public Ucenik(string Ime, string Prezime, string Godina, string Razred)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.Godina = Godina;
            this.Razred = Razred;   
        }

        public string Ispis()
        {
            string Ispis = string.Format("{0, -30} {1, -30} {2, -30} {3, -30} {4, -30}", Ime, Prezime, Godina, Razred ,Smjer);

            return Ispis;
        }
       
        



    }
}
