using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvc2.introduction.Entities;
using AspNetCoreMvc2.introduction.Model;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc2.introduction.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Merhabalar başkan...";
        }
        public ViewResult Index2()
        {
            return View();
        }
        public ViewResult Index3()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirstName="Berkay",LastName="Şirin",CityId=6},
                new Employee{Id=1,FirstName="Kadir",LastName="Köse",CityId=2},
                new Employee{Id=1,FirstName="Yusuf",LastName="Karataş",CityId=1}
            };
            
            List<string> cities = new List<string> { "İstanbul",   "Ankara" };
            var employeeListViewModel = new EmployeeListViewModel
            {

                Employees = employees,
                Cities=cities

            };
            return View(employeeListViewModel);

        }

        public StatusCodeResult Index4()
        {
            return Ok();
        }
        public StatusCodeResult Index5()
        {
            return NotFound();
        }

        public RedirectResult Index6()
        {
            return Redirect("/Home/Index3");
        }
        public IActionResult Index7()
        {
            return RedirectToAction("Index2");
        }
        public IActionResult Index8()
        {
            return RedirectToRoute("default");
        }

        public JsonResult Index9()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirstName="Berkay",LastName="Şirin",CityId=6},
                new Employee{Id=1,FirstName="Kadir",LastName="Köse",CityId=2},
                new Employee{Id=1,FirstName="Yusuf",LastName="Karataş",CityId=1}
            };
            return Json(employees);
        }
        public IActionResult RazorDemo()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirstName="Berkay",LastName="Şirin",CityId=6},
                new Employee{Id=1,FirstName="Kadir",LastName="Köse",CityId=2},
                new Employee{Id=1,FirstName="Yusuf",LastName="Karataş",CityId=1}
            };

            List<string> cities = new List<string> { "İstanbul", "Ankara" };
            var employeeListViewModel = new EmployeeListViewModel
            {

                Employees = employees,
                Cities = cities

            };
            return View(employeeListViewModel);
           
        }
    }
}

//http://berkaysirin@gmail.com/home/index
//HomeController h=new HomeController();
//h.Index();