using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPaws
{
    abstract class Pies
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        private string Plec { get; set; }
        private int Wiek { get; set; }
        private string Wielkosc { get; set; }
        private string Rodzaj_siersci { get; set; }
        private int Ilosc_Lap { get; set; }
        public Pies(int Id, string Nazwa, string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap)
        {
            this.ID = Id;
            this.Nazwa = Nazwa;
            this.Plec = Plec;
            this.Wiek = Wiek;
            this.Wielkosc = Wielkosc;
            this.Rodzaj_siersci = Rodzaj_siersci;
            this.Ilosc_Lap = Ilosc_Lap;
        }
        override public string ToString()
        {
            return "Id: " + ID + " Nazwa: " + Nazwa + " Płeć: " + Plec + " Wiek: " + Wiek + " Wielkosc: " + Wielkosc + " Rodzaj siersci: " + Rodzaj_siersci + " Ilosc Lap: " + Ilosc_Lap;
        }

    }

    abstract class Rasowosc : Pies
    {
        private string Rasowy { get; set; }
        public Rasowosc(int Id, string Nazwa, string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap, string Rasowy) : base(Id, Nazwa, Plec, Wiek, Wielkosc, Rodzaj_siersci, Ilosc_Lap)
        {
            this.Rasowy = Rasowy;
        }
        override public string ToString()
        {
            return base.ToString() + " Rasowosc: " + Rasowy;
        }

    }
    class Owczarki : Rasowosc
    {
        private string Pracujace { get; set; }

        public Owczarki(int Id, string Nazwa, string Plec, int Wiek, string Wielkosc, string Rodzaj_siersci, int Ilosc_Lap, string Rasowy, string Pracujace) : base(Id, Nazwa, Plec, Wiek, Wielkosc, Rodzaj_siersci, Ilosc_Lap, Rasowy)
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
        private string Dlugosc_Kufy { get; set; }

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
        private string Szczekajace { get; set; }

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
        private int DlugoscCiala { get; set; }

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
        private string Pochodzenie { get; set; }

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
        private string Wytrzymalosc{ get; set; }

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
        private string Umaszczenie { get; set; }

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
        private int SzybkoscPlywania { get; set; }

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
        private int PoziomSlodkosci { get; set; }

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
        private int PredkoscBiegu { get; set; }

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
        private string Typ { get; set; }

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
            List<Pies> psy = new List<Pies>();
            bool done = false;
            int podtyp;
            do
            {
                Console.WriteLine("1. Dodawanie nowego obiektu\n2. Usuwanie obiektu o podanym identyfikatorze\n3. Wyświetlanie wszystkich zapamiętanych obiektów\n4. Wyświetlanie obiektów danego podtypu.\n5. Wyświetlanie obiektów, których nazwa zawiera podany ciąg znaków.\n");
                int caseSwitch = int.Parse(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1. Dodawanie nowego obiektu. Podaj numer podtypu:\n1. Owczarki\n2. Molosowate\n3. Teriery\n4. Jamniki\n5. Pierwotne\n6. Goncze\n7. Wyzly\n8. Retrivery\n9. Ozdobne\n10. Charty\n11. Nieznane\n");
                        podtyp = int.Parse(Console.ReadLine());
                        switch (podtyp)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Podaj idetyfikator (Liczba): ");
                                    int id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj nazwe (Tekst): ");
                                    string nazwa = Console.ReadLine();
                                    Console.WriteLine("Podaj płeć (Tekst): ");
                                    string plec = Console.ReadLine();
                                    Console.WriteLine("Podaj wiek (Liczba): ");
                                    int wiek = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj wielkość (mały, średni, duży): ");
                                    string wielkosc = Console.ReadLine();
                                    Console.WriteLine("Podaj rodzaj sierści (krotka, szorstka, dluga): ");
                                    string siersc = Console.ReadLine();
                                    Console.WriteLine("Podaj ilość łap (Liczba): ");
                                    int lapy = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Czy rasowy ? (Tak/Nie): ");
                                    string rasowy = Console.ReadLine();
                                    Console.WriteLine("Pracujący ? (Tak/Nie) ");
                                    string pracujacy = Console.ReadLine();
                                    psy.Add(new Owczarki(id, nazwa, plec, wiek, wielkosc, siersc, lapy, rasowy, pracujacy));
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Podaj idetyfikator: ");
                                    int id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj nazwe: ");
                                    string nazwa = Console.ReadLine();
                                    Console.WriteLine("Podaj płeć: ");
                                    string plec = Console.ReadLine();
                                    Console.WriteLine("Podaj wiek: ");
                                    int wiek = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj wielkość (mały, średni, duży): ");
                                    string wielkosc = Console.ReadLine();
                                    Console.WriteLine("Podaj rodzaj sierści: ");
                                    string siersc = Console.ReadLine();
                                    Console.WriteLine("Podaj ilość łap: ");
                                    int lapy = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Czy rasowy ? ");
                                    string rasowy = Console.ReadLine();
                                    Console.WriteLine("Dlugość kufy (Długa, krótka): ? ");
                                    string kufa = Console.ReadLine();
                                    psy.Add(new Molosowate(id, nazwa, plec, wiek, wielkosc, siersc, lapy, rasowy, kufa));
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Podaj idetyfikator: ");
                                    int id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj nazwe: ");
                                    string nazwa = Console.ReadLine();
                                    Console.WriteLine("Podaj płeć: ");
                                    string plec = Console.ReadLine();
                                    Console.WriteLine("Podaj wiek: ");
                                    int wiek = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj wielkość (mały, średni, duży): ");
                                    string wielkosc = Console.ReadLine();
                                    Console.WriteLine("Podaj rodzaj sierści: ");
                                    string siersc = Console.ReadLine();
                                    Console.WriteLine("Podaj ilość łap: ");
                                    int lapy = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Czy rasowy ? ");
                                    string rasowy = Console.ReadLine();
                                    Console.WriteLine("Poziom szczekania (niski, średni, wysoki) ? ");
                                    string szczekanie = Console.ReadLine();
                                    psy.Add(new Teriery(id, nazwa, plec, wiek, wielkosc, siersc, lapy, rasowy, szczekanie));
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Podaj idetyfikator: ");
                                    int id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj nazwe: ");
                                    string nazwa = Console.ReadLine();
                                    Console.WriteLine("Podaj płeć: ");
                                    string plec = Console.ReadLine();
                                    Console.WriteLine("Podaj wiek: ");
                                    int wiek = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj wielkość (mały, średni, duży): ");
                                    string wielkosc = Console.ReadLine();
                                    Console.WriteLine("Podaj rodzaj sierści: ");
                                    string siersc = Console.ReadLine();
                                    Console.WriteLine("Podaj ilość łap: ");
                                    int lapy = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Czy rasowy ? ");
                                    string rasowy = Console.ReadLine();
                                    Console.WriteLine("Dlugość ciała (w cm) ? ");
                                    int dlugoscciala = int.Parse(Console.ReadLine());
                                    psy.Add(new Jamniki(id, nazwa, plec, wiek, wielkosc, siersc, lapy, rasowy, dlugoscciala));
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Podaj idetyfikator: ");
                                    int id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj nazwe: ");
                                    string nazwa = Console.ReadLine();
                                    Console.WriteLine("Podaj płeć: ");
                                    string plec = Console.ReadLine();
                                    Console.WriteLine("Podaj wiek: ");
                                    int wiek = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj wielkość (mały, średni, duży): ");
                                    string wielkosc = Console.ReadLine();
                                    Console.WriteLine("Podaj rodzaj sierści: ");
                                    string siersc = Console.ReadLine();
                                    Console.WriteLine("Podaj ilość łap: ");
                                    int lapy = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Czy rasowy ? ");
                                    string rasowy = Console.ReadLine();
                                    Console.WriteLine("Kraj pochodzenia ? ");
                                    string pochodzenie = Console.ReadLine();
                                    psy.Add(new Pierwotne(id, nazwa, plec, wiek, wielkosc, siersc, lapy, rasowy, pochodzenie));
                                    break;
                                }
                            case 6:
                                {
                                    Console.WriteLine("Podaj idetyfikator: ");
                                    int id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj nazwe: ");
                                    string nazwa = Console.ReadLine();
                                    Console.WriteLine("Podaj płeć: ");
                                    string plec = Console.ReadLine();
                                    Console.WriteLine("Podaj wiek: ");
                                    int wiek = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj wielkość (mały, średni, duży): ");
                                    string wielkosc = Console.ReadLine();
                                    Console.WriteLine("Podaj rodzaj sierści: ");
                                    string siersc = Console.ReadLine();
                                    Console.WriteLine("Podaj ilość łap: ");
                                    int lapy = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Czy rasowy ? ");
                                    string rasowy = Console.ReadLine();
                                    Console.WriteLine("Wytrzymalość (mała, średnia, duża) ? ");
                                    string wytrzymalosc = Console.ReadLine();
                                    psy.Add(new Goncze(id, nazwa, plec, wiek, wielkosc, siersc, lapy, rasowy, wytrzymalosc));
                                    break;
                                }
                            case 7:
                                {
                                    Console.WriteLine("Podaj idetyfikator: ");
                                    int id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj nazwe: ");
                                    string nazwa = Console.ReadLine();
                                    Console.WriteLine("Podaj płeć: ");
                                    string plec = Console.ReadLine();
                                    Console.WriteLine("Podaj wiek: ");
                                    int wiek = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj wielkość (mały, średni, duży): ");
                                    string wielkosc = Console.ReadLine();
                                    Console.WriteLine("Podaj rodzaj sierści: ");
                                    string siersc = Console.ReadLine();
                                    Console.WriteLine("Podaj ilość łap: ");
                                    int lapy = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Czy rasowy ? ");
                                    string rasowy = Console.ReadLine();
                                    Console.WriteLine("Umaszczenie ? ");
                                    string umaszczenie = Console.ReadLine();
                                    psy.Add(new Wyżły(id, nazwa, plec, wiek, wielkosc, siersc, lapy, rasowy, umaszczenie));
                                    break;
                                }
                            case 8:
                                {
                                    Console.WriteLine("Podaj idetyfikator: ");
                                    int id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj nazwe: ");
                                    string nazwa = Console.ReadLine();
                                    Console.WriteLine("Podaj płeć: ");
                                    string plec = Console.ReadLine();
                                    Console.WriteLine("Podaj wiek: ");
                                    int wiek = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj wielkość (mały, średni, duży): ");
                                    string wielkosc = Console.ReadLine();
                                    Console.WriteLine("Podaj rodzaj sierści: ");
                                    string siersc = Console.ReadLine();
                                    Console.WriteLine("Podaj ilość łap: ");
                                    int lapy = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Czy rasowy ? ");
                                    string rasowy = Console.ReadLine();
                                    Console.WriteLine("Szybkość pływania (poziom 1,2 czy 3) ? ");
                                    int szybkoscplywania = int.Parse(Console.ReadLine());
                                    psy.Add(new Retrivery(id, nazwa, plec, wiek, wielkosc, siersc, lapy, rasowy, szybkoscplywania));
                                    break;
                                }
                            case 9:
                                {
                                    Console.WriteLine("Podaj idetyfikator: ");
                                    int id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj nazwe: ");
                                    string nazwa = Console.ReadLine();
                                    Console.WriteLine("Podaj płeć: ");
                                    string plec = Console.ReadLine();
                                    Console.WriteLine("Podaj wiek: ");
                                    int wiek = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj wielkość (mały, średni, duży): ");
                                    string wielkosc = Console.ReadLine();
                                    Console.WriteLine("Podaj rodzaj sierści: ");
                                    string siersc = Console.ReadLine();
                                    Console.WriteLine("Podaj ilość łap: ");
                                    int lapy = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Czy rasowy ? ");
                                    string rasowy = Console.ReadLine();
                                    Console.WriteLine("Poziom słodkości 0-10 ? ");
                                    int slodkosc = int.Parse(Console.ReadLine());
                                    psy.Add(new Ozdobne(id, nazwa, plec, wiek, wielkosc, siersc, lapy, rasowy, slodkosc));
                                    break;
                                }
                            case 10:
                                {
                                    Console.WriteLine("Podaj idetyfikator: ");
                                    int id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj nazwe: ");
                                    string nazwa = Console.ReadLine();
                                    Console.WriteLine("Podaj płeć: ");
                                    string plec = Console.ReadLine();
                                    Console.WriteLine("Podaj wiek: ");
                                    int wiek = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj wielkość (mały, średni, duży): ");
                                    string wielkosc = Console.ReadLine();
                                    Console.WriteLine("Podaj rodzaj sierści: ");
                                    string siersc = Console.ReadLine();
                                    Console.WriteLine("Podaj ilość łap: ");
                                    int lapy = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Czy rasowy ? ");
                                    string rasowy = Console.ReadLine();
                                    Console.WriteLine("Prędkość biegu 0-10 ? ");
                                    int predkoscbiegu = int.Parse(Console.ReadLine());
                                    psy.Add(new Charty(id, nazwa, plec, wiek, wielkosc, siersc, lapy, rasowy, predkoscbiegu));
                                    break;
                                }
                            case 11:
                                {
                                    Console.WriteLine("Podaj idetyfikator: ");
                                    int id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj nazwe: ");
                                    string nazwa = Console.ReadLine();
                                    Console.WriteLine("Podaj płeć: ");
                                    string plec = Console.ReadLine();
                                    Console.WriteLine("Podaj wiek: ");
                                    int wiek = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj wielkość (mały, średni, duży): ");
                                    string wielkosc = Console.ReadLine();
                                    Console.WriteLine("Podaj rodzaj sierści: ");
                                    string siersc = Console.ReadLine();
                                    Console.WriteLine("Podaj ilość łap: ");
                                    int lapy = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Czy rasowy ? ");
                                    string rasowy = Console.ReadLine();
                                    Console.WriteLine("Typ rasy ? ");
                                    string typ = Console.ReadLine();
                                    psy.Add(new Nieuznane(id, nazwa, plec, wiek, wielkosc, siersc, lapy, rasowy, typ));
                                    break;
                                }
                        }
                        break;
                }
                case 2:
                        Console.Clear();
                Console.WriteLine("Podaj ID przedmiotu który chcesz usunąć: ");
                int identyfikator = int.Parse(Console.ReadLine());
                foreach (Pies i in psy)
                {
                    if (i.ID == identyfikator)
                    {
                        psy.Remove(i);
                        Console.WriteLine("Usunąłem psa o ID = " + identyfikator);
                        break;
                    }
                }
                break;
            }
            case 3:
                        Console.Clear();
            Console.WriteLine("3. Wyświetlanie wszystkich zapamiętanych obiektów");
            foreach (Pies aPart in psy)
            {
                Console.WriteLine(aPart);
            }
            break;
        }
