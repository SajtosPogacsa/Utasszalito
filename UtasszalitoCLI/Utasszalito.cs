
namespace UtasszalitoCLI
{
    internal class Utasszalito
    {
        public string tipus;
        public int ev;
        public string szemelyzet;
        public int utasMin;
        public int utasMax;
        public int sebesseg;
        public int tomeg;
        public double fesztav;

        public Utasszalito(string tipus, int ev, string szemelyzet, int utasMin, int utasMax, int sebesseg, int tomeg, double fesztav)
        {
            this.tipus = tipus;
            this.ev = ev;
            this.szemelyzet = szemelyzet;
            this.utasMin = utasMin;
            this.utasMax = utasMax;
            this.sebesseg = sebesseg;
            this.tomeg = tomeg;
            this.fesztav = fesztav;
        }
    }
}
