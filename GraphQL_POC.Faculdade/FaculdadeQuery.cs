using System;
using GraphQL.Types;
using GraphQL_POC.Faculdade.Data;
using GraphQL_POC.Faculdade.Types;

namespace GraphQL_POC.Faculdade
{
    public class FaculdadeQuery: ObjectGraphType<object>
    {
        public FaculdadeQuery(FaculdadeData data)
        {
            {
                Name = "Query";

                Field<AlunoType>(
                    "aluno",
                    arguments: new QueryArguments(
                        new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "cpf", Description = "cpf do aluno" }
                    ),
                    resolve: context => data.GetAlunoByCpfAsync(context.GetArgument<string>("cpf"))
                );

                /*Func<ResolveFieldContext, string, object> func = (context, id) => data.GetProfessorByCpfAsync(id);

                FieldDelegate<ProfessorType>(
                    "droid",
                    arguments: new QueryArguments(
                        new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "cpf", Description = "cpf do professor" }
                    ),
                    resolve: func
                );*/
            }
        }
    }
}