using System;
using SFinder.Domain.Core.Commands;
using SFinder.Domain.Core.Entities;
using SFinder.Domain.Core.Interfaces.Entities;
using SFinder.Domain.Core.Interfaces.Repository;

namespace SFinder.Domain.Core.CommandHandlers
{
    public class RegistrarNovoUsuarioCommandHandler : CommandHandler<IUsuarioRepository, Usuario>, ICommandHandler<RegistrarNovoUsuarioCommand>
    {
        public RegistrarNovoUsuarioCommandHandler(IUsuarioRepository repository) : base(repository)
        {
        }

        public void Handle(RegistrarNovoUsuarioCommand command)
        {
            Cadastro cadastro = new Cadastro(command.Senha);
            Usuario usuario = new Usuario(command.Nome, command.Sobrenome, command.Email, command.CPF, command.DataNascimento);

            usuario.CriarNovoCadastro(cadastro);

            var usuarioBase = _repositoryBase.ObtemPorCPF();
            if (usuario == null)
            {

            }

            //TODO: UoW
            _repositoryBase.Add(usuario);
            _repositoryBase.SaveChanges();
        }

    }
}
