using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace ExemploMediatR
{
    public class GetSumQueryHandler : IRequestHandler<GetSumQuery, int>
    {
        public Task<int> Handle(GetSumQuery request, CancellationToken cancellationToken)
        {
            // Calcula a soma dos números usando a lista armazenada
            var sum = AddNumberCommandHandler.GetNumbers().Sum();
            return Task.FromResult(sum);
        }
    }
}
