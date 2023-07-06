
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Base.Interface
{
    public interface IUserService : IBaseService<User, int, UserProfileDto>
    {

    }
}
