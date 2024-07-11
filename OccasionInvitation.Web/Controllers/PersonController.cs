using MediatR;
using Microsoft.AspNetCore.Mvc;
using OccasionInvitation.Core.CQRS.Commands.RSVPCommandHandlers;
using OccasionInvitation.Core.CQRS.Commands.UpdatePersonCommandHandler;
using OccasionInvitation.Core.CQRS.Queries;
using OccasionInvitation.Models.DTOs;

namespace OccasionInvitation.Web.Controllers
{
    public class PersonController : Controller
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> RsvpToEvent()
        {
            return View("RsvpToEvent");
        }

        [HttpPost]
        public async Task<ActionResult> RsvpToEvent(PersonDTO person)
        {
            if (ModelState.IsValid)
            {
                var command = new RSVPCommand(person);
                await _mediator.Send(command);

                return View("ResponseView", command);
            }
            return View("RsvpToEvent");
        }

        [HttpGet]
        public async Task<ActionResult> UpdatePerson()
        {
            return View("UpdatePerson");
        }
        [HttpPost("{UpdatePerson}")]
        public async Task<IActionResult> UpdatePerson(int Id, PersonDTO personDTO)
        {
            var command = new UpdatePersonCommand(Id, personDTO);
            await _mediator.Send(command);
            return View("UpdatePerson", command);
        }

        //Get: home
        public async Task<IActionResult> GetUser(int userId)
        {
            var query = new GetUserQuery(userId);
            await _mediator.Send(query);

            return View(query);
        }
    }
}
