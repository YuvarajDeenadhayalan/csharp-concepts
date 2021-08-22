using System;
using CsharpConcepts.Delegates;

namespace DelegateDemo
{
    //Defining Delegates
    //Note: The access specifeis, return type and the number, order and type of parameters of delegate
    //should be same as the function it refers to.
    public delegate void AddDelegate(int a, int b);
    public delegate string GreetingsDelegate(string name);
    public class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            //Instantiating delegate by passing the target function Name
            //The Add method is non static so here we are calling method using object
            var delegateObj = new CsharpConcepts.Delegates.Delegate();
            AddDelegate ad = new AddDelegate(delegateObj.Add);
            //Invoking The Delegates
            ad(100, 50);
            Console.ReadKey();
        }
    }
}
