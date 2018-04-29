using AutoMapper;
using Cms.Model.Models;
using Cms.Service;
using Cms.Web.Infrastructure.Core;
using Cms.Web.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Cms.Web.Api
{
    [RoutePrefix("api/post-category")]
    // [Authorize]
    public class PostCategoryController : ApiControllerBase
    {
        private IPostCategoryService _postCategoryService;

        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) : base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        [Route("get-all")]
        [ResponseType(typeof(IEnumerable<PostCategoryViewModel>))]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listCategory = _postCategoryService.GetAll();
                var model = _postCategoryService.GetAll();
                var responseData = Mapper.Map<IEnumerable<PostCategory>,IEnumerable<PostCategoryViewModel>>(model);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, responseData);
                return response;
            });
        }
    }
}