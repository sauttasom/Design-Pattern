// See https://aka.ms/new-console-template for more information
using BridgePattern.Abstraction;
using BridgePattern.Implementor;



var colasoftdrink = new Cola(new SugarFree());
colasoftdrink.DisplayDetail();
colasoftdrink.BuyItem();

var colasoftdrink2 = new Cola(new SugarWhite());
colasoftdrink2.DisplayDetail();
colasoftdrink2.BuyItem();

var fantaWhite = new Fanta(new SugarWhite());
fantaWhite.DisplayDetail();
fantaWhite.BuyItem();


var spirit = new Spirit(new SugarWhite());
spirit.DisplayDetail();
spirit.BuyItem();
