using System.Collections.Generic;
using Activity = CSharpBelt.Models.Activity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpBelt.Models
{
    public class Dashboard
    {
        [NotMapped]
        public User User { get; set; }
        [NotMapped]
        public List<Activity> allActivities { get; set; }
    }
}