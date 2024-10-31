using SecondHandBazar.Application.DTOs.Request;
using SecondHandBazar.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandBazar.Application.Services
{
    public interface IProductService
    {
        Task<ProductDto> AddAsync(ProductDto dto);
        Task<ProductDto> UpdateAsync(Guid id, ProductDto dto);
        Task<ProductGetDto> GetAsync(Guid id);
        Task<IList<ProductGetDto>> GetAllAsync();
        Task<ProductDto> RemoveAsync(Guid id);
    }
}
