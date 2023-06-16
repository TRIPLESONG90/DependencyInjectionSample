using Lib;

var engine = EngineFactory.CreateEngine(Manufacturer.BMW);
var car = new Car(engine);

car.StartEngine();