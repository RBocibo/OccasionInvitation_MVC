using MediatR;
using OccasionInvitation.Models.DTOs;
using OccasionInvitation.Services.PersonServices;

namespace OccasionInvitation.Core.CQRS.Commands.RSVPCommandHandlers
{
    public class RSVPCommandHandler : IRequestHandler<RSVPCommand, PersonDTO>
    {
        private readonly IPersonService _personService;
        public RSVPCommandHandler(IPersonService personService)
        {
            _personService = personService;
        }

        public async Task<PersonDTO> Handle(RSVPCommand request, CancellationToken cancellationToken)
        {
            var command = await _personService.RSVPToEvent(request.Model);

            return command;
        }
    }
}
