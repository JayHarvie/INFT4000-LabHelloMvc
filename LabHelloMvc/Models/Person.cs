using System.ComponentModel.DataAnnotations;

namespace LabHelloMvc.Models
{
    public class Person
    {
        // Primary key
        public int PersonId { get; set; }

        [Display(Name = "First Name: ")]
        public string FirstName { get; set; } = string.Empty;
        
        [Display(Name = "Last Name: ")]
        public string LastName { get; set; } = string.Empty;
    }
}
