using ExemploMediatR;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddMediatR(typeof(Program));
var provider = services.BuildServiceProvider();
var mediator = provider.GetRequiredService<IMediator>();

// Executa um comando para adicionar números
await mediator.Send(new AddNumberCommand(10));
await mediator.Send(new AddNumberCommand(20));

// Executa uma consulta para obter a soma
var result = await mediator.Send(new GetSumQuery());
Console.WriteLine($"A soma dos números é: {result}");


