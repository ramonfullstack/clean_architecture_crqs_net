using MediatR;

namespace ExemploMediatR
{
    public record AddNumberCommand(int Number) : IRequest;
}