using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using SecondHandBazar.Domain.Entities.BaseEntities;
using SecondHandBazar.Domain.Enums;

namespace SecondHandBazar.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; }
        public string Location { get; set; }
        public TransactionType TransactionType { get; set; }
        public virtual Category Category { get; set; }
        public Guid CategoryId { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
