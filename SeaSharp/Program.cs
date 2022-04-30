// See https://aka.ms/new-console-template for more information

using SeaSharp;

var seaport = new SeaPort();
var bundle = await seaport.GetBundle("3x-save-gas-our-planet-is-dying-LpP");
Console.WriteLine(bundle);