using AMS.Domain.Entities;
using AMS.Domain.Repositories;
using AMS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Infrastructure.Repositories
{
    public class StudentRepository : Repository<Student, Guid> , IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
