using AMS.Domain;
using AMS.Domain.Entities;
using AMS.Domain.Utilities;
using Cortex.Mediator.Commands;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Application.Features.Students.Commands
{
    public class StudentAddCommandHandler : ICommandHandler<StudentAddCommand, Student>
    {
        private readonly IApplicationUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public StudentAddCommandHandler(IApplicationUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Student> Handle(StudentAddCommand command, CancellationToken cancellationToken)
        {
            var student = _mapper.Map<Student>(command);
            student.Id = IdentityGenerator.NewSequentialGuid();

            await _unitOfWork.StudentRepository.AddAsync(student);
            await _unitOfWork.SaveAsync();
            return student;
        }
    }
}
