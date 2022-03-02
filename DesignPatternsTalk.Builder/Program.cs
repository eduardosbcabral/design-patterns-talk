using System;

// <image url="C:\Users\Eduardo\Pictures\builder.png" scale="0.6" />

var director = new Director();
var builder = new ConcreteBuilder();
director.Builder = builder;
            
Console.WriteLine("Standard basic product:");
director.BuildMinimalViableProduct();
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Standard full featured product:");
director.BuildFullFeaturedProduct();
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Custom product:");
builder.BuildPartA();
builder.BuildPartC();
Console.Write(builder.GetProduct().ListParts());