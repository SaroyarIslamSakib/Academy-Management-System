using AMS.Domain.Entities;
using Cortex.Mediator.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Application.Features.Students.Queries
{
    public class StudentGetQuery : IQuery<Student>
    {
        public Guid Id { get; set; }
    }
}
