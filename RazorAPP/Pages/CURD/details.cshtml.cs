using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorAPP.Models;

namespace RazorAPP.Pages.CURD
{
    public class detailsModel : PageModel
    {
        private IEmployeeRepository employeeRepository;
        public Employee e;
       public detailsModel(IEmployeeRepository _employeeRepository)
       {
            employeeRepository = _employeeRepository;
        }
        public void OnGet(int id)
        {
            this.e = employeeRepository.GetOneEmployee(id);

        }
        
        public void OnPost(Employee ep)
        {
             this.e = employeeRepository.GetOneEmployee(ep.Id);
            Response.Redirect("/index");

        }


    }
}
