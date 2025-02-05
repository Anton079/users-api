using AutoMapper;
using Microsoft.EntityFrameworkCore;
using users_api.Data.Migrations;
using users_api.Users.Models;

namespace users_api.Users.Repository
{
    public class UserRepo:IUserRepo
    {
        private readonly AppDbContext _appdbContext;
        private readonly IMapper _mapper;

        public UserRepo(AppDbContext appdbContext, IMapper mapper)
        {
            this._appdbContext = appdbContext;
            this._mapper = mapper;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _appdbContext.Users.ToListAsync();
        }
    }
}
