using SFinder.Domain.Core.Commands;
using SFinder.Domain.Core.Interfaces.Repository;

namespace SFinder.Domain.Core.CommandHandlers
{
    public abstract class CommandHandler<T, TEntity> where TEntity : class where T : IRepositoryBase<TEntity>
    {
        protected T _repositoryBase { get; private set; }
        public CommandHandler(T repository)
        {
            _repositoryBase = repository;
        }
    }
}
