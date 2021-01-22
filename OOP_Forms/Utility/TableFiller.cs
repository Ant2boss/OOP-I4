using OOP_lib.Interfaces;
using OOP_lib.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Forms.Utility
{
	public static class TableFiller
	{
		public static void FillTableWithCategories(DataGridView table, ICategoryList categories)
		{
			if (table.ColumnCount != 2)
				throw new Exception("Table is not formated properly");

			table.Rows.Clear();

			foreach (Category cat in categories)
			{
				table.Rows.Add(cat.ID, cat.Name);
			}
		}

		public static void FillTableWithProduct(DataGridView table, IProductList products)
		{
			if (table.ColumnCount != 6)
				throw new Exception("Table is not formated properly");

			table.Rows.Clear();

			foreach (Product p in products)
			{
				table.Rows.Add(p.ID, p.Name, p.Description, p.Price, p.ImagePath, p.MyCategory.ID);
			}
		}
	}
}
