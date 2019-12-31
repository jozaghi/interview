using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.OOP.Prototype
{
    public class Address
    {
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string PostalCode { get; set; }
    }
    public class Person : ICloneable
    {
        public Address BusinessAddress { get; set; }
        public Address HomeAddress { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public int Id { get; set; }
        public Person()
        {
        }
        public object Clone() =>
            new Person
            {
                Email = this.Email,
                FullName = this.FullName,
                Id = this.Id,
                BusinessAddress = this.BusinessAddress == null ? null : new Address
                {
                    Street1 = this.BusinessAddress.Street1,
                    Street2 = this.BusinessAddress.Street2,
                    PostalCode = this.BusinessAddress.PostalCode
                },
                HomeAddress = this.HomeAddress == null ? null : new Address
                {
                    Street1 = this.HomeAddress.Street1,
                    Street2 = this.HomeAddress.Street2,
                    PostalCode = this.HomeAddress.PostalCode
                }
            };

    }

    public class Consumer
    {
        public Consumer()
        {
            var person = new Person();
            var person2 = person.Clone();
        }
    }
}
