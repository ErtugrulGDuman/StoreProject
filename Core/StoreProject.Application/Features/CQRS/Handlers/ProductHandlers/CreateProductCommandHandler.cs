using StoreProject.Application.Features.CQRS.Commands.ProductCommands;
using StoreProject.Application.Interfaces;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly IRepository<Product> _repository;

        public CreateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateProductCommand command)
        {
            await _repository.CreateAsync(new Product
            {
                CategoryId = command.CategoryId,
                Name = command.Name,
                Price = command.Price,
                Stock = command.Stock
            });
        }
    }
}
