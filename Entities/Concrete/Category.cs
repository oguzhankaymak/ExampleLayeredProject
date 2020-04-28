using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Category : BaseEntity<int>
    {
        public string CategoryName { get; set; }
    }
}
