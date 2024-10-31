using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SecondHandBazar.Application.DTOs.Request;
using SecondHandBazar.Application.DTOs.Response;
using SecondHandBazar.Application.Repository;
using SecondHandBazar.Application.Services;
using SecondHandBazar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandBazar.Infrastructure.Services
{
    public class ProductServices : IProductService
    {
        private readonly IGenericRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public ProductServices(IGenericRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductDto> AddAsync(ProductDto dto)
        {
            var entity = _mapper.Map<Product>(dto);
            await _productRepository.AddAsync(entity);
            await _productRepository.SaveChangesAsync();
            return _mapper.Map<ProductDto>(entity);
        }

        public async Task<IList<ProductGetDto>> GetAllAsync()
        {
            var query = _productRepository.GetAll();
            var entities = await query.ToListAsync();
            var dtos = _mapper.Map<List<ProductGetDto>>(entities);
            return dtos;
        }

        public async Task<ProductGetDto> GetAsync(Guid id)
        {
            var entity = await _productRepository.GetAsync(id);
            var dto = _mapper.Map<ProductGetDto>(entity);
            return dto;
        }

        public async Task<ProductDto> RemoveAsync(Guid id)
        {
            var entity = await _productRepository.GetAsync(id);
            _productRepository.Remove(entity);
            _productRepository.SaveChanges();
            return _mapper.Map<ProductDto>(entity); 
        }

        public async Task<ProductDto> UpdateAsync(Guid id, ProductDto dto)
        {
            var entity = await _productRepository.GetAsync(id);

            var entityToUpdate = _mapper.Map<Product>(dto);
            entityToUpdate.Id = id;
            _productRepository.Update(entityToUpdate);
            _productRepository.SaveChanges();
            var updateDto = _mapper.Map<ProductDto>(entityToUpdate);

            return updateDto;
        }
    }
}
