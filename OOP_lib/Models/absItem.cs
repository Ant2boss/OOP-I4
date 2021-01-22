using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lib.Models
{
	public abstract class absItem
	{
		public absItem() => this.ID = Guid.NewGuid();

		public Guid ID { internal set; get; }

		public override string ToString() => $"ID: {this.ID}";
		public override bool Equals(object obj) => (obj is absItem tItem) ? (tItem.ID == this.ID) : (false);
		public override int GetHashCode() => this.ID.GetHashCode();
	}
}
