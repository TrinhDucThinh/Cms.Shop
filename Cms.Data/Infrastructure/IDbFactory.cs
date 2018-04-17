using System;

namespace Cms.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        CmsShopDbContext Init();
    }
}