using System;
using System.Security.Cryptography.X509Certificates;

namespace Bog
{
    public class Bog
    {

        public string Titel
        {
            get { return Titel; }
            set { CheckTitel(value); Titel = value; }
        }

        public string Forfatter
        {
            get { return Forfatter; }
            set {CheckForfatter(value); Forfatter = value; }
        }

        public int Sidetal
        {
            get { return Sidetal; }
            set { CheckSidetal(value); Sidetal = value; }
        }

        public string ISBN13
        {
            get { return ISBN13; }
            set { CheckISBN13(value); ISBN13 = value; }
        }

        
        //constructors
        public Bog() {}

        public Bog(string titel, string forfatter, int sidetal, string isbn13)
        {

            CheckTitel(titel);
            CheckForfatter(forfatter);
            CheckSidetal(sidetal);
            CheckISBN13(isbn13);
            Titel = titel;
            Forfatter = forfatter;
            Sidetal = sidetal;
            ISBN13 = isbn13;

        }




        //Checks
        private static void CheckTitel(string titel)
        {
            if (string.IsNullOrWhiteSpace(titel) | titel.Length < 2)
            {
                throw new ArgumentException("Titel skal være længere end 2 tegn og være Gyldig");
            }
        }

        private static void CheckForfatter(string forfatter)
        {
            if (string.IsNullOrWhiteSpace(forfatter))
            {
                throw new ArgumentException("Forfatter er ikke gyldig eller tom");
            }
        }

        private static void CheckSidetal(int sidetal)
        {
            if (sidetal < 10 | sidetal > 1000 )
            {
                throw new ArgumentOutOfRangeException("Sidetal skal være mellem 10 og 1000 sider");
            }
        }

        private static void CheckISBN13(string isbn13)
        {
            if (isbn13.Length < 13 | isbn13.Length > 13)
            {
                throw new ArgumentOutOfRangeException("ISBN13 Skal være præcist 13 karakterer langt");
            }
        }


        //ToString

        public override string ToString()
        {
            return string.Format(Titel, Forfatter, Sidetal, ISBN13);
        }

    }
}


