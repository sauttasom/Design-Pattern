

using CompositePattern;

void ShowPath(FileSystemComponent component)
{
  
    string codeFullPath = component.DisplayPath();
    Console.WriteLine(codeFullPath);
}

var rootFolder = new Folder("MyComputer");


Folder diskD = new Folder("diskD:");
Folder disk_emtry = new Folder("disk_emtry");

rootFolder.AddComponent(diskD);
rootFolder.AddComponent(disk_emtry);

Folder folderLecture = new Folder("Lecture");
Folder folderMovie = new Folder("Movie");

diskD.AddComponent(folderLecture);
//diskD.AddComponent(folderMovie);


Folder Folder_OOP = new Folder("Cos2101");
Folder folder_DesignPattrn = new Folder("Cos4311");

folderLecture.AddComponent(Folder_OOP);
folderLecture.AddComponent(folder_DesignPattrn);


Folder folder_code = new Folder("COS4311_Code");
Folder folder_diagram = new Folder("COS4311_Diagram");

folder_DesignPattrn.AddComponent(folder_code);
//folder_DesignPattrn.AddComponent(folder_diagram);



var file_code = new MyFile("Composite.cpp");
var filedrawio = new MyFile("Composite.drawio");

folder_code.AddComponent(file_code);
folder_diagram.AddComponent(filedrawio);

ShowPath(rootFolder);


//--------Folder Movie---------------

//var movie1 = new MyFile("John Wick");
//var folder_anime = new Folder("folder_anime");

//folderMovie.AddComponent(movie1);
//folderMovie.AddComponent(folder_anime);

//var anime1 = new MyFile("ChinCang");
//folder_anime.AddComponent(anime1);




//rootFolder.AddComponent(diskD);
//rootFolder.AddComponent(disk_emtry);

//Console.WriteLine(rootFolder.DisplayPath());




