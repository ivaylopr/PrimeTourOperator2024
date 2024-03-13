﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static PrimeTourOperator.Infrastructure.Constants.DataConstants;
namespace PrimeTourOperator.Infrastructure.Data.Models
{
    [Comment("Season job class")]
    public class SeasonalEmployment
    {
        [Key]
        [Comment("Identifier")]
        public int Id { get; set; }
        [Required]
        [MaxLength(SeasonEmploymentTitleMaxLength)]
        [Comment("Job title")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MaxLength(SeasonEmploumentDescriptionMaxLength)]
        [Comment("Job description")]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Comment("Payment per hour")]
        public decimal HourlyWage { get; set; }
        [Required]
        [Comment("Data for starting job")]
        public DateTime StartDate { get; set; }
        [Required]
        [Comment("End date for the job")]
        public DateTime EndDate { get; set; }
        [Required]
        [Comment("Agent resposive for the offer")]
        public string AgentId { get; set; } = string.Empty;
        [ForeignKey(nameof(AgentId))]
        public ApplicationUser Agent { get; set; } = null!;
        [Required]
        [Comment("Hotel who is offering the season job")]
        public int HotelId { get; set; }
        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; } = null!;
        [Comment("Users who is applyed the offer")]
        public IEnumerable<ApplicationUser> Applayers { get; set; } = new List<ApplicationUser>();
    }
}
