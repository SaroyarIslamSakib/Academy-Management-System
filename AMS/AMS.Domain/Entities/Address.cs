using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Domain.Entities
{
    public  class Address
    {
        public Guid Id { get; set; }
        public string? CurrentAddress { get; set; }
        public string? PermanentAddress { get; set; }
    }
}
