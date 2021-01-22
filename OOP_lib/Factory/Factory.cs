using OOP_lib.Interfaces;
using OOP_lib.Internals;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lib.Factory
{
	public static class Factory
	{
		public static ICategoryList GetCategoryList() => new intCategory("./Categories.txt");
		public static IProductList GetProductList() => new intProduct("./Products.txt");
	}
}
