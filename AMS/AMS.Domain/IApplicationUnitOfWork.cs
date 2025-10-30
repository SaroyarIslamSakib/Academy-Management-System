using AMS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Domain
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        public IStudentRepository StudentRepository { get; }
    }
}
