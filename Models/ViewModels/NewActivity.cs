using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Activity = CSharpBelt.Models.Activity;
namespace CSharpBelt.Models
{
    public class NewActivity
    {
        [Required]
        [MinLength(2, ErrorMessage="Title must be at least 2 characters")]
        [Display(Name = "Title")]
        public string Title {get; set;}


        [Required]
        [Display(Name = "Date")]
        [CheckDate]
        [DataType(DataType.Date)]
        public DateTime Date {get; set;}


        [Required]
        [Display(Name = "Time")]
        [DataType(DataType.Time)]
        [RegularExpression(@"\b((1[0-2]|0?[1-9]):([0-5][0-9]) ([AaPp][Mm]))", ErrorMessage="Please make sure your time is chosen hh/mm AM or PM")]
        public DateTime Time {get; set;}


        [Required]
        [Display(Name = "Duration:")]
        [DataType(DataType.Duration)]
        [RegularExpression(@"^[+]?\d+([.]\d+)?$", ErrorMessage = "Only positive numbers allowed")]
        public int Duration {get; set;}


        [Required]
        [MinLength(10, ErrorMessage= "Description must be at leat 10 characters long")]
        public string Description {get; set;}

    }
}