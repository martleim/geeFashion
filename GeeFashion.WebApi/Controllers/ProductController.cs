using GeeFashion.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GeeFashion.WebApi.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {

        [Route("ByWarehouseId/{warehouseId:int}")]
        [HttpGet]
        public IHttpActionResult ByWarehouseId(int warehouseId)
        {
            using (ProductManager manager = new ProductManager())
                return Ok(manager.GetProductsByWarehouseId(warehouseId));
        }

    }
}
