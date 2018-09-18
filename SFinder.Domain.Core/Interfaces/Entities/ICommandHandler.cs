using SFinder.Domain.Core.Commands;

namespace SFinder.Domain.Core.Interfaces.Entities
{
    public interface ICommandHandler<TCommand> where TCommand : Command
    {
        void Handle(TCommand command);
    }
}
