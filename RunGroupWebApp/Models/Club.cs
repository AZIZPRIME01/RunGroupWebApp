<<<<<<< HEAD
﻿﻿using RunGroupWebApp.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RunGroupWebApp.Models
{
    public class Club
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        [ForeignKey("Address")]
        public int? AddressId { get; set; }
        public Address? Address { get; set; }
        public ClubCategory ClubCategory { get; set; }
        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
=======
﻿namespace RunGroupWebApp.Models
{
    public class Club
    {
>>>>>>> b95f9f35eed4ec06c78acb4fba88c2ad1df0537b
    }
}
