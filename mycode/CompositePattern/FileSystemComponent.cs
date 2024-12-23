using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public interface FileSystemComponent
    {

        public string DisplayPath();
    }


    // Composite class (Folder)
    public class Folder : FileSystemComponent
    {
        public string FileName { get; set; }
        private List<FileSystemComponent> components = new List<FileSystemComponent>();

        public Folder(string name ) { 
            FileName = name;
        }
      
        public string  DisplayPath()
        {
            string resutl = this.FileName + "/";
            foreach( FileSystemComponent comp in components )
            {
                //resutl += resutl + "/" + comp.DisplayPath();
                resutl += comp.DisplayPath();
            }
            return  resutl;
        }
        public void AddComponent(FileSystemComponent component)
        {
            if(components == null )
            {
                components = new List<FileSystemComponent> ();
            }
            components.Add(component);

        }
    }

    // Leaf class (File)
    public class MyFile : FileSystemComponent
    {
        private string name;

        public MyFile(string name)
        {
            this.name = name;
        }

        //public string GetFullPath()
        //{
        //    return name;
        //}

        public string DisplayPath()
        {
            return name;
          //  Console.WriteLine("File: " + name);
        }
    }
}
