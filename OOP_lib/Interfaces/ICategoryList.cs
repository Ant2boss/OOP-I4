using OOP_lib.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lib.Interfaces
{
	public interface ICategoryList : IEnumerable<Category>, IDisposable
	{
		bool AddCategory(Category C);
		bool RemoveCategory(Category C);
		bool RemoveCategoryByID(Guid ID);

		bool IsIDPresent(Guid ID);

		Category GetCategoryByID(Guid ID);

		Category this[int index] { get; set; }
		int Count { get; }
	}
}
