using FociProjekt.Entities;

namespace FociProjekt.Repos
{
    public interface IFociKlubokRepo
    {
        // A focistak repo egyéb metódusai
        int GetKlubokSzama();
        List<FociKlub> KivalasztOsszesFociKlubot();
    }
}
