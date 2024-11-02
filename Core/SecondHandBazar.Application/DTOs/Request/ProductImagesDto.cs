using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandBazar.Application.DTOs.Request
{
    public record ProductImagesDto(string ProductId, IFormFile Image);

}
