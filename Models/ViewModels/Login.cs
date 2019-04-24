using System.ComponentModel.DataAnnotations;
using Activity = CSharpBelt.Models.Activity;
namespace CSharpBelt.Models
{
    public class Login
    {
        [Required(ErrorMessage = "An Email is required")]
        [EmailAddress(ErrorMessage = "A Valid Email is required")]
        [Display(Name = "Email")]
        public string LoginEmail { get; set; }
        [Required(ErrorMessage = "A Password is Required")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password Must be 8 characters or longer!")]
        [Display(Name = "Password")]
        public string LoginPassword { get; set; }
    }
    
}