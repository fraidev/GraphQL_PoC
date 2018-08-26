using GraphQL.Types;
using GraphQL_POC.Faculdade.Data;
using GraphQL_POC.Faculdade.Models;

namespace GraphQL_POC.Faculdade.Types
{
    public class ProfessorType: ObjectGraphType<Professor>
    {
        public ProfessorType(FaculdadeData data)
        {
            Name = "Professor";

            Field(h => h.Cpf).Description("O CPF de um Professor.");
            Field(h => h.Nome, nullable: true).Description("O Nome de um Professor");
        }
    }
}