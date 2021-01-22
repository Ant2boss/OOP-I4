using OOP_lib.Interfaces;
using OOP_lib.Models;

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lib.Internals
{
	internal class intCategory : ICategoryList
	{
		public intCategory(string FilePath)
		{
			this.pCategoryList = new List<Category>();
			this.pFilePath = FilePath;
			this.pParseFile(FilePath);
		}
		~intCategory() => this.Dispose();

		public Category this[int index]
		{
			get => this.pCategoryList[index];
			set => this.pCategoryList[index] = value;
		}
		public int Count => this.pCategoryList.Count;

		public bool AddCategory(Category C)
		{
			this.pCategoryList.Add(C);
			return true;
		}
		public bool RemoveCategory(Category C) => this.pCategoryList.Remove(C);
		public bool RemoveCategoryByID(Guid ID)
		{
			Category temp = this.pCategoryList.FirstOrDefault(el => el.ID == ID);
			return this.pCategoryList.Remove(temp);
		}

		public bool IsIDPresent(Guid ID)
		{
			foreach (Category C in this.pCategoryList)
			{
				if (C.ID == ID)
					return true;
			}
			return false;
		}

		public Category GetCategoryByID(Guid ID)
		{
			foreach (Category C in this.pCategoryList)
			{
				if (C.ID == ID)
					return C;
			}
			return null;
		}

		public IEnumerator<Category> GetEnumerator() => this.pCategoryList.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

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
				this.AddCategory(Category.ParseFileFormat(line, DEL));
			}
		}
		private void pWriteToFile(string FilePath)
		{
			if (!File.Exists(FilePath))
			{
				File.Create(FilePath).Close();
			}

			string[] fileData = new string[this.Count];
			for (int i = 0; i < this.pCategoryList.Count; ++i)
			{
				fileData[i] = this.pCategoryList[i].ToFileFormat(DEL);
			}

			File.WriteAllLines(FilePath, fileData);
		}

		IList<Category> pCategoryList;
		string pFilePath;
		const char DEL = '§';
	}
}
