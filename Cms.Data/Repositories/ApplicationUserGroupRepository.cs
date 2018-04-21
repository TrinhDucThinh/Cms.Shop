using Cms.Data.Infrastructure;
using Cms.Model.Models;

namespace Cms.Data.Repositories
{
    public interface IApplicationUserGroupRepository : IRepository<Cms.Model.Models.ApplicationUserGroup>
    {
    }

    public class ApplicationUserGroupRepository : RepositoryBase<ApplicationUserGroup>, IApplicationUserGroupRepository
    {
        public ApplicationUserGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}