using MediatR;
using OccasionInvitation.Models.DTOs;

namespace OccasionInvitation.Core.CQRS.Commands.RSVPCommandHandlers
{
    public class RSVPCommand : IRequest<PersonDTO>
    {
        public PersonDTO Model { get; set; }

        public RSVPCommand(PersonDTO model)
        {
            Model = model;
        }
    }
}
