using SFinder.Domain.Core.Interfaces.Entities;
using SFinder.Domain.Core.Values_Objects;
using System;

namespace SFinder.Domain.Core.Entities
{
    public class Cadastro : ICadastro
    {
        public int Id { get; private set; }
        public Senha Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataExclusao { get; private set; }
        public bool Ativo { get; private set; }

        public Cadastro(Senha senha)
        {
            Senha = senha;
            DataCadastro = DateTime.Now;
            Ativo = true;
        }

        public void InativarCadastro()
        {
            DataExclusao = DateTime.Now;
            Ativo = false;
        }
    }
}