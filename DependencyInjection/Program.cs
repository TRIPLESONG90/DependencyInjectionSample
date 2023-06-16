using Lib;
using Lib.Engines;
using Lib.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();

serviceCollection.AddSingleton<IEngine>(sp =>
{
    return EngineFactory.CreateEngine(Manufacturer.Benz);
}).AddSingleton<Car>();

var serviceProvider = serviceCollection.BuildServiceProvider();

var car = serviceProvider.GetService<Car>();

car?.StartEngine();