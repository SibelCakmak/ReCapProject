
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

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var i in result.Data)
                {
                    Console.WriteLine(i.Description + "/" + i.ColorName + "/" + i.BrandName);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            

        }
    }
}
