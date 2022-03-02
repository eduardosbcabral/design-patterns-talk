internal class ConcreteBuilder : IBuilder
{
    private Product _product = new Product();

    // A fresh builder instance should contain a blank product object, which
    // is used in further assembly.
    public ConcreteBuilder()
    {
        this.Reset();
    }

    public void Reset()
    {
        this._product = new Product();
    }

    // All production steps work with the same product instance.
    public void BuildPartA()
    {
        this._product.Add("PartA1");
    }

    public void BuildPartB()
    {
        this._product.Add("PartB1");
    }

    public void BuildPartC()
    {
        this._product.Add("PartC1");
    }

    public Product GetProduct()
    {
        Product result = this._product;

        this.Reset();

        return result;
    }
}