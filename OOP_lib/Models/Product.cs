using OOP_lib.Internals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lib.Models
{
	public class Product : absItem, IFileParser
	{
		public Product(string Name, double Price, Category Cat)
		{
			this.Name = Name;
			this.Price = Price;
			this.MyCategory = Cat;
		}

		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public string ImagePath { get; set; }

		public Category MyCategory { set; get; }

		public static Product ParseFileFormat(string data, char DEL)
		{
			string[] d = data.Split(DEL);

			Product p = new Product(d[1], double.Parse(d[3]), Category.ParseFileFormat(d[5], ';'));
			p.ID = Guid.Parse(d[0]);
			p.Description = d[2];
			p.ImagePath = d[4];

			return p;
		}
		public string ToFileFormat(char DEL) => $"{this.ID}{DEL}{this.Name}{DEL}{this.Description}{DEL}{this.Price}{DEL}" +
			$"{this.ImagePath}{DEL}{this.MyCategory.ToFileFormat(';')}";

		public override string ToString() => base.ToString() + $", Name: {this.Name}, Description: {this.Description}, " +
			$"Price: {this.Price}, Image: {this.ImagePath}";
	}
}
