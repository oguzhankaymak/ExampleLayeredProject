using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class User : BaseEntity<int>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
