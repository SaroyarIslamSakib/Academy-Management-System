using AMS.Domain;
using AMS.Domain.Entities;
using Cortex.Mediator.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Application.Features.Students.Queries
{
    public class StudentGetQueryHandler : IQueryHandler<StudentGetQuery, Student>
    {
        private readonly IApplicationUnitOfWork _unitOfWork;
        public StudentGetQueryHandler(IApplicationUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Student> Handle(StudentGetQuery query, CancellationToken cancellationToken)
        {
            return await _unitOfWork.StudentRepository.GetByIdAsync(query.Id);
        }
    }
}
