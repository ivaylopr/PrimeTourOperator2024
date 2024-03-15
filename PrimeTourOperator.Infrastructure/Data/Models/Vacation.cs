using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static PrimeTourOperator.Infrastructure.Constants.DataConstants;

namespace PrimeTourOperator.Infrastructure.Data.Models
{
    [Comment("Vacation class")]
    public class Vacation
    {
        [Key]
        [Comment("Vacation identifier")]
        public int Id { get; set; }
        [Required]
        [MaxLength(VacationTitleMaxLength)]
        [Comment("Vacation Title")]
        public string Title { get; set; } = string.Empty;
        [Comment("Is all inclusive option added to the vacation")]
        public bool? AllInclusive { get; set; }
        public decimal? Price { get; set; }
        [Required]
        public int VacationCategoryId { get; set; }
        [ForeignKey(nameof(VacationCategoryId))]
        public VacationCategory VacationCategory { get; set; } = null!;
        [Comment("Vacation enrollment deadline")]
        public DateTime? EnrollmentDeadline { get; set; }
        [Required]
        [Comment("Vacation start date")]
        public DateTime StartDate { get; set; }
        [Required]
        [Comment("Vacation end date/leaving")]
        public DateTime EndDate { get; set; }
        [Required]
        [MaxLength(VacationDescriptionMaxLength)]
        [Comment("Vacation description")]
        public string Description { get; set; } = string.Empty;
        [Required]
        [MaxLength(VacationLocationMaxLength)]
        [Comment("Location of the vacation")]
        public string Location { get; set; } = string.Empty;
        [Required]
        [Comment("Agent who is responsive for the vacation")]
        public int AgentId { get; set; }
        
        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;
        [Required]
        [Comment("Hotel identifier of the holiday")]
        public int HotelId { get; set; }
        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; } = null!;
        [Required]
        [Comment("Room for the vacation")]
        public int RoomId { get; set; }
        [Required]
        [ForeignKey(nameof(RoomId))]
        public Room Room { get; set; } = null!;
        public IList<VacationCustomer> VacationCustomers { get; set; } = new List<VacationCustomer>();

    }
}
