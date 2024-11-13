using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorAPP.Models;
using RazorAPP.Models;

namespace RazorAPP.Pages
{
    public class IndexModel : PageModel
    {

        private IEmployeeRepository employeeRepository;
        public IEnumerable<Employee> e;
      public IndexModel(IEmployeeRepository _employeeRepository)
     {
            employeeRepository = _employeeRepository;
     }

        public void OnGet()
        {

            this.e = employeeRepository.GetAllEmployees();

            ViewData["Rows"] = "2";
            ViewData["Columns"] = "4";

        }

    }

}

