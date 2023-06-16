class Car
{
    IEngine _engine;

    public Car()
    {
        _engine = new Engine();
    }
    public void StartEngine()
    {
        _engine.Start();
    }
}