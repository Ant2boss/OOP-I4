using OOP_lib.Interfaces;
using OOP_lib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lib.Internals
{
	internal class intProduct : IProductList
	{
		public intProduct(string FilePath)
		{
			this.pProductList = new List<Product>();
			this.pFilePath = FilePath;
			this.pParseFile(FilePath);
		}
		~intProduct() => this.Dispose();

		public Product this[int index]
		{
			get => this.pProductList[index];
			set => this.pProductList[index] = value;
		}
		public int Count => this.pProductList.Count;

		public bool AddProduct(Product P)
		{
			this.pProductList.Add(P);
			return true;
		}
		public bool RemoveProduct(Product P) => this.pProductList.Remove(P);
		public bool RemoveProductByID(Guid ID)
		{
			Product temp = this.pProductList.FirstOrDefault(el => el.ID == ID);
			return this.pProductList.Remove(temp);
		}

		public bool IsCategoryUsed(Category C)
		{
			foreach (Product P in this.pProductList)
			{
				if (P.MyCategory.Equals(C))
					return true;
			}
			return false;
		}

		public int GetCategoryUsedCount(Category C)
		{
			int tCounter = 0;

			foreach (Product P in this.pProductList)
			{
				if (P.MyCategory.Equals(C))
				{
					++tCounter;
				}
			}
			return tCounter;
		}

		public Product GetProductByID(Guid ID) => this.pProductList.FirstOrDefault(el => el.ID == ID);

		public IEnumerator<Product> GetEnumerator() => this.pProductList.GetEnumerator();

		public void Dispose()
		{
			this.pWriteToFile(this.pFilePath);
		}

		private void pParseFile(string FilePath)
		{
			if (!File.Exists(FilePath))
			{
				File.Create(FilePath).Close();
			}

			string[] fileData = File.ReadAllLines(FilePath);

			foreach (string line in fileData)
			{
				this.pProductList.Add(Product.ParseFileFormat(line, DEL));
			}
		}
		private void pWriteToFile(string FilePath)
		{
			if (!File.Exists(FilePath))
			{
				File.Create(FilePath).Close();
			}

			string[] fileData = new string[this.Count];
			for (int i = 0; i < this.pProductList.Count; ++i)
			{
				fileData[i] = this.pProductList[i].ToFileFormat(DEL);
			}

			File.WriteAllLines(FilePath, fileData);
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IList<Product> pProductList;
		string pFilePath;
		const char DEL = 'ß';
	}
}
