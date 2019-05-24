namespace Tehnomanija
{
    internal class Poklon
    {
        public Poklon(int pozicija, string style, string vreme)
        {
            this.Pozicija = pozicija;
            this.Style = style;
            this.Vreme = vreme;
        }

        public int Pozicija { get; set; }
        public string Style { get; set; }
        public string Vreme { get; set; }
    }
}