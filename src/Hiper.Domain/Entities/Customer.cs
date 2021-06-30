using Hiper.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace Hiper.Domain.Entities
{
    /// <summary>
    /// Classe para representação do Cliente
    /// </summary>
    public class Customer : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public Phone Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public Customer()
        {
            Id = Guid.NewGuid();
            Orders = new List<Order>();
        }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Orders = new List<Order>();
        }

        public Customer(string firstName, string lastName, List<Order> orders)
        {
            FirstName = firstName;
            LastName = lastName;
            Orders = orders;
        }

        public Customer(Guid id,string firstName, string lastName, List<Order> orders)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Orders = orders;
        }

        public override string ToString()
            => $"{FirstName} {LastName}";
    }
}
