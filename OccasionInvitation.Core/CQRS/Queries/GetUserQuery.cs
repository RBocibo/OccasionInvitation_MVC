using MediatR;
using OccasionInvitation.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccasionInvitation.Core.CQRS.Queries
{
    public class GetUserQuery : IRequest<PersonDTO>
    {
        public int UserId { get; set; }

        public GetUserQuery(int userId)
        {
            UserId = userId;
        }
    }
}
