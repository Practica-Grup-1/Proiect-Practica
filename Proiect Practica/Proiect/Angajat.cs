using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
   public class Angajat
    {
        public string nume;
        public string prenume;
        public string CNP;
        public string functie;
        public float salariuBrut;
        public bool scutitImpozit;

        public Angajat(string nume2, string prenume2, string CNP2, string fct, float salariuBrut2, bool scutitImpozit2)
        {
            nume = nume2;
            prenume = prenume2;
            CNP = CNP2;
            functie = fct;
            salariuBrut = salariuBrut2;
            scutitImpozit = scutitImpozit2;
        }
        public Angajat()
        {
            nume = null;
            prenume = null;
            CNP = null;
            functie = null;
            salariuBrut = 0;
            scutitImpozit = false;
        }
        public string Nume
        {
            get;set;
        }
        public string Prenume
        {
            get;set;
        }
        public int CNP2
        {
            get;set;
        }
        public string  Functie
        {
            get;set;
        }
        public float SalariuBrut
        {
            get;set;
        }
        public bool ScutitImpozit
        {
            get;set;
        }
    }
}
