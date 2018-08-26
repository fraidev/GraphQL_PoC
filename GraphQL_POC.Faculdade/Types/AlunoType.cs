using GraphQL.Types;
using GraphQL_POC.Faculdade.Data;
using GraphQL_POC.Faculdade.Models;

namespace GraphQL_POC.Faculdade.Types
{
    public class AlunoType : ObjectGraphType<Aluno>
    {
        public AlunoType(FaculdadeData data)
        {
            Name = "Aluno";

            Field(h => h.Cpf).Description("O CPF de um Aluno.");
            Field(h => h.Nome, nullable: true).Description("O Nome de um Aluno");
            /*Field(h => h.MateriasDeEstudo, nullable: true).Description("O Materias de um Aluno");*/
        }
    }
}