using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Geekosphere_backend.Entities
{

    [Table("Customer")]
    public class Customer: IdentityUser

    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters")]
        [Column("FirstName")]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters")]
        [Column("Name")]
        public string? LastName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters")]
        [Column("UserName")]
         override public string? UserName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [Column("Email")]
        [EmailAddress]
         override public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Column("Password")]
        public string? Password { get; set; }

      
        [Required]
        [Column("Age")]
        public int Age { get; set; }


    }
}
