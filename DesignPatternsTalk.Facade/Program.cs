using System;

// <image url="C:\Users\Eduardo\Pictures\facade.png" scale="0.6" />

var library1 = new Library1();
var library2 = new Library2();
var facade = new Facade(library1, library2);
ClientCode(facade);

static void ClientCode(Facade facade)
{
    Console.Write(facade.Operation());
}