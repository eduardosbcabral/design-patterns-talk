internal class Facade
{
    protected Library1 _lo1;

    protected Library2 _lo2;

    public Facade(Library1 lo1, Library2 lo2)
    {
        _lo1 = lo1;
        _lo2 = lo2;
    }

    public string Operation()
    {
        string result = "Facade initializes libraries:\n";
        result += _lo1.Operation1();
        result += _lo2.Operation1();
        result += "Facade orders libraries to perform the action:\n";
        result += _lo1.OperationN();
        result += _lo2.OperationZ();
        return result;
    }
}