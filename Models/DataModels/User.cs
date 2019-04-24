using System;
using System.Collections.Generic;
using Activity = CSharpBelt.Models.Activity;
using System.ComponentModel.DataAnnotations;

namespace CSharpBelt.Models
{
    public class User
    {
        [Key]
        public int UserId {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
        public List<Activity> CreatedActivities {get; set;}
        public List<Participate> ParticipatingActivities {get; set;}
        public User(){}
        public User(Register user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            Password = user.Password;
        }

    }
}