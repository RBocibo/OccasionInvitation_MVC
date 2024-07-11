using OccasionInvitation.Models.DTOs;

namespace OccasionInvitation.Services.PersonServices
{
    public interface IPersonService
    {
        Task<PersonDTO> RSVPToEvent(PersonDTO personDTO);
        Task<PersonDTO> UpdateUser(int id, PersonDTO personDTO);
        Task<PersonDTO> UserDetails(int userId);
    }
}
