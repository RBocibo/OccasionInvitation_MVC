using OccasionInvitation.Domain.Enums;

namespace OccasionInvitation.Models.DTOs
{
    public class PersonDTO
    {
        public string Name { get; set; } = null!;
        public CheckAgeEnum isAdult { get; set; }
        public string EmailAddress { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public WillBeAttendingEnum WillAttend { get; set; }
    }
}
