using OccasionInvitation.Models.DTOs;

namespace OccasionInvitation.Services.PersonServices
{
    public interface IPersonService
    {
        Task<PersonDTO> RSVPToEvent(PersonDTO personDTO);
    }
}
