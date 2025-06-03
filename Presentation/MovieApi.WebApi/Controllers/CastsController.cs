using MediatR;
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
        public IActionResult CastList()
        {
            var value = _mediator.Send(new GetCastQuery());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateCast(CreateCastCommand command)
        {
            _mediator.Send(command);
            return Ok("Ekleme İşlemi Başarılı ...");
        }

        [HttpDelete]
        public IActionResult DeleteCast(int id)
        {
            _mediator.Send(new RemoveCastCommand(id));
            return Ok("Silme İşlemi Başarılı ...");
        }
        [HttpGet("GetCastById")]

        public IActionResult GetCastById(int id)
        {
            var values = _mediator.Send(new GetCastByIdQuery(id));
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateCast(CreateCastCommand command)
        {
            _mediator.Send(command);
            return Ok("Güncelleme İşlemi Başarılı ...");
        }
    }
}
