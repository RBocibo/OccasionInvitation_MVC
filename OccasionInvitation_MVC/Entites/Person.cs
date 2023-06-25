using OccasionInvitation.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace OccasionInvitation.Domain.Entites
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required(ErrorMessage = "name is required.")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Select adult or child.")]
        public CheckAgeEnum isAdult { get; set; }
        [EmailAddress(ErrorMessage = "Enter proper email address.")]
        [Required]
        public string EmailAddress { get; set; } = null!;
        [Required(ErrorMessage = "Phone number is required.")]
        public string PhoneNumber { get; set; } = null!;
        [Required(ErrorMessage = "Select whether you will attend or not.")]
        public WillBeAttendingEnum WillAttend { get; set; }
        public bool IsDeleted { get; set; }
    }
}
