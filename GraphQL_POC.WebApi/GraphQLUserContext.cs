using System.Security.Claims;

namespace GraphQL_POC.WebApi
{
    public class GraphQLUserContext
    {
        public ClaimsPrincipal User { get; set; }
    }
}