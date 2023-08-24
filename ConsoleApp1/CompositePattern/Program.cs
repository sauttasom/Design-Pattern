

using CompositePattern;
var library = new Category("Composite Library","", false, false);

bool isDVD = true;
bool isBook = true;

var bookCategory = new Category(string.Empty, "ScienceBook", isBook, false);

var novel = new Book("Great Expectations", "Charles Dickens", "97-3");
var scienceBook = new Book("A Brief History of Time", "Stephen Hawking", "38016-3");

bookCategory.AddComponent(novel);
bookCategory.AddComponent(scienceBook);


var dvdCategory = new Category(string.Empty, "Action DVD", false, isDVD);

var actionDVD = new DVD("Die Hard", "John McTiernan", "1988");
var actionDVD2 = new DVD("Die Hard", "HIT MAN", "1988");

dvdCategory.AddComponent(actionDVD);
dvdCategory.AddComponent(actionDVD2);

var dvdCategory2 = new Category(string.Empty, "Test DVD", false, isDVD);
var testdvd = new DVD("Die Hard", "John Witch", "1988");
dvdCategory2.AddComponent(testdvd);

library.AddComponent(bookCategory);
library.AddComponent(dvdCategory);
library.AddComponent(dvdCategory2);
Console.WriteLine(library);
library.ShowInfo();

Console.WriteLine("-----Deleted Test DVD!---------");
library.RemoveComponent(dvdCategory2);
library.ShowInfo();

