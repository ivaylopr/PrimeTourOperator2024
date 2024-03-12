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
        [Required]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public VacationCategory VacationCategory { get; set; } = null!;
        [Required]
        [Comment("Vacation enrollment deadline")]
        public DateTime EnrollmentDeadline { get; set; }
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
        public int VacationCapacity { get; set; }
        public IList<VacationCustomer> VacationCustomers { get; set; } = new List<VacationCustomer>();

    }
}
