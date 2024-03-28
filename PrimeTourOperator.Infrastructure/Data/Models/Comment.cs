using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static PrimeTourOperator.Infrastructure.Constants.DataConstants;

namespace PrimeTourOperator.Infrastructure.Data.Models
{
    [Comment("Class for comments and reviews by the users")]
    public class Comment
    {
        [Key]
        [Comment("Comment identifier")]
        public int Id { get; set; }
        [Required]
        [MaxLength(CommentReviewMaxLength)]
        [Comment("Review for the hotel")]
        public string Review { get; set; } = string.Empty;
        [Required]
        [Comment("User who give the review")]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
        public int? Rating { get; set; }
    }
}
