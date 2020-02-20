using System.Collections.Generic;

namespace GraphQL_Sample.Repository
{
    public interface ICustomerRepository
    {
        List<Customer> All();
    }
}
