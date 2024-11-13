using System.ComponentModel.DataAnnotations.Schema;

namespace RazorAPP.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Dept? Department { get; set; }
        public byte[] photo { get; set; }
        [NotMapped]
        public IFormFile FilePath { get; set; }


    }
}
