using OOP_lib.Internals.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lib.Models
{
	public class Category : absItem, IFileParser
	{
		public Category(string Name) : base()
		{
			this.Name = Name;
		}

		public string Name { get; set; }

		public static Category ParseFileFormat(string data, char DEL)
		{
			string[] d = data.Split(DEL);

			if (d.Length != 2)
				throw new FormatException("Unable to format from file");

			Category t = new Category(d[1]);
			t.ID = Guid.Parse(d[0]);

			return t;
		}

		public string ToFileFormat(char DEL) => $"{this.ID}{DEL}{this.Name}";

		public override string ToString() => base.ToString() + $", Name: {this.Name}";
	}
}
