using FociProjekt.Context;
using FociProjekt.Entities;
using FociProjekt.Repos;

namespace FociProjekt.Repos
{
    public class FociKlubokRepo<TEntity> : IFociKlubokRepo where TEntity : FociKlub
    {
        // Kapcsolat a Context és a Repo réteg között
        private AppDbContext _appDbContext;
        public FociKlubokRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public int GetKlubokSzama()
        {
            return _appDbContext.FociKlubok.Count;
        }
        public void Hozzaad(TEntity entity) 
        {
            _appDbContext.FociKlubok.Add(entity);
        }

        public List<FociKlub> KivalasztOsszesFociKlubot()
        {
           return _appDbContext.FociKlubok;
        }
        public void Modosit(TEntity entity)
        {
            FociKlub? modositandoFociKlub = _appDbContext.FociKlubok.Find(fociklub => fociklub.Nev == entity.Nev);
            if (modositandoFociKlub is not null)
            {
                
                modositandoFociKlub.AlapitasiIdo = entity.AlapitasiIdo;
                modositandoFociKlub.Nev = entity.Nev;
                modositandoFociKlub.Koltsegvetes = entity.Koltsegvetes;
                /// unnaccessible due to its protection level -> FociKlubb.cs-ben kijavítva
                modositandoFociKlub.Focistak = entity.Focistak;
                modositandoFociKlub.Edzok = entity.Edzok;
                
            }
        }
        public void Torol(TEntity entity)
        {
            _appDbContext.FociKlubok.Remove(entity);
        }
        ///dfg 
    }

}
