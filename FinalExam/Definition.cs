using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
        public class Vehicle
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public string Year { get; set; }
            public double PurchaseCost { get; set; }
            public double? SoldPrice { get; set; }

            public Vehicle()
            {
                this.Make = "";
                this.Model = "";
                this.Year = DateTime.Now.Year.ToString();
                this.PurchaseCost = 0.0;
                this.SoldPrice = null;
            }
        }
    
}
