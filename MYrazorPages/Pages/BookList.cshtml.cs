using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PercistanceLayer.DAL.EfCore;
using PercistanceLayer.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MYrazorPages.Pages
{
    public class BookListModel : PageModel
    {
        public List<Employee> EmployeeList { get; set; } 
        public void OnGet()
        {
            var employeedal = new EfEmployeeDal();
            EmployeeList = employeedal.GetAll().ToList();
        }
    }
}
