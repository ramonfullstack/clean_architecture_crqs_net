using MediatR;

namespace ExemploMediatR
{
    public record GetSumQuery : IRequest<int>;
}
