using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Modus
{
	public class Product
	{
		public string ID;
		public string BrandName;
		public string Model;
		public double Price;
		public double Cost;
		public double Income = 0;
		public int Count = 0;
		public int SoldCount = 0;


        public Product(string brandname, string model, double price, double cost, int count, int soldcount)
        {
			
			BrandName = brandname;
			Model = model;
			Price = price;
			Cost = cost;
			Count = count ;
			SoldCount = soldcount;
			if(Count < 0)
			{
				Count = 0;
			}
			else
			{
				Count = count;
			}
			ID = brandname.Substring(0, 2) + model.Substring(0, 2);
			
        }


		public void GetInfo()
		{
            Console.WriteLine($"Brand Name : {BrandName}");
			Console.WriteLine($"Model : {Model}");
			Console.WriteLine($"Price : {Price}");
			Console.WriteLine($"Cost : {Cost}");
			Console.WriteLine($"Count : {Count}");
            Console.WriteLine($"ID : {ID}");
		}


		public void Sale()
		{
				if(Count > 0)
				{
                
					Income += Price - Cost;
				
				
			}
				

			Console.WriteLine(string.Concat("Sold Count : ", Count - SoldCount));
			Console.WriteLine(string.Concat("Income : ",Income));
			}
		}
    }

