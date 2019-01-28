using System.Collections.Generic;
using AspNetCoreMvc2.introduction.Entities;

namespace AspNetCoreMvc2.introduction.Model
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<string> Cities { get; set; }
    }
}