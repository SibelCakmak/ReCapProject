
using Business.Concrete;
using System;
using DataAccess.Concrete.EntitiyFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            

            foreach (var i in carManager.GetAll())
            {
                Console.WriteLine(i.CarId);

            }

        }
    }
}
