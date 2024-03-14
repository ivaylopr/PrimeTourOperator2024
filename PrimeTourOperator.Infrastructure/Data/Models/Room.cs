using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
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
        [MaxLength(RoomDescriptionMaxLenght)]
        [Comment("Room description")]
        public string? Description { get; set; }
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