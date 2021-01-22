using OOP_lib.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lib.Interfaces
{
	public interface IProductList : IEnumerable<Product>, IDisposable
	{
		bool AddProduct(Product P);
		bool RemoveProduct(Product P);
		bool RemoveProductByID(Guid ID);

		bool IsCategoryUsed(Category C);
		int GetCategoryUsedCount(Category C);
		Product GetProductByID(Guid ID);

		Product this[int index] { get; set; }
		int Count { get; }
	}
}
