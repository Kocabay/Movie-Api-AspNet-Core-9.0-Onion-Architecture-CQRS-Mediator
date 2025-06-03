using MediatR;

namespace MovieApi.Application.Feature.MediatorDesignPattern.Commands.CastCommands
{
    public class RemoveCastCommand:IRequest
    {
        public int CastId { get; set; }

        public RemoveCastCommand(int castId)
        {
            CastId = castId;
        }
    }
}
