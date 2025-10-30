using AMS.Domain;
using AMS.Domain.Repositories;
using AMS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Infrastructure
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public IStudentRepository StudentRepository { get; private set; }
        public ApplicationUnitOfWork(ApplicationDbContext context, IStudentRepository studentRepository) : base(context)
        {
            StudentRepository = studentRepository;
        }
    }
}
