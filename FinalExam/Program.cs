using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleList = new List<Vehicle>() {
                new Vehicle() { Make = "Toyota", Model = "Camary", Year = "2017", PurchaseCost = 20000.00, SoldPrice = 25000.00 },
                new Vehicle() { Make = "Ford", Model = "Explorer", Year = "2015", PurchaseCost = 30000.00, SoldPrice = 35000.00 },
                new Vehicle() { Make = "Ford", Model = "Mustang", Year = "2018", PurchaseCost = 30000.00 },
                new Vehicle() { Make = "Mercedes", Model = "E350", Year = "2018", PurchaseCost = 50000.00, SoldPrice = 55000.00 },
                new Vehicle() { Make = "Jeep", Model = "Grand Cherokee", Year = "2018", PurchaseCost = 40000.00 },
                new Vehicle() { Make = "Toyota", Model = "Sienna", Year = "2016", PurchaseCost = 30000.00, SoldPrice = 35000.00 }
            };

            //LINQ to sort cars in descending order of years, makes, and models.
            var orderByResult = (from v in vehicleList
                                 orderby v.Year, v.Make, v.Model descending
                                 select v).ToList();

            //LINQ to retrieve the list of cars which have not yet been sold.
            var unsoldCars = (from v in vehicleList
                              where v.SoldPrice == null
                              select v).ToList();

            //LINQ to calculate how much the car dealer had paid for his car inventory for the Year 2018.
            var purchaseCost = (from v in vehicleList 
                                where v.Year == "2018" 
                                select v.PurchaseCost).Sum();
            Console.WriteLine("The amount paid by car dealer for his car inventory in 2018 = " + purchaseCost);

            //LINQ to calculate the grossed revenue for cars of Year 2018 that had been sold.
            var grossRevenue = (from v in vehicleList
                                where v.Year == "2018" && v.SoldPrice != null
                                select v.SoldPrice).Sum();

            Console.WriteLine("Gross revenue for cars of Year 2018 is: " + grossRevenue);

            //foreach (var v in unsoldCars)
               // Console.WriteLine("Make: {0}, Model: {1}, Year: {2}, Purchase Cost: {3}", v.Make, v.Model, v.Year, v.PurchaseCost);
        }
    }
}
