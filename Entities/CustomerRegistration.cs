using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Geekosphere_backend.Entities
{
    public class CustomerRegistration
    {

        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters")]
        public string? FirstName { get; set; }



        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters")]
        public string? LastName { get; set; }


        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters")]
        [Column("UserName")]
        public string? UserName { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string? ConfirmPassword { get; set; }

        [Required]
        public int Age { get; set; }
    }
}
