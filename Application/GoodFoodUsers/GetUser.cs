using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Dtos;
using Application.Interfaces;
using MediatR;

namespace Application.GoodFoodUsers
{
    public class GetUser
    {
        public class GetUserQuery : IRequest<List<GoodFoodUserDto>> { }
        public class Handler : IRequestHandler<GetUserQuery, List<GoodFoodUserDto>>
        {
            private readonly IUserAuth _userAuth;
            public Handler(IUserAuth userAuth)
            {
                _userAuth = userAuth;
            }

            public async Task<List<GoodFoodUserDto>> Handle(GetUserQuery request,
                CancellationToken cancellationToken)
            {
                var users = await _userAuth.GetAllUser();
                return users;
            }
        }
    }
}