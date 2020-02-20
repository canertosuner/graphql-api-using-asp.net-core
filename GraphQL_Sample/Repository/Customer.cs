using System;

namespace GraphQL_Sample.Repository
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string ZipCode { get; set; }
        public bool IsActive { get; set; }
    }
}
