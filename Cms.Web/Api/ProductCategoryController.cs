using AutoMapper;
using Cms.Model.Models;
using Cms.Service;
using Cms.Web.Infrastructure.Core;
using Cms.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Cms.Web.Api
{
    [RoutePrefix("api/v1/product-category")]
    public class ProductCategoryController : ApiControllerBase
    {
        IProductCategoryService _productCategoryService;
        public ProductCategoryController(IErrorService errorService, IProductCategoryService productCategoryService) : base(errorService)
        {
            this._productCategoryService = productCategoryService;
        }

        [Route("get-all")]
        [ResponseType(typeof(IEnumerable<ProductCategoryViewModel>))]
        public HttpResponseMessage GetAll(HttpRequestMessage request=null,string keyword = null, int page= 0, int pageSize = 2)
        {
            return CreateHttpResponse(request, () => {
                int totalRow = 0;
                var model = _productCategoryService.GetAll(keyword);
                var query = model.OrderBy(x=>x.CreatedDate).Skip(page * pageSize).Take(pageSize);
                totalRow = model.Count();
                var responseData = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(query.ToList());
                var paginationSet = new PaginationSet<ProductCategoryViewModel>()
                {
                    Items = responseData,
                    Page = page,
                    TotalCount = totalRow,
                    PagesCount = (int)Math.Ceiling((decimal)totalRow / pageSize)
                };
                var reponse = request.CreateResponse(HttpStatusCode.OK, paginationSet);
                return reponse;
            });
        }
    }
}