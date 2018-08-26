using System;

namespace GraphQL_POC.Faculdade.Models
{
    public interface IPessoa
    {
        string Cpf { get; set; }
        string Nome { get; set; }
    }
}