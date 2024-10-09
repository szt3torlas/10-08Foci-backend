namespace FociProjekt.Repos
{
    public interface IRepo<TEntity>  where TEntity : class
    {
        // interface -> előírja a szükséges metódusokat (property-ket is lehet)
        // <Tentity> -> generikus osztály, általánosan van megírva, minden repó csinálja ezek a metódusokat
        void Hozzad(TEntity entity);
        void Modosit(TEntity entity);
        void Torol(TEntity entity);
    }
}
