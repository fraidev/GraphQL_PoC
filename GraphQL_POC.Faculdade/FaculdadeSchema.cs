using GraphQL;
using GraphQL.Types;

namespace GraphQL_POC.Faculdade
{
    public class FaculdadeSchema : Schema
    {
        public FaculdadeSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<FaculdadeQuery>();
            //Mutation = resolver.Resolve<StarWarsMutation>();
        }
    }
}