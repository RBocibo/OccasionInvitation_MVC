using MediatR;
using OccasionInvitation.Models.DTOs;
using OccasionInvitation.Services.PersonServices;

namespace OccasionInvitation.Core.CQRS.Commands.UpdatePersonCommandHandler
{
    public class UpdatePersonCommandHandler : IRequestHandler<UpdatePersonCommand, PersonDTO>
    {
        private readonly IPersonService _personService;

        public UpdatePersonCommandHandler(IPersonService personService)
        {
            _personService = personService;
        }

        public async Task<PersonDTO> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            var command = await _personService.UpdateUser(request.Id,request.Model);

            return command;
        }
    }
}
