using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using RunGroopWebApp.Models;
namespace RunGroupWebApp.Models
{
    public class AppUser : IdentityUser
    {
        public int Pace { get; set; }
        public int? Mileage { get; set; }
        public Address? Adress { get; set; }
    }
}
