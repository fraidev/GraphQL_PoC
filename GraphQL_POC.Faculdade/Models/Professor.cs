using System;
using System.Collections.Generic;

namespace GraphQL_POC.Faculdade.Models
{
    public class Professor:IPessoa
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public IList<Materias> MateriasDeEnsino { get; set; }
    }
}