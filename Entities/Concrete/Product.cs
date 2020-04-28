using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Product : BaseEntity<int>
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
