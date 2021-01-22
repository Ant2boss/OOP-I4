
namespace OOP_Forms
{
	partial class main_form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.table_category = new System.Windows.Forms.DataGridView();
			this.cat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cat_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.table_prod = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cat_info_label = new System.Windows.Forms.Label();
			this.butt_cat_remove = new System.Windows.Forms.Button();
			this.butt_cat_filt = new System.Windows.Forms.Button();
			this.butt_cat_copy = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.prod_info_label = new System.Windows.Forms.Label();
			this.prod_img = new System.Windows.Forms.PictureBox();
			this.butt_prod_image = new System.Windows.Forms.Button();
			this.butt_prod_remove = new System.Windows.Forms.Button();
			this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prod_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prod_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prod_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prod_image = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prod_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.table_category)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.table_prod)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prod_img)).BeginInit();
			this.SuspendLayout();
			// 
			// table_category
			// 
			this.table_category.AllowUserToDeleteRows = false;
			this.table_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.table_category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cat_id,
            this.cat_name});
			this.table_category.Cursor = System.Windows.Forms.Cursors.Hand;
			this.table_category.Location = new System.Drawing.Point(12, 55);
			this.table_category.Name = "table_category";
			this.table_category.Size = new System.Drawing.Size(430, 249);
			this.table_category.TabIndex = 0;
			this.table_category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_category_CellClick);
			this.table_category.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_category_CellValueChanged);
			this.table_category.MouseClick += new System.Windows.Forms.MouseEventHandler(this.table_category_MouseClick);
			// 
			// cat_id
			// 
			this.cat_id.HeaderText = "ID";
			this.cat_id.Name = "cat_id";
			this.cat_id.ReadOnly = true;
			this.cat_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// cat_name
			// 
			this.cat_name.HeaderText = "Name";
			this.cat_name.Name = "cat_name";
			// 
			// table_prod
			// 
			this.table_prod.AllowUserToDeleteRows = false;
			this.table_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.table_prod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod_id,
            this.prod_Name,
            this.prod_desc,
            this.prod_price,
            this.prod_image,
            this.prod_category});
			this.table_prod.Cursor = System.Windows.Forms.Cursors.Hand;
			this.table_prod.Location = new System.Drawing.Point(448, 55);
			this.table_prod.Name = "table_prod";
			this.table_prod.Size = new System.Drawing.Size(683, 249);
			this.table_prod.TabIndex = 0;
			this.table_prod.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_prod_CellClick);
			this.table_prod.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_prod_CellValueChanged);
			this.table_prod.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.table_prod_RowsRemoved);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(12, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(430, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Category";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(448, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(683, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Product";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(448, 307);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(683, 24);
			this.label3.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(12, 340);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(430, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "Category - Info";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cat_info_label
			// 
			this.cat_info_label.BackColor = System.Drawing.Color.DarkGray;
			this.cat_info_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cat_info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cat_info_label.Location = new System.Drawing.Point(12, 360);
			this.cat_info_label.Name = "cat_info_label";
			this.cat_info_label.Size = new System.Drawing.Size(430, 162);
			this.cat_info_label.TabIndex = 3;
			this.cat_info_label.Text = "Select a category to display more info";
			// 
			// butt_cat_remove
			// 
			this.butt_cat_remove.BackColor = System.Drawing.Color.Gray;
			this.butt_cat_remove.Cursor = System.Windows.Forms.Cursors.Hand;
			this.butt_cat_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.butt_cat_remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.butt_cat_remove.Location = new System.Drawing.Point(12, 525);
			this.butt_cat_remove.Name = "butt_cat_remove";
			this.butt_cat_remove.Size = new System.Drawing.Size(132, 31);
			this.butt_cat_remove.TabIndex = 4;
			this.butt_cat_remove.Text = "Remove category";
			this.butt_cat_remove.UseVisualStyleBackColor = false;
			this.butt_cat_remove.Click += new System.EventHandler(this.butt_cat_remove_Click);
			// 
			// butt_cat_filt
			// 
			this.butt_cat_filt.BackColor = System.Drawing.Color.Gray;
			this.butt_cat_filt.Cursor = System.Windows.Forms.Cursors.Hand;
			this.butt_cat_filt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.butt_cat_filt.ForeColor = System.Drawing.Color.Black;
			this.butt_cat_filt.Location = new System.Drawing.Point(150, 525);
			this.butt_cat_filt.Name = "butt_cat_filt";
			this.butt_cat_filt.Size = new System.Drawing.Size(154, 31);
			this.butt_cat_filt.TabIndex = 4;
			this.butt_cat_filt.Text = "Filter products";
			this.butt_cat_filt.UseVisualStyleBackColor = false;
			this.butt_cat_filt.Click += new System.EventHandler(this.butt_cat_filt_Click);
			// 
			// butt_cat_copy
			// 
			this.butt_cat_copy.BackColor = System.Drawing.Color.Gray;
			this.butt_cat_copy.Cursor = System.Windows.Forms.Cursors.Hand;
			this.butt_cat_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.butt_cat_copy.ForeColor = System.Drawing.Color.Black;
			this.butt_cat_copy.Location = new System.Drawing.Point(310, 525);
			this.butt_cat_copy.Name = "butt_cat_copy";
			this.butt_cat_copy.Size = new System.Drawing.Size(132, 31);
			this.butt_cat_copy.TabIndex = 4;
			this.butt_cat_copy.Text = "Copy ID";
			this.butt_cat_copy.UseVisualStyleBackColor = false;
			this.butt_cat_copy.Click += new System.EventHandler(this.butt_cat_copy_Click);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(448, 340);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(683, 20);
			this.label5.TabIndex = 1;
			this.label5.Text = "Product - Info";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// prod_info_label
			// 
			this.prod_info_label.BackColor = System.Drawing.Color.DarkGray;
			this.prod_info_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.prod_info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.prod_info_label.Location = new System.Drawing.Point(448, 360);
			this.prod_info_label.Name = "prod_info_label";
			this.prod_info_label.Size = new System.Drawing.Size(460, 162);
			this.prod_info_label.TabIndex = 3;
			this.prod_info_label.Text = "Select a product to display more info";
			// 
			// prod_img
			// 
			this.prod_img.Location = new System.Drawing.Point(914, 363);
			this.prod_img.Name = "prod_img";
			this.prod_img.Size = new System.Drawing.Size(217, 159);
			this.prod_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.prod_img.TabIndex = 5;
			this.prod_img.TabStop = false;
			// 
			// butt_prod_image
			// 
			this.butt_prod_image.BackColor = System.Drawing.Color.Gray;
			this.butt_prod_image.Cursor = System.Windows.Forms.Cursors.Hand;
			this.butt_prod_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.butt_prod_image.ForeColor = System.Drawing.Color.Black;
			this.butt_prod_image.Location = new System.Drawing.Point(448, 525);
			this.butt_prod_image.Name = "butt_prod_image";
			this.butt_prod_image.Size = new System.Drawing.Size(132, 31);
			this.butt_prod_image.TabIndex = 4;
			this.butt_prod_image.Text = "Open image";
			this.butt_prod_image.UseVisualStyleBackColor = false;
			this.butt_prod_image.Click += new System.EventHandler(this.butt_prod_image_Click);
			// 
			// butt_prod_remove
			// 
			this.butt_prod_remove.BackColor = System.Drawing.Color.Gray;
			this.butt_prod_remove.Cursor = System.Windows.Forms.Cursors.Hand;
			this.butt_prod_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.butt_prod_remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.butt_prod_remove.Location = new System.Drawing.Point(586, 525);
			this.butt_prod_remove.Name = "butt_prod_remove";
			this.butt_prod_remove.Size = new System.Drawing.Size(132, 31);
			this.butt_prod_remove.TabIndex = 4;
			this.butt_prod_remove.Text = "Remove product";
			this.butt_prod_remove.UseVisualStyleBackColor = false;
			this.butt_prod_remove.Click += new System.EventHandler(this.butt_prod_remove_Click);
			// 
			// prod_id
			// 
			this.prod_id.HeaderText = "ID";
			this.prod_id.Name = "prod_id";
			this.prod_id.ReadOnly = true;
			this.prod_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// prod_Name
			// 
			this.prod_Name.HeaderText = "Name";
			this.prod_Name.Name = "prod_Name";
			// 
			// prod_desc
			// 
			this.prod_desc.HeaderText = "Description";
			this.prod_desc.Name = "prod_desc";
			// 
			// prod_price
			// 
			this.prod_price.HeaderText = "Price";
			this.prod_price.Name = "prod_price";
			// 
			// prod_image
			// 
			this.prod_image.HeaderText = "ImagePath";
			this.prod_image.Name = "prod_image";
			this.prod_image.ReadOnly = true;
			// 
			// prod_category
			// 
			this.prod_category.HeaderText = "CategoryID";
			this.prod_category.Name = "prod_category";
			this.prod_category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// main_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1143, 590);
			this.Controls.Add(this.prod_img);
			this.Controls.Add(this.butt_prod_image);
			this.Controls.Add(this.butt_cat_copy);
			this.Controls.Add(this.butt_cat_filt);
			this.Controls.Add(this.butt_prod_remove);
			this.Controls.Add(this.butt_cat_remove);
			this.Controls.Add(this.prod_info_label);
			this.Controls.Add(this.cat_info_label);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.table_prod);
			this.Controls.Add(this.table_category);
			this.Name = "main_form";
			this.Text = "OOP - I4 - MainForm";
			this.Load += new System.EventHandler(this.main_form_Load);
			((System.ComponentModel.ISupportInitialize)(this.table_category)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.table_prod)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prod_img)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView table_category;
		private System.Windows.Forms.DataGridView table_prod;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn cat_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn cat_name;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label cat_info_label;
		private System.Windows.Forms.Button butt_cat_remove;
		private System.Windows.Forms.Button butt_cat_filt;
		private System.Windows.Forms.Button butt_cat_copy;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label prod_info_label;
		private System.Windows.Forms.PictureBox prod_img;
		private System.Windows.Forms.Button butt_prod_image;
		private System.Windows.Forms.Button butt_prod_remove;
		private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn prod_Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn prod_desc;
		private System.Windows.Forms.DataGridViewTextBoxColumn prod_price;
		private System.Windows.Forms.DataGridViewTextBoxColumn prod_image;
		private System.Windows.Forms.DataGridViewTextBoxColumn prod_category;
	}
}

