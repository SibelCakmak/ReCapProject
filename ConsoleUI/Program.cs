
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
            

            foreach (var i in carManager.GetCarDetails())
            {
                Console.WriteLine(i.Description+"/"+i.ColorName+"/"+i.BrandName);

            }

        }
    }
}
