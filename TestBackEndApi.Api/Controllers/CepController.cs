﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TestBackEndApi.Domain.Queries.Cep.Get;

namespace TestBackEndApi.Api.Controllers
{
    [Route("api/cep")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CepController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetCepQuery query)
        {
            try
            {
                var response = await _mediator.Send(query);
                if (response == null) return NotFound();
                if (string.IsNullOrEmpty(response.Cep)) return BadRequest(response);
                return Ok(response);
            }
            catch(Exception)
            {
                return StatusCode(500);
            }
            
        }

    }
}
