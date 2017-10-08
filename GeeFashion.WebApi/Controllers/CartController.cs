using GeeFashion.BusinessLogic;
using GeeFashion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GeeFashion.WebApi.Controllers
{
    [RoutePrefix("api/Cart")]
    public class CartController : ApiController
    {

        [Route("BuyTwoGetOneFree")]
        [HttpPost]
        public IHttpActionResult BuyTwoGetOneFree(Cart cart)
        {
            var totalItems = cart.Items.Sum(i=>i.Quantity);
            if (totalItems > 2)
            {
                var item = cart.Items.Where(c => c.UnitPrice > 0)
                   .OrderBy(c => c.UnitPrice)
                   .First();
                item.RowTotal -= item.UnitPrice;
            }
            return Ok(cart);
        }

    }
}
