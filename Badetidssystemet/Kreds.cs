using System;
namespace Badetidssystemet
{
    public class Kreds
    {
        string _id;
        string _navn;
        string _adresse;
        int number;
        int _antalDeltagere;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }


        public int AntalDeltagere
        {
            get { return _antalDeltagere; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Antal deltagere cannot be zero");
                _antalDeltagere = value;
            }
        }

        public Kreds(string ID, string Navn, string Adresse, int AntalDeltagere)
        {
            _id = ID;
            _navn = Navn;
            _adresse = Adresse;
            this.AntalDeltagere = AntalDeltagere;
        }

        public override string ToString()
        {
            return $"ID: {ID} - Navn: {Navn} - Adresse: {Adresse} - Antal Deltagere: {AntalDeltagere}";
        }
    }
}
