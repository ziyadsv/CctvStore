using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CctvStore.Models
{
    public class ProductProperty
    {
        public int ProductPropertyId { get; set; }
        public string  Price { get; set; }
       public ICollection<Product> Products { get; set; }
    }
}
