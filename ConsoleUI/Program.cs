using DataAccess.Concrete.InMemory;
using Business.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManger = new CarManager(new InMemoryCarDal());
            

            foreach (var i in carManger.GetAll())
            {
                Console.WriteLine(i.Description);
            }

        }
    }
}
