﻿using StoreProject.Application.Features.CQRS.Results.ProductResults;
using StoreProject.Application.Interfaces;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly IRepository<Product> _repository;

        public GetProductByIdQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task<GetProductByIdQueryResult> Handle(int id)
        {
            var values = await _repository.GetByIdAsync(id);
            return new GetProductByIdQueryResult
            {
                ProductId = values.ProductId,
                CategoryId = values.CategoryId,
                Name = values.Name,
                Price = values.Price,
                Stock = values.Stock
            };
        }
    }
}