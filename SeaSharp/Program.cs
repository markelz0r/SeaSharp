// See https://aka.ms/new-console-template for more information

using SeaSharp;

var seaport = new SeaPort();
var asset = await seaport.GetAsset("0x57f1887a8bf19b14fc0df6fd9b2acc9af147ea85", "88998424151158322152765625181503772358721556362386598961681361836419766237840");
//var bundle = await seaport.GetBundle("x4-save-on-gas-cKC");
Console.WriteLine(asset);