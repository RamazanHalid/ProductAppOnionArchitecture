using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.Dto;
using ProductApp.Application.Features.Commands.CreateProduct;
using ProductApp.Application.Features.Queries.GetAllProducts;
using ProductApp.Application.Features.Queries.GetProductById;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator mediator;
        public ProductsController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllProductQuery();

            return Ok(await mediator.Send(query));
        }
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GeById(Guid id)
        {
            var query = new GetProductByIdQuery() { Id = id };

            return Ok(await mediator.Send(query));
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
