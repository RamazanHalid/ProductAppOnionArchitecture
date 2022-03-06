using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductQuery : IRequest<List<ProductViewDto>>
    { 
        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<ProductViewDto>>
        {
            private readonly IProductRepository _productRepository;

            public GetAllProductQueryHandler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<List<ProductViewDto>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var products = await _productRepository.GetAllAsync();
                return products.Select(i => new ProductViewDto()
                {
                    Id = i.Id,
                    Name = i.Name
                }).ToList();
            }
        }
    }
}
