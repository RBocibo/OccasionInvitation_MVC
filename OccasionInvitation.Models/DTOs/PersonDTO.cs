using OccasionInvitation.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace OccasionInvitation.Models.DTOs
{
    public class PersonDTO
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Choose option please.")]
        public CheckAgeEnum isAdult { get; set; }
        [Required(ErrorMessage = "EmailAddress is required.")]
        [EmailAddress]
        public string EmailAddress { get; set; } = null!;
        [Required(ErrorMessage = "Phone number is required.")]
        public string PhoneNumber { get; set; } = null!;
        [Required(ErrorMessage = "Let us know your answer.")]
        public WillBeAttendingEnum WillAttend { get; set; }
    }
}
