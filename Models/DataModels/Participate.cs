using System;
using System.Collections.Generic;
using Activity = CSharpBelt.Models.Activity;
using System.ComponentModel.DataAnnotations;

namespace CSharpBelt.Models
{
    public class Participate
    {
        [Key]
        public int ParticipateId {get; set;}
        public int ActivityId {get; set;}
        public int UserId {get; set;}
        public Activity ParticipatingActivities {get; set;}
        
        public User ParticipatingUsers {get; set;}

    }
}