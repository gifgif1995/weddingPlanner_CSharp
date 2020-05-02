using System;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Relation
    {
        [Key]
        public int RelationId { get; set; }
        public int WeddingId { get; set; }
        public Wedding Wedding { get; set; }
        public int UserId { get; set; }
        public User Guest { get; set; }
    }
}