using System.Diagnostics;
using AMS.Domain;
using AMS.Web.Models;
using Microsoft.AspNetCore.Mvc;
using AMS.Infrastructure;
using AMS.Domain.Repositories;
using AMS.Infrastructure.Repositories;
using AMS.Domain.Entities;



namespace AMS.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IApplicationUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IApplicationUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            _unitOfWork.StudentRepository.Add(new Student
            {
                Id = Guid.NewGuid(),
                Name = "John Doe",
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
            });
            _unitOfWork.Save();
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
