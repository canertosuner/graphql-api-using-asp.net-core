using System;
using System.Collections.Generic;

namespace GraphQL_Sample.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> All()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Brain",
                    LastName = "Adams",
                    BirthDate = new DateTime(1985,11,20),
                    IsActive = true,
                    ZipCode = "11572"
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Joe",
                    LastName = "Colmun",
                    BirthDate = new DateTime(1991,1,14),
                    IsActive = true,
                    ZipCode = "22687"
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Lorena",
                    LastName = "McCarty",
                    BirthDate = new DateTime(1972,7,4),
                    IsActive = true,
                    ZipCode = "11572"
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Ivan",
                    LastName = "Lopez",
                    BirthDate = new DateTime(1990,2,9),
                    IsActive = true,
                    ZipCode = "56874"
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jason",
                    LastName = "Smith",
                    BirthDate = new DateTime(200,8,17),
                    IsActive = true,
                    ZipCode = "96314"
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Clain",
                    LastName = "Adams",
                    BirthDate = new DateTime(1986,5,5),
                    IsActive = true,
                    ZipCode = "11572"
                }
            };
        }
    }
}