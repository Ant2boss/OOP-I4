using OOP_Forms.Utility;
using OOP_lib.Factory;
using OOP_lib.Interfaces;
using OOP_lib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Forms
{
	public partial class main_form : Form
	{
		DataGridViewCellStyle WarningStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle DefaultStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle SelectedStyle = new DataGridViewCellStyle();

		Category SelectedCategory;
		Product SelectedProduct;

		void InitializeStyles()
		{
			WarningStyle.BackColor = Color.DarkRed;
			WarningStyle.ForeColor = Color.White;
			WarningStyle.SelectionBackColor = Color.Red;

			DefaultStyle.BackColor = Color.White;
			DefaultStyle.ForeColor = Color.Black;
			DefaultStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);

			SelectedStyle.BackColor = Color.LightCyan;
			SelectedStyle.ForeColor = Color.Black;
			SelectedStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
		}

		private void StyleFullRow(DataGridView Table, int RowIndex, DataGridViewCellStyle style)
		{
			for (int i = 0; i < Table.ColumnCount; ++i)
			{
				Table.Rows[RowIndex].Cells[i].Style = style;
			}
		}

		private string getTableRowColl(DataGridView Table, int Row, int Column) => Table.Rows[Row].Cells[Column].Value?.ToString();

		private void FillCategoryLabeWithInfo(Category C)
		{
			int productCount = ProdList.GetCategoryUsedCount(C);

			butt_cat_copy.BackColor = Color.LightGray;
			butt_cat_filt.BackColor = Color.LightGray;
			butt_cat_remove.BackColor = (productCount > 0) ? (Color.Gray) : (Color.Silver);

			cat_info_label.Text = $"ID: {C.ID}\nName: {C.Name}\nRelated products: {productCount}";
		}
		private void FillProductLabeWithInfo(int selIndex)
		{
			if (selIndex < 0)
			{ 
				prod_info_label.Text = "";
				return;
			}
			prod_info_label.Text = $"ID: {getTableRowColl(table_prod, selIndex, 0)}\nName: {getTableRowColl(table_prod, selIndex, 1)}\n" +
				$"Description: {getTableRowColl(table_prod, selIndex, 2)}\n" +
				$"Price: {getTableRowColl(table_prod, selIndex, 3)}\nCategoryID: {getTableRowColl(table_prod, selIndex, 5)}";
			prod_img.ImageLocation = getTableRowColl(table_prod, selIndex, 4);
		}

		private ICategoryList CatList;
		private IProductList ProdList;

		public main_form()
		{
			InitializeStyles();
			InitializeComponent();
		}

		private void main_form_Load(object sender, EventArgs e)
		{
			CatList = Factory.GetCategoryList();
			ProdList = Factory.GetProductList();

			TableFiller.FillTableWithCategories(table_category, CatList);
			TableFiller.FillTableWithProduct(table_prod, ProdList);

			table_category.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			table_category.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			table_category.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			table_prod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			table_prod.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			table_prod.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}

		private void table_category_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex != -1)
			{
				string cat_id = table_category.Rows[e.RowIndex].Cells[0].Value?.ToString();
				string cat_name = table_category.Rows[e.RowIndex].Cells[1].Value?.ToString();

				//Deleted name and category exists-> delete the category
				if (string.IsNullOrEmpty(cat_name) && !string.IsNullOrEmpty(cat_id))
				{
					if (!ProdList.IsCategoryUsed(CatList[e.RowIndex]))
					{
						CatList.RemoveCategory(CatList[e.RowIndex]);
						table_category.Rows.RemoveAt(e.RowIndex);
					}
				}
				//New name and category exists
				else if (!string.IsNullOrEmpty(cat_name) && !string.IsNullOrEmpty(cat_id))
				{
					CatList[e.RowIndex].Name = cat_name;
				}
				//New name and new category
				else if (!string.IsNullOrEmpty(cat_name) && string.IsNullOrEmpty(cat_id))
				{
					CatList.AddCategory(new Category(cat_name));
					table_category.Rows[e.RowIndex].Cells[0].Value = CatList[e.RowIndex].ID.ToString();
				}

				//Tester
				//TableFiller.FillTableWithCategories(table_category, CatList);
			}
		}

		private void table_prod_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex != -1)
			{

				var cellData = table_prod.Rows[e.RowIndex].Cells;

				string ID = cellData[0].Value?.ToString();
				string Name = cellData[1].Value?.ToString();
				string Description = cellData[2].Value?.ToString();
				string Price = cellData[3].Value?.ToString();
				string Image = cellData[4].Value?.ToString();
				string CategoryID = cellData[5].Value?.ToString();

				//Validate data
				if (!double.TryParse(Price, out double valPrice))
				{
					label3.Text = "Price value invalid!";
					StyleFullRow(table_prod, e.RowIndex, WarningStyle);
				}
				else if (!Guid.TryParse(CategoryID, out Guid valCatID))
				{
					label3.Text = "Invalid category ID";
					StyleFullRow(table_prod, e.RowIndex, WarningStyle);
				}
				//IF this is a brand new item
				else if (
					string.IsNullOrEmpty(ID) && !string.IsNullOrEmpty(Name) &&
					!string.IsNullOrEmpty(Price) && !string.IsNullOrEmpty(CategoryID)
				)
				{
					ProdList.AddProduct(new Product(Name, valPrice, CatList.GetCategoryByID(valCatID)));
					ProdList[ProdList.Count - 1].ImagePath = Image;
					ProdList[ProdList.Count - 1].Description = Description;

					string newItemID = ProdList[ProdList.Count - 1].ID.ToString();
					table_prod.Rows[e.RowIndex].Cells[0].Value = newItemID;

					StyleFullRow(table_prod, e.RowIndex, DefaultStyle);
					label3.Text = "";
				}
				//Item already exists --> Update the list
				else if
				(
					!string.IsNullOrEmpty(ID) && !string.IsNullOrEmpty(Name) &&
					!string.IsNullOrEmpty(Price) && !string.IsNullOrEmpty(CategoryID)
				)
				{
					Product P = ProdList[e.RowIndex];
					P.Name = Name;
					P.Description = Description;
					P.ImagePath = Image;
					P.Price = valPrice;
					P.MyCategory = CatList.GetCategoryByID(valCatID);

					StyleFullRow(table_prod, e.RowIndex, DefaultStyle);
					label3.Text = "";
				}
				else
				{
					label3.Text = "Incomplete table Row!";
					StyleFullRow(table_prod, e.RowIndex, WarningStyle);
				}
				
				//TableFiller.FillTableWithProduct(table_prod, ProdList);
			}
		}

		private void table_prod_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
		}

		private void table_category_MouseClick(object sender, MouseEventArgs e)
		{
		}

		private void table_category_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < CatList.Count)
			{
				SelectedCategory = CatList.GetCategoryByID(Guid.Parse(getTableRowColl(table_category, e.RowIndex, 0)));
				FillCategoryLabeWithInfo(SelectedCategory);
			}
		}

		private void butt_cat_remove_Click(object sender, EventArgs e)
		{
			if (SelectedCategory != null)
			{
				if (!ProdList.IsCategoryUsed(SelectedCategory))
				{
					CatList.RemoveCategory(SelectedCategory);
					SelectedCategory = null;
					TableFiller.FillTableWithCategories(table_category, CatList);
				}
			}
		}

		private void butt_cat_copy_Click(object sender, EventArgs e)
		{
			if (SelectedCategory != null)
			{
				Clipboard.SetText(SelectedCategory.ID.ToString());
			}
		}

		private void butt_cat_filt_Click(object sender, EventArgs e)
		{
			if (SelectedCategory != null)
			{
				if (table_prod.ReadOnly)
				{
					butt_cat_filt.Text = "Filter products";

					table_prod.ReadOnly = false;
					TableFiller.FillTableWithProduct(table_prod, ProdList);
				}
				else 
				{
					table_prod.ReadOnly = true;
					butt_cat_filt.Text = "Disable filter";

					for (int i = 0; i < table_prod.Rows.Count;)
					{
						if (table_prod.Rows[i].Cells[5].Value != null 
							&& table_prod.Rows[i].Cells[5].Value.ToString() != SelectedCategory.ID.ToString())
						{
							table_prod.Rows.RemoveAt(i);
						}
						else 
						{
							++i;
						}
					}
				}
			}
		}

		private void table_prod_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < ProdList.Count)
			{
				FillProductLabeWithInfo(e.RowIndex);
				SelectedProduct = ProdList.GetProductByID(Guid.Parse(getTableRowColl(table_prod, e.RowIndex, 0)));

				butt_prod_image.BackColor = Color.LightGray;
				butt_prod_remove.BackColor = Color.LightGray;
			}
		}

		private void butt_prod_image_Click(object sender, EventArgs e)
		{
			if (SelectedProduct != null)
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					openFileDialog.FilterIndex = 2;
					openFileDialog.DefaultExt = ".png";
					openFileDialog.Filter = "All files (*.*)|*.*|png files (*.png)|*.png";

					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						SelectedProduct.ImagePath = openFileDialog.FileName;

						TableFiller.FillTableWithProduct(table_prod, ProdList);
					}
				} 
			}
		}

		private void butt_prod_remove_Click(object sender, EventArgs e)
		{
			if (SelectedProduct != null)
			{
				ProdList.RemoveProduct(SelectedProduct);
				SelectedProduct = null;
				FillProductLabeWithInfo(-1);
				TableFiller.FillTableWithProduct(table_prod, ProdList);
			}
		}
	}
}
