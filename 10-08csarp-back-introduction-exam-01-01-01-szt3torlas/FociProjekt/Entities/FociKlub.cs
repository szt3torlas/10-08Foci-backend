namespace FociProjekt.Entities
{
    public class FociKlub
    {
        public DateTime AlapitasiIdo { get; set; }
        public string Nev { get; set; }
        public double Koltsegvetes { get; set; }
        public List<Focista> Focistak { get; set; }
        public List<Edzo> Edzok { get; set; } 

        public FociKlub(DateTime alapitasiIdo,
            string nev, double koltsegvetes) /// + Focistak, Edzok ???
        {
            AlapitasiIdo = alapitasiIdo;
            Nev = nev;
            Koltsegvetes = koltsegvetes;
            Focistak = new List<Focista>();
            Edzok = new List<Edzo>();
        }
    }
}
