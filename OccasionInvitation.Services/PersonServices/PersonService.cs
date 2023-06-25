using OccasionInvitation.Domain.Entites;
using OccasionInvitation.Infrastructure.DatabaseContext;
using OccasionInvitation.Models.DTOs;

namespace OccasionInvitation.Services.PersonServices
{
    public class PersonService : IPersonService
    {
        private readonly OccasionInvitationDbContext _dbContext = new OccasionInvitationDbContext();
        public async Task<PersonDTO> RSVPToEvent(PersonDTO personDTO)
        {
            var addPerson = new Person()
            {
                Name = personDTO.Name,
                isAdult = personDTO.isAdult,
                EmailAddress = personDTO.EmailAddress,
                PhoneNumber = personDTO.PhoneNumber,
                WillAttend = personDTO.WillAttend,
                IsDeleted = false,
            };

            _dbContext.People.Add(addPerson);
            await _dbContext.SaveChangesAsync();

            return personDTO;
        }
    }
}
