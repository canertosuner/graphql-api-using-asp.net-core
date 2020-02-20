using System;
using System.Linq;
using GraphQL.Types;
using GraphQL_Sample.Repository;

namespace GraphQL_Sample.Schema
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(ICustomerRepository customerRepository)
        {
            Field<ListGraphType<CustomerType>>("customers", resolve: context => customerRepository.All());

            Field<ListGraphType<CustomerType>>("filterCustomers",
                arguments: new QueryArguments
                {
                    new  QueryArgument<StringGraphType> { Name = "firstName"},
                    new  QueryArgument<StringGraphType> { Name = "lastName"},
                    new  QueryArgument<BooleanGraphType> { Name = "isActive"},
                    new  QueryArgument<DateGraphType> { Name = "birthDate"},

                },
                resolve: context =>
                  {
                      var firstName = context.GetArgument<string>("firstName");
                      var lastName = context.GetArgument<string>("lastName");
                      var isActive = context.GetArgument<bool>("isActive");

                      return customerRepository.All().Where(x => x.FirstName.ToLower() == firstName.ToLower() && 
                                                                 x.LastName.ToLower() == lastName.ToLower() && 
                                                                 x.IsActive == isActive).ToList();
                  });
        }
    }
}