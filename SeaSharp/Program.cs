// See https://aka.ms/new-console-template for more information

using SeaSharp;

var seaport = new SeaPort();
//var asset = await seaport.GetAsset("0x47a00fc8590c11be4c419d9ae50dec267b6e24ee", "4645");
var bundle = await seaport.GetBundle("x4-save-on-gas-cKC");
Console.WriteLine(bundle);