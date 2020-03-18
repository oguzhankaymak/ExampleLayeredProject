using Core.Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DomainModels
{
    public class CartLine : IDomainModel
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
