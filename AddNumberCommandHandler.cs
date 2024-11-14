using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace ExemploMediatR
{
    public class AddNumberCommandHandler : IRequestHandler<AddNumberCommand>
    {
        private static List<int> _numbers = new List<int>();

        public Task<Unit> Handle(AddNumberCommand request, CancellationToken cancellationToken)
        {
            _numbers.Add(request.Number);
            return Task.FromResult(Unit.Value);
        }

        public static List<int> GetNumbers() => _numbers;

        Task IRequestHandler<AddNumberCommand>.Handle(AddNumberCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
