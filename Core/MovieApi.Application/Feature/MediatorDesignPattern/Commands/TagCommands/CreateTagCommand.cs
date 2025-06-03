using MediatR;

namespace MovieApi.Application.Feature.MediatorDesignPattern.Commands.TagCommands
{
    public class CreateTagCommand : IRequest
    {
        public string Title { get; set; }
    }
}
