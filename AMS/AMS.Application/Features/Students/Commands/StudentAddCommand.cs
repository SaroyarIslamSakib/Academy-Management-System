using AMS.Domain.Entities;
using Cortex.Mediator.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Application.Features.Students.Commands
{
    public class StudentAddCommand : ICommand<Student>
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public Department? Department { get; set; }
        public Address? Address { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
