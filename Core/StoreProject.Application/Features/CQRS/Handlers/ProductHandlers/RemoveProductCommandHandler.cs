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
    public class RemoveProductCommandHandler
    {
        private readonly IRepository<Product> _repository;

        public RemoveProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveProductCommand command)
        {
            await _repository.DeleteAsync(command.Id);
        }
    }
}
