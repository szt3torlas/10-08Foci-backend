using FociProjekt.Entities;

namespace FociProjekt.Repos
{
    public interface IFocistakRepo
    {
        // A focistak repo egyéb metódusai
        int GetFocistakSzama();
        List<Focista> KivalasztOsszesFocistat();
    }
}
