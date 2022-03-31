using System;
using System.Linq;

namespace Personas
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "1.234.567-2");
            Person jane = new Person("Jane Doe", "8.765.432-7");
            john.IntroduceYourself();
            jane.IntroduceYourself();
        }
    }
}
