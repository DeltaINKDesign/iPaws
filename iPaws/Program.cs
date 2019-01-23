using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPaws
{
    abstract class Pies
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Plec { get; set; }
        public int Wiek { get; set; }
        public string Wielkosc { get; set; }
        public string Rodzaj_siersci { get; set; }
        public int Ilosc_Lap { get; set; }
        public Pies(int Id, string Nazwa,string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap)
        {
            this.Id = Id;
            this.Nazwa = Nazwa;
            this.Plec = Plec;
            this.Wiek = Wiek;
            this.Wielkosc = Wielkosc;
            this.Rodzaj_siersci = Rodzaj_siersci;
            this.Ilosc_Lap = Ilosc_Lap;
        }
        override public string ToString()
        {
            return "Id: " + Id + " Nazwa: " + Nazwa +" Płeć: "+Plec +" Wiek: " + Wiek +" Wielkosc: " + Wielkosc + " Rodzaj siersci: " + Rodzaj_siersci + " Ilosc Lap: " + Ilosc_Lap;
        }

    }

    class Rasowosc : Pies
    {
        public string Rasowy { get; set; }
        public Rasowosc(int Id, string Nazwa,string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap, string Rasowy) : base(Id,  Nazwa,Plec, Wiek,  Wielkosc, Rodzaj_siersci, Ilosc_Lap )
        {
            this.Rasowy = Rasowy;
        }
        override public string ToString()
        {
            return base.ToString() + " Rasowosc: " + Rasowy;
        }

    }





    class  Owczarki : Rasowosc
    {
        public string Pracujace { get; set; }

        public Owczarki(int Id, string Nazwa, string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap, string Rasowy, string Pracujace ) : base( Id, Nazwa, Plec, Wiek, Wielkosc, Rodzaj_siersci, Ilosc_Lap, Rasowy)
        {

            this.Pracujace = Pracujace;
        }

        override public string ToString()
        {
            return base.ToString() + " Pracujace: " + Pracujace;
        }

    }

    class Molosowate : Rasowosc
    {
        public string Dlugosc_Kufy { get; set; }

        public Molosowate(int Id, string Nazwa, string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap, string Rasowy, string Dlugosc_Kufy) : base(Id, Nazwa, Plec, Wiek, Wielkosc, Rodzaj_siersci, Ilosc_Lap, Rasowy)
        {

            this.Dlugosc_Kufy = Dlugosc_Kufy;
        }

        override public string ToString()
        {
            return base.ToString() + " Dlugosc kufy: " + Dlugosc_Kufy;
        }

    }

    class Teriery : Rasowosc
    {
        public string Szczekajace { get; set; }

        public Teriery(int Id, string Nazwa, string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap, string Rasowy, string Szczekajace) : base(Id, Nazwa, Plec, Wiek, Wielkosc, Rodzaj_siersci, Ilosc_Lap, Rasowy)
        {

            this.Szczekajace = Szczekajace;
        }

        override public string ToString()
        {
            return base.ToString() + " Szczekajace: " + Szczekajace;
        }

    }

    class Jamniki : Rasowosc
    {
        public int DlugoscCiala { get; set; }

        public Jamniki(int Id, string Nazwa, string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap, string Rasowy, int DlugoscCiala) : base(Id, Nazwa, Plec, Wiek, Wielkosc, Rodzaj_siersci, Ilosc_Lap, Rasowy)
        {

            this.DlugoscCiala = DlugoscCiala;
        }

        override public string ToString()
        {
            return base.ToString() + " Dlugosc ciala: " + DlugoscCiala;
        }

    }

    class Pierwotne : Rasowosc
    {
        public string Pochodzenie { get; set; }

        public Pierwotne(int Id, string Nazwa, string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap, string Rasowy, string Pochodzenie) : base(Id, Nazwa, Plec, Wiek, Wielkosc, Rodzaj_siersci, Ilosc_Lap, Rasowy)
        {

            this.Pochodzenie = Pochodzenie;
        }

        override public string ToString()
        {
            return base.ToString() + " Pochodzenie: " + Pochodzenie;
        }

    }

    class Goncze : Rasowosc
    {
        public string Wytrzymalosc{ get; set; }

        public Goncze(int Id, string Nazwa, string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap, string Rasowy, string Wytrzymalosc) : base(Id, Nazwa, Plec, Wiek, Wielkosc, Rodzaj_siersci, Ilosc_Lap, Rasowy)
        {

            this.Wytrzymalosc = Wytrzymalosc;
        }

        override public string ToString()
        {
            return base.ToString() + " Wytrzymalosc: " + Wytrzymalosc;
        }

    }

    class Wyżły : Rasowosc
    {
        public string Umaszczenie { get; set; }

        public Wyżły(int Id, string Nazwa, string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap, string Rasowy, string Umaszczenie) : base(Id, Nazwa, Plec, Wiek, Wielkosc, Rodzaj_siersci, Ilosc_Lap, Rasowy)
        {

            this.Umaszczenie = Umaszczenie;
        }

        override public string ToString()
        {
            return base.ToString() + " Umaszczenie: " + Umaszczenie;
        }

    }

    class Retrivery : Rasowosc
    {
        public int SzybkoscPlywania { get; set; }

        public Retrivery(int Id, string Nazwa, string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap, string Rasowy, int SzybkoscPlywania) : base(Id, Nazwa, Plec, Wiek, Wielkosc, Rodzaj_siersci, Ilosc_Lap, Rasowy)
        {

            this.SzybkoscPlywania = SzybkoscPlywania;
        }

        override public string ToString()
        {
            return base.ToString() + " Szybkosc plywania: " + SzybkoscPlywania;
        }

    }

    class Ozdobne : Rasowosc
    {
        public int PoziomSlodkosci { get; set; }

        public Ozdobne(int Id, string Nazwa, string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap, string Rasowy, int PoziomSlodkosci) : base(Id, Nazwa, Plec, Wiek, Wielkosc, Rodzaj_siersci, Ilosc_Lap, Rasowy)
        {

            this.PoziomSlodkosci = PoziomSlodkosci;
        }

        override public string ToString()
        {
            return base.ToString() + " Poziom słodkości: " + PoziomSlodkosci;
        }

    }

    class Charty : Rasowosc
    {
        public int PredkoscBiegu { get; set; }

        public Charty(int Id, string Nazwa, string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap, string Rasowy, int PredkoscBiegu) : base(Id, Nazwa, Plec, Wiek, Wielkosc, Rodzaj_siersci, Ilosc_Lap, Rasowy)
        {

            this.PredkoscBiegu = PredkoscBiegu;
        }

        override public string ToString()
        {
            return base.ToString() + " Predkosc Biegu: " + PredkoscBiegu;
        }

    }

    class Nieuznane : Rasowosc
    {
        public string Typ { get; set; }

        public Nieuznane(int Id, string Nazwa, string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap, string Rasowy, string Typ) : base(Id, Nazwa, Plec, Wiek, Wielkosc, Rodzaj_siersci, Ilosc_Lap, Rasowy)
        {

            this.Typ = Typ;
        }

        override public string ToString()
        {
            return base.ToString() + " Typ: " + Typ;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Pies[] psy = new Pies[4];

            psy[0] = new Wyżły(1, "Pepka ", "Suka",4,"Mała","Krótka",4,"Tak","Biało-pomarańczowe");
           
           
           
            Console.WriteLine(psy[0]);
            
           

           
            Console.ReadKey();


        }
    }
}
