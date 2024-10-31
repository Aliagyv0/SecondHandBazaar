using SecondHandBazar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SecondHandBazar.Application.DTOs.Response
{
    public class ProductGetDto()
    {
        public string Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; }
        public string Location { get; set; }
        public string Transaction { get; set; }
        public  CategoryGetDto Category { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }

    }
}
