using Example.Modus;
using System.Collections.Concurrent;

namespace Example
{
	public class Program
	{
		static void Main(string[] args)
		{
			Product product = new Product("Apple", "iPhone 16", 3500, 1000, 100, 3);
			product.GetInfo();
			product.Sale();
		}
		
		}
	}
