using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.Auth.Queries.Login
{
    public class UserLoginQuery:IRequest<List<Claim>>
    {
        public string? UserName { get; set; }
        public string? Password { get; set;}
        public bool RememberMe { get; set; }
    }

    public class UserLoginQueryHandler : IRequestHandler<UserLoginQuery, List<Claim>>
    {
        public async Task<List<Claim>> Handle(UserLoginQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
