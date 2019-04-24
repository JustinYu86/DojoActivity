using System;
using System.Collections.Generic;
using Activity = CSharpBelt.Models.Activity;
using System.ComponentModel.DataAnnotations;

namespace CSharpBelt.Models
{
    public class Activity
    {
        [Key]
        public int ActivityId {get; set;}
        public string Title {get; set;}
        public DateTime Date {get; set;}
        public DateTime Time {get; set;}
        public int Duration {get; set;}
        public string Description {get; set;}
        public int UserId {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public User User { get; set; }
        public List<Participate> Participants {get; set;}
    }
}