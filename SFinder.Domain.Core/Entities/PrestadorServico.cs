using System;
using SFinder.Domain.Core.Values_Objects;

namespace SFinder.Domain.Core.Entities
{
    public class PrestadorServico : Usuario
    {
        public PrestadorServico(string nome, string sobrenome, Email email, Cpf cpf, DateTime dataNascimento)
            : base(nome, sobrenome, email, cpf, dataNascimento)
        {
        }
    }
}
