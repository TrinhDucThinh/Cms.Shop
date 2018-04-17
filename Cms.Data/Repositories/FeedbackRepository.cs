using Cms.Data.Infrastructure;
using Cms.Model.Models;

namespace Cms.Data.Data.Repositories
{
    public interface IFeedbackRepository : IRepository<Feedback>
    {
    }

    public class FeedbackRepository : RepositoryBase<Feedback>, IFeedbackRepository
    {
        public FeedbackRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}