using System.ComponentModel.DataAnnotations;

namespace RazorApp.Models
{
   
        public class Employee
        {
            [Required(ErrorMessage ="Id is required")]
            public int? Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(0,9999,ErrorMessage ="Salary Must be in range 0 to 9999")]
        public float? Salary { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        }
    
}
