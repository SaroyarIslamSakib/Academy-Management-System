using System.Diagnostics;
using AMS.Domain;
using AMS.Web.Models;
using Microsoft.AspNetCore.Mvc;
using AMS.Infrastructure;
using AMS.Domain.Repositories;
using AMS.Infrastructure.Repositories;
using AMS.Domain.Entities;
using Cortex.Mediator;
using AMS.Application.Features.Students.Commands;
using AMS.Application.Features.Students.Queries;



namespace AMS.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var command = new StudentAddCommand
            {
                Name = "Md Sakib Hasan",
                Email = "sisakib232@gmail.com",
                DateOfBirth = new DateTime(2000,06, 25),
                Department = new Department
                {
                    Id = Guid.NewGuid(),
                    Name = "CSE"
                },
                Address = new Address
                {
                    Id = Guid.NewGuid(),
                    CurrentAddress = "123 Main St, Cityville",
                    PermanentAddress = "456 Elm St, Townsville"
                }
            };
            var student = await _mediator.SendCommandAsync<StudentAddCommand, Student>(command);

            var query = new StudentGetQuery { Id = new Guid("4731af4b-8f4e-40ed-9323-d8b8e11bcca7") };
            var result = await _mediator.SendQueryAsync<StudentGetQuery, Student>(query);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
