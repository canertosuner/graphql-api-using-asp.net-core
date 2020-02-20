using GraphQL.Types;
using GraphQL_Sample.Repository;

namespace GraphQL_Sample.Schema
{
    public class CustomerType : ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id of the Customer");
            Field(x => x.FirstName);
            Field(x => x.LastName).Description("Customer's lastName");
            Field(x => x.BirthDate);
            Field(x => x.IsActive);
            Field(x => x.ZipCode);
        }
    }
}
