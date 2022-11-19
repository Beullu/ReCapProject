using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.CarDescription);
            }
        }
    }
}
