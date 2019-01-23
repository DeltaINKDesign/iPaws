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
            return "Id: " + Id + " Nazwa: " + Nazwa +"Płeć : "+Plec +"Wiek: " + Wiek +"Wielkosc" + Wielkosc + "Rodzaj siersci: " + Rodzaj_siersci + "Ilosc Lap: " + Ilosc_Lap;
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
            return "Id: " + Id + " Nazwa: " + Nazwa + "Płeć : " + Plec + "Wiek: " + Wiek + "Wielkosc" + Wielkosc + "Rodzaj siersci: " + Rodzaj_siersci + "Ilosc Lap: " + Ilosc_Lap + "Rasowosc: " + Rasowy;
        }

    }





    class  Owczarki : Rasowosc
    {
        public string Pracujace { get; set; }

        public Owczarki(int Id, string Nazwa, string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap, string Rasowy, string Pracujace ) : base( Id, Nazwa, Plec, Wiek, Wielkosc, Rodzaj_siersci, Ilosc_Lap, Rasowy)
        {

            this.LiczbaMiejsc = LiczbaMiejsc;
        }

        override public string ToString()
        {
            return "Model: " + Model + " Predkosc: " + Predkosc + " Liczba miejsc: " + LiczbaMiejsc;
        }

    }

    class Molosowate : Rasowosc
    {
        public int LiczbaMiejsc { get; set; }

        public Samolot(int Predkosc, string Model, int LiczbaMiejsc) : base(Predkosc, Model)
        {

            this.LiczbaMiejsc = LiczbaMiejsc;
        }

        override public string ToString()
        {
            return "Model: " + Model + " Predkosc: " + Predkosc + " Liczba miejsc: " + LiczbaMiejsc;
        }

    }

    class Teriery : Rasowosc
    {
        public int LiczbaMiejsc { get; set; }

        public Samolot(int Predkosc, string Model, int LiczbaMiejsc) : base(Predkosc, Model)
        {

            this.LiczbaMiejsc = LiczbaMiejsc;
        }

        override public string ToString()
        {
            return "Model: " + Model + " Predkosc: " + Predkosc + " Liczba miejsc: " + LiczbaMiejsc;
        }

    }

    class Jamniki : Rasowosc
    {
        public int LiczbaMiejsc { get; set; }

        public Samolot(int Predkosc, string Model, int LiczbaMiejsc) : base(Predkosc, Model)
        {

            this.LiczbaMiejsc = LiczbaMiejsc;
        }

        override public string ToString()
        {
            return "Model: " + Model + " Predkosc: " + Predkosc + " Liczba miejsc: " + LiczbaMiejsc;
        }

    }

    class Pierwotne : Rasowosc
    {
        public int LiczbaMiejsc { get; set; }

        public Samolot(int Predkosc, string Model, int LiczbaMiejsc) : base(Predkosc, Model)
        {

            this.LiczbaMiejsc = LiczbaMiejsc;
        }

        override public string ToString()
        {
            return "Model: " + Model + " Predkosc: " + Predkosc + " Liczba miejsc: " + LiczbaMiejsc;
        }

    }

    class Gończe : Rasowosc
    {
        public int LiczbaMiejsc { get; set; }

        public Samolot(int Predkosc, string Model, int LiczbaMiejsc) : base(Predkosc, Model)
        {

            this.LiczbaMiejsc = LiczbaMiejsc;
        }

        override public string ToString()
        {
            return "Model: " + Model + " Predkosc: " + Predkosc + " Liczba miejsc: " + LiczbaMiejsc;
        }

    }

    class Wyżły : Rasowosc
    {
        public int LiczbaMiejsc { get; set; }

        public Samolot(int Predkosc, string Model, int LiczbaMiejsc) : base(Predkosc, Model)
        {

            this.LiczbaMiejsc = LiczbaMiejsc;
        }

        override public string ToString()
        {
            return "Model: " + Model + " Predkosc: " + Predkosc + " Liczba miejsc: " + LiczbaMiejsc;
        }

    }

    class Retrivery : Rasowosc
    {
        public int LiczbaMiejsc { get; set; }

        public Samolot(int Predkosc, string Model, int LiczbaMiejsc) : base(Predkosc, Model)
        {

            this.LiczbaMiejsc = LiczbaMiejsc;
        }

        override public string ToString()
        {
            return "Model: " + Model + " Predkosc: " + Predkosc + " Liczba miejsc: " + LiczbaMiejsc;
        }

    }

    class Ozdobne : Rasowosc
    {
        public int LiczbaMiejsc { get; set; }

        public Samolot(int Predkosc, string Model, int LiczbaMiejsc) : base(Predkosc, Model)
        {

            this.LiczbaMiejsc = LiczbaMiejsc;
        }

        override public string ToString()
        {
            return "Model: " + Model + " Predkosc: " + Predkosc + " Liczba miejsc: " + LiczbaMiejsc;
        }

    }

    class Charty : Rasowosc
    {
        public int LiczbaMiejsc { get; set; }

        public Samolot(int Predkosc, string Model, int LiczbaMiejsc) : base(Predkosc, Model)
        {

            this.LiczbaMiejsc = LiczbaMiejsc;
        }

        override public string ToString()
        {
            return "Model: " + Model + " Predkosc: " + Predkosc + " Liczba miejsc: " + LiczbaMiejsc;
        }

    }

    class Nieuznane : Rasowosc
    {
        public int LiczbaMiejsc { get; set; }

        public Samolot(int Predkosc, string Model, int LiczbaMiejsc) : base(Predkosc, Model)
        {

            this.LiczbaMiejsc = LiczbaMiejsc;
        }

        override public string ToString()
        {
            return "Model: " + Model + " Predkosc: " + Predkosc + " Liczba miejsc: " + LiczbaMiejsc;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
