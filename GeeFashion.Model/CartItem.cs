using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeFashion.Model
{
    public class CartItem
    {
        public int OrderId {get;set;}
        public int OrderRowId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal OrgUnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal RowTotal { get; set; }
    }
}
