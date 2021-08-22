using System;

namespace CsharpConcepts.Delegates
{
    public class Delegate
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(@"The Sum of {0} and {1}, is {2} ", x, y, (x + y));
        }
    }
}