using SFinder.Domain.Core.Entities;

namespace SFinder.Domain.Core.Interfaces.Repository
{
    public  interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        Usuario ObtemPorCPF();
    }
}
