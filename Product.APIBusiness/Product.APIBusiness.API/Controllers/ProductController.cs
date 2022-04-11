using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Users.APIBusiness.DBContext.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Users.APIBusiness.API.Controllers
{
    [Produces("application/json")]
    [Route("api/product")]
    public class ProductController : Controller
    {

        protected readonly IProductRepository _ProductRepository;

        public ProductController(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="campus_id"></param>
        /// <param name="active"></param>


        /// <returns></returns>
        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet]
        [Route("list-Products")]
        public ActionResult List_Products(Int32 campus_id, int active)
        {
            var result = _ProductRepository.List_Products(campus_id, active);
            return Json(result);
        }

    }
}
