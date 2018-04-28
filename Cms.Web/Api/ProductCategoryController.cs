using AutoMapper;
using Cms.Model.Models;
using Cms.Service;
using Cms.Web.Infrastructure.Core;
using Cms.Web.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
        public HttpResponseMessage GetAll(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () => {
                var model = _productCategoryService.GetAll();
                var responseData = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(model);
                var reponse = request.CreateResponse(HttpStatusCode.OK, responseData);
                return reponse;
            });
        }
    }
}