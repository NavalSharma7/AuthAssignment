using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace AuthAssignment.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Key]
        public string UserID { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
    }
}
