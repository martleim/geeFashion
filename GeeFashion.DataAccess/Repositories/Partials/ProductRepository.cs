using GeeFashion.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeFashion.DataAccess.Repositories
{
    public partial class ProductRepository : BaseRepository<Product>
    {
        
        public List<ProductByWarehouse> GetProductsByWarehouseId(int warehouseId)
        {
            SqlParameter param = new SqlParameter("@WarehouseId", warehouseId);
            using (ProductRepository repository = new ProductRepository())
            {
                return context.Database.SqlQuery<ProductByWarehouse>("exec dbo.GetProductByWarehouseId @WarehouseId", param).ToList();
            }
        }
        

    }
}
