using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThompsonRazorPagesAzure.Models
{
    public class UserPreferences
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [Range(1, 120)]
        public int Age { get; set; }
        [Display(Name = "Favorite Book")]
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string FavBook { get; set; }
        [Display(Name = "Favorite Movie")]
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string FavMovie { get; set; }
        [Display(Name = "Favorite Genre")]
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string FavGenre { get; set; }
        [Display(Name = "Worst Genre")]
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string WorstGenre { get; set; }
    }
}
