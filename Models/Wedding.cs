using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }

        [Required]
        [Display(Name = "Wedder One")]
        public string WedderOne { get; set; }

        [Required]
        [Display(Name = "Wedder Two")]
        public string WedderTwo { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DateFuture(ErrorMessage = "The date of the Wedding should be in the future")]
        public DateTime Ceremony { get; set; }

        [Required]
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public User Planner { get; set; }
        public List<Relation> Guests { get; set; }
    }
}