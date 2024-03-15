using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static PrimeTourOperator.Infrastructure.Constants.DataConstants;

namespace PrimeTourOperator.Infrastructure.Data.Models
{
    [Comment("Room category type")]
    public class RoomCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(RoomCategoryNameMaxLength)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [MaxLength(RoomDescriptionMaxLenght)]
        public string Description { get; set; } = string.Empty;
    }
}
