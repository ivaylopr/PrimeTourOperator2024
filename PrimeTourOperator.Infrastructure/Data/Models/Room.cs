using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static PrimeTourOperator.Infrastructure.Constants.DataConstants;

namespace PrimeTourOperator.Infrastructure.Data.Models
{
    [Comment("Room class")]
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(RoomTitleMaxLength)]
        [Comment("Room title")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [Comment("Room category and description about it")]
        public int RoomCategoryId { get; set; }
        [Required]
        [ForeignKey(nameof(RoomCategoryId))]
        public RoomCategory RoomCategory { get; set; } = null!;
        [Required]
        [Comment("Room price")]
        public  decimal Price { get; set; }
        [MaxLength(RoomAddExtrasMaxLength)]
        [Comment("Additional room extras")]
        public string? AdditionalExtras { get; set; }
        [Required]
        public int Count { get; set; }
    }
}