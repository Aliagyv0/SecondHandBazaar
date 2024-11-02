using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SecondHandBazar.Application.DTOs.Request
{
    public record ProductDto(string Name, string Description, double Price, bool IsNew, string Location, string Transaction, string CategoryId,ICollection<IFormFile>? ProductImages);


}
