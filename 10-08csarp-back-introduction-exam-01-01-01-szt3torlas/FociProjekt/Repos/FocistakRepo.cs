using FociProjekt.Context;
using FociProjekt.Entities;

namespace FociProjekt.Repos
{
    // A repo feladata egy adattábla kezelése
    // FocistaRepo az IRepo és IFocistaRepo interfacek metódusait valósítja meg
    // Az IRepo egy entity kezel, ami itt a Focista

    // IFocistak repótól is öröklődik
    public class FocistakRepo<TEntity> : IRepo<TEntity>, IFocistakRepo where TEntity : Focista
    {
        // Kapcsolat a Context és a Repo réteg között
        // Repo létrehozásakor megkapja a Repo a Context-et
        // Így a repo eléri a Focista táblát az adatbázisban

        private AppDbContext _appDbContext;
        public FocistakRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public int GetFocistakSzama()
        {
            return _appDbContext.Focistak.Count;
        }

        public void Hozzad(TEntity entity)
        {
            _appDbContext.Focistak.Add(entity);   
        }

        public List<Focista> KivalasztOsszesFocistat() 
        {
            return _appDbContext.Focistak;
        }

        public void Modosit(TEntity entity)
        {
            Focista? modositandoFocista = _appDbContext.Focistak.Find(focista => focista.Nev==entity.Nev);
            if (modositandoFocista is not null)
            {
                modositandoFocista.Suly = entity.Suly;
                modositandoFocista.JobbLabas = entity.JobbLabas;
                modositandoFocista.Mezszam = entity.Mezszam;
                modositandoFocista.Magassag = entity.Magassag;
            }
        }

        public void Torol(TEntity entity)
        {
            _appDbContext.Focistak.Remove(entity);
        }
    }
}
