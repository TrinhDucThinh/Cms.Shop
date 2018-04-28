namespace Cms.Data.Migrations
{
    using Cms.Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cms.Data.CmsShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Cms.Data.CmsShopDbContext context)
        {
            //Create data sample for productCategory
            CreateProductCategorySample(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

        private void CreateProductCategorySample(CmsShopDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> lstProductCategory = new List<ProductCategory>()
                {
                    new ProductCategory() { Name="Điện lạnh",Alias="dien-lanh",Status=true },
                    new ProductCategory() { Name="Viễn thông",Alias="vien-thong",Status=true },
                    new ProductCategory() { Name="Đồ gia dụng",Alias="do-gia-dung",Status=true },
                    new ProductCategory() { Name="Mỹ phẩm",Alias="my-pham",Status=true }
                };
                context.ProductCategories.AddRange(lstProductCategory);
                context.SaveChanges();
            }
        }
    }
}
