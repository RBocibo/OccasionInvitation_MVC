using MediatR;
using Microsoft.AspNetCore.Mvc;
using OccasionInvitation.Core.CQRS.Commands.RSVPCommandHandlers;
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
            var command = new RSVPCommand(person);
            await _mediator.Send(command);

            return View("ResponseView", command);
        }
    }
}
