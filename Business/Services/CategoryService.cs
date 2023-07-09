using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class CategoryService : BaseService<Categories, int, CategoryInfoDTO>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Categories, int> repository, IMapperHelper mapperHelper) : base(unitOfWork, repository, mapperHelper)
        {
        }
    }
}
