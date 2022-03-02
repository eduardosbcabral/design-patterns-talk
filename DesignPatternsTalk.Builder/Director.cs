internal class Director
{
    public IBuilder Builder { get; set; }

    public void BuildMinimalViableProduct()
        => Builder.BuildPartA();

    public void BuildFullFeaturedProduct()
    {
        Builder.BuildPartA();
        Builder.BuildPartB();
        Builder.BuildPartC();
    }
}
