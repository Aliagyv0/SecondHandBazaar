using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandBazar.Application.DTOs.Response
{
    public class ProductImagesGetDto()
    {
        public string Id { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMain { get; set; }
    }
}
