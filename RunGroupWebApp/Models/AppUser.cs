<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using RunGroopWebApp.Models;
namespace RunGroupWebApp.Models
{
    public class AppUser : IdentityUser
=======
﻿namespace RunGroupWebApp.Models
{
    public class AppUser
>>>>>>> b95f9f35eed4ec06c78acb4fba88c2ad1df0537b
    {
        public int Pace { get; set; }
        public int? Mileage { get; set; }
        public Address? Adress { get; set; }
    }
}
