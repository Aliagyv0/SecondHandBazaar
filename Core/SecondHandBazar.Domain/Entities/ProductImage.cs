using SecondHandBazar.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandBazar.Domain.Entities
{
    public class ProductImage : BaseEntity
    {
        public string FileName { get; set; }
        public bool IsMain { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
