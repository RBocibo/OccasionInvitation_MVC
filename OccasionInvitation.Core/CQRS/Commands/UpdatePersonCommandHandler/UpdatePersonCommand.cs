using MediatR;
using OccasionInvitation.Models.DTOs;

namespace OccasionInvitation.Core.CQRS.Commands.UpdatePersonCommandHandler
{
    public class UpdatePersonCommand : IRequest<PersonDTO>
    {
        public int Id { get; set; }
        public PersonDTO Model { get; set; }

        public UpdatePersonCommand(int id, PersonDTO model)
        {
            Id = id;
            Model = model;
        }

    }
}
