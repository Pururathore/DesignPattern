using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Program
    {
        //When to use it?
        //Exactly one instance of a class is required.
        //Controlled access to a single object is necessary.
        static void Main(string[] args)
        {
            Singleton.Instance.Show();
            Singleton.Instance.Show();

            Console.ReadKey();
        }
    }
}
