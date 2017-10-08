using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeFashion.Model
{
    public class Cart
    {
        public int OrderId {get;set;}
        public DateTime OrderDate {get;set;}
        public bool HasPromo {get;set;}
        public List<CartItem> Items {get;set;}

    }
}
