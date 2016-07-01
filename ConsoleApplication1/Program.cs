using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
     
    }
    public interface Index
    {

        void a(string n);
    }
    class a : Index {

        public void a(string n)
        {
            Console.WriteLine(n);
        }
    }
    
}
