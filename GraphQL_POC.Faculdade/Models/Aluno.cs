using System;
using System.Collections;
using System.Collections.Generic;

namespace GraphQL_POC.Faculdade.Models
{
    public class Aluno:IPessoa
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public IList<Materias> MateriasDeEstudo { get; set; }
    }
}