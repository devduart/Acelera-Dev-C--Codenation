using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("company")]
    public class Company
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("name")]
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        
        [Column("slug")]
        [StringLength(50)]
        [Required]
        public string Slug { get; set; }
        
        [Column("created_at")]
        [Timestamp]
        [Required]
        public DateTime CreatedAt { get; set; }
        
        public List<Candidate> Candidates { get; set; }

    }
}