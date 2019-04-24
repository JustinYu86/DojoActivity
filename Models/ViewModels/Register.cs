using System;
using System.ComponentModel.DataAnnotations;
using Activity = CSharpBelt.Models.Activity;
namespace CSharpBelt.Models
{
    public class Register
    {
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password Must be minimum 8 characters long.")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [CompareAttribute("Password", ErrorMessage = "Passwords Must Match!")]
        public string Confirm { get; set; }
    }
}