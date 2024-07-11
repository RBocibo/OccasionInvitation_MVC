using AutoMapper;
using OccasionInvitation.Domain.Entites;
using OccasionInvitation.Infrastructure.DatabaseContext;
using OccasionInvitation.Models.DTOs;
using System.Data.Entity;

namespace OccasionInvitation.Services.PersonServices
{
    public class PersonService : IPersonService
    {
        private readonly OccasionInvitationDbContext _dbContext = new OccasionInvitationDbContext();

        private readonly IMapper _mapper;

        public PersonService(IMapper mapper)
        {
            _mapper = mapper;
        }

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

        public async Task<PersonDTO> UpdateUser(int id, PersonDTO personDTO)
        {
            var getPerson = await _dbContext.People.FindAsync(id);

            if (getPerson != null) 
            {
                getPerson.Name = personDTO.Name;
                getPerson.WillAttend = personDTO.WillAttend;
                getPerson.isAdult = personDTO.isAdult;
                getPerson.PhoneNumber = personDTO.PhoneNumber;

                await _dbContext.SaveChangesAsync();
            }

            return personDTO;
        }

        public async Task<PersonDTO> UserDetails(int userId)
        {
            var getUserToUpdate = await _dbContext.People.FirstOrDefaultAsync(x => x.PersonId == userId);

            if (getUserToUpdate != null)
            {
                return null;

            }

            return _mapper.Map<PersonDTO>(getUserToUpdate);
        }
    }
}
