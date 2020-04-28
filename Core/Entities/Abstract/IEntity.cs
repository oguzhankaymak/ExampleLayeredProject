using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Abstract
{
    public abstract class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
