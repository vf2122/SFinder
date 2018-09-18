using System;
using SFinder.Domain.Core.Entities;
using SFinder.Domain.Core.Values_Objects;

namespace PhotoFind.Domain.Entities
{
    public class Fotografo : PrestadorServico
    {
        public Fotografo(string nome, string sobrenome, Email email, Cpf cpf, DateTime dataNascimento)
            : base(nome, sobrenome, email, cpf, dataNascimento)
        {
        }
    }
}
