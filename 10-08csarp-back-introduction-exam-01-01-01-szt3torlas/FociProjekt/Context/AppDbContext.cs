using FociProjekt.Entities;

namespace FociProjekt.Context
{
    // AppDbContext az adattáblák tárolására
    public class AppDbContext
    {
        private List<Focista> _focistak;
        private List<FociKlub> _fociKlubok;

        public AppDbContext()
        {
            _focistak = new List<Focista>();
            _fociKlubok = new List<FociKlub>();            
        }

        public List<Focista> Focistak => _focistak; // get
        public List<FociKlub> FociKlubok => _fociKlubok;

    }
}
