

using Visitor;
using Visitor.Element;

var shoesData = new List<IShoes>
{
    new Nike(),
    new Reebok(),
    new Puma(),
    new Adidas()
};


var visitorUpgrad = new UpgradShoesVisitor();
shoesData.ForEach(x => x.Accept(visitorUpgrad));

