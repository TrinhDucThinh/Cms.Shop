namespace Cms.Data.Infrastructure
{
    public class DbFactory : Disposeable, IDbFactory
    {
        private CmsShopDbContext dbContext;

        public CmsShopDbContext Init()
        {
            return dbContext ?? (dbContext = new CmsShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null) dbContext.Dispose();
        }
    }
}