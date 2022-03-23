using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Product.API.Application.Command.CreateProduct;
using Product.API.Application.ProductViewModel;
using Product.Domain.AggregateModel.ProductAggregate;
using Product.Saga.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Product.API.Controllers
{

    [Route("/api/product")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ProductController> logger;
        //private readonly ISendEndpointProvider _sendEndpointProvider;
        private readonly IMapper _mapper;

        public ProductController(IMediator mediator, ILogger<ProductController> logger,
            IMapper mapper)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this._mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
           // _sendEndpointProvider = sendEndpointProvider;
            this._mapper = mapper;
        }

        [HttpGet("getProduct")]
        public string GetAllEmployeeId(int id)
        {
            return ($"this is coming from ocelot{id} now");
        }


        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<ProductEntity>> CreateProduct(CreateProductCommand command)
        {
            logger.LogInformation($"from product {command.ProductDate}");
            return await _mediator.Send(command);
        }
      
        //[HttpPost]
        //[Route("productToBus")]
        //public async Task<IActionResult> ProductToBus([FromBody] CreateProductCommand command)
        //{
        //    //save in db
        //    //before sending the data
        //    //_context.savechangesAsync()
        //    var endpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri("queue" + "productQueue"));
        
        //    await endpoint.Send<IProductMessage>(new
        //    {
        //        command.ProductDiscount,
        //        command.ProductPrice
        //    });
        //    // _mapper.Map<>()
        //    return Ok("success");
        //    //have some time working 
        //}

    }
}
