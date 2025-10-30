using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Domain.Entities
{
    public class Student : IAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public Department? Department { get; set; }
        public Address? Address { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
