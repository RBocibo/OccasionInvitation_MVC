using MediatR;
using OccasionInvitation.Models.DTOs;
using OccasionInvitation.Services.PersonServices;

namespace OccasionInvitation.Core.CQRS.Queries
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, PersonDTO>
    {
        private readonly IPersonService _personService;

        public GetUserQueryHandler(IPersonService personService)
        {
            _personService = personService;
        }

        public async Task<PersonDTO> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _personService.UserDetails(request.UserId);

            return user;
        }
    }
}
