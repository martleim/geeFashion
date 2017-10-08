using GeeFashion.DataAccess.Repositories;
using GeeFashion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeFashion.BusinessLogic
{
    public class ProductManager : ManagerBase
    {

        public List<ProductByWarehouse> GetProductsByWarehouseId(int warehouseId) {

            using (ProductRepository repository = new ProductRepository())
            {
                return repository.GetProductsByWarehouseId(warehouseId);
            }
               
        }
        

    }
}
