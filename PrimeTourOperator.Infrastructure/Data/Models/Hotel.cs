using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static PrimeTourOperator.Infrastructure.Constants.DataConstants;

namespace PrimeTourOperator.Infrastructure.Data.Models
{
    [Comment("Hotel class")]
    public class Hotel
    {
        [Key]
        [Comment("Hotel identifier")]
        public int Id { get; set; }
        [Required]
        [MaxLength(HotelNameMaxLength)]
        [Comment("Hotel name")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Comment("Spa available")]
        public bool Spa { get; set; }
        [Required]
        [Comment("Pool available")]
        public bool Pool { get; set; }
        [Comment("All inclusive additional price to the room offer")]
        public decimal? AllInclusivePrice { get; set; }
        [Required]
        [Comment("Children animation available")]
        public bool ChildrenAnimators { get; set; }
        [Required]
        [MaxLength(HotelLocationMaxLength)]
        [Comment("Hotel location")]
        public string Location { get; set; } = string.Empty;
        [Required]
        public int Capacity { get; set; }
        [Required]
        public int CategoryStars { get; set; }
        public IEnumerable<Room> Rooms { get; set; } = new List<Room>();
        public IList<HotelVacation> HotelVacations { get; set; } = new List<HotelVacation>();
    }
}
