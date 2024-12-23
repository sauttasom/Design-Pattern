using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.SingletonPattern
{
    public class Mydatabase
    {
        private static Mydatabase? _context;
        private static bool _isOpen { get; set; }
        private Mydatabase()
        {
            Console.WriteLine("Connected Database");
        }
        private Mydatabase(Mydatabase mydatabase) { }
        public static Mydatabase GetDbContext()
        {
           if( _context == null )
            {
                _context = new Mydatabase();

            }
           return _context;
        }
        public Mydatabase GetDbContext2()
        {
            var _context2 = new Mydatabase();


            return _context2;
        }
        public void Open()
        {
            if (!_isOpen)
            {
                _isOpen = true;
            }

        }
        public void Close()
        {
            if (_isOpen)
            {
                _isOpen = false;
            }
        }
        public List<string> Executequery(string query)
        {
            if (!_isOpen)
            {
                throw new InvalidOperationException("Executequery Exception");
            }
            var data = new List<string>() {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"  };
            return data;

        }
       

    }
}
