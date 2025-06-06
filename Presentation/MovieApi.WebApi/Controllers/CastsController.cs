﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Feature.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Application.Feature.MediatorDesignPattern.Queries.CastQueries;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CastsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> CastList()
        {
            var value = await _mediator.Send(new GetCastQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCast(CreateCastCommand command)
        {
          await  _mediator.Send(command);
            return Ok("Ekleme İşlemi Başarılı ...");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCast(int id)
        {
           await _mediator.Send(new RemoveCastCommand(id));
            return Ok("Silme İşlemi Başarılı ...");
        }
        [HttpGet("GetCastById")]

        public async Task<IActionResult> GetCastById(int id)
        {
            var values = await _mediator.Send(new GetCastByIdQuery(id));
            return Ok(values);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCast(CreateCastCommand command)
        {
          await  _mediator.Send(command);
            return Ok("Güncelleme İşlemi Başarılı ...");
        }
    }
}
