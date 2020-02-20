using GraphQL;
using GraphQL.Types;

namespace GraphQL_Sample.Schema
{
    public class AppSchema : GraphQL.Types.Schema, ISchema
    {
        public AppSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<AppQuery>();
        }
    }
}