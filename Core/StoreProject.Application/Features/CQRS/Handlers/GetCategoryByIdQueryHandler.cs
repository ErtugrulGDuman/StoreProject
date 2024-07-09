using StoreProject.Application.Features.CQRS.Results.CategoryResults;
using StoreProject.Application.Interfaces;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.CQRS.Handlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<GetCategoryByIdQueryResult> Handle(int id)
        {
            var values = await _repository.GetByIdAsync(id);
            return new GetCategoryByIdQueryResult
            {
                CategoryName = values.CategoryName,
                CategoryId = values.CategoryId
            };
        }
    }
}
