using SFinder.Domain.Core.Interfaces.Entities;
using SFinder.Domain.Core.Values_Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SFinder.Domain.Core.Entities
{
    public class Usuario : IUser
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public Email Email { get; private set; }
        public Cpf CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }

        private Collection<Cadastro> _cadastros { get; set; }
        public IReadOnlyCollection<Cadastro> Cadastros { get { return _cadastros; } }

        public Usuario(string nome, string sobrenome, Email email, Cpf cpf, DateTime dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }

        public bool TemCadastroAtivo()
        {
            var retorno = Cadastros.Any(x => x.Ativo);
            return retorno;
        }

        public void CriarNovoCadastro(Cadastro cadastro)
        {
            if (!TemCadastroAtivo())
                _cadastros.Add(cadastro);
        }

        public void Rate(Rating rating)
        {
            // TODO: Rate
            throw new NotImplementedException();
        }
    }
}
