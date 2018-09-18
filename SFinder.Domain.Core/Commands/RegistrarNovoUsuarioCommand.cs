using SFinder.Domain.Core.Entities;
using SFinder.Domain.Core.Values_Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SFinder.Domain.Core.Commands
{
    public class RegistrarNovoUsuarioCommand : Command
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public Email Email { get; private set; }
        public Cpf CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }


        private Collection<Cadastro> _cadastros { get; set; }
        public IReadOnlyCollection<Cadastro> Cadastros { get { return _cadastros; } }
        public Senha Senha { get; set; }

        public RegistrarNovoUsuarioCommand(string nome, string sobrenome, Email email, Cpf cpf, DateTime dataNascimento, Senha senha)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Senha = senha;
        }


        public override bool IsValid()
        {
            // TODO: IsValid
            return true;
        }
    }
}
