namespace GPUCompare.Pages
{
	partial class GPUEntryView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TableGPUEntry = new System.Windows.Forms.TableLayoutPanel();
			this.TableManufacturing = new System.Windows.Forms.TableLayoutPanel();
			this.LabelBrand = new System.Windows.Forms.Label();
			this.LabelModel = new System.Windows.Forms.Label();
			this.LabelLaunchDate = new System.Windows.Forms.Label();
			this.LabelReleasePrice = new System.Windows.Forms.Label();
			this.TableGPUEntry.SuspendLayout();
			this.TableManufacturing.SuspendLayout();
			this.SuspendLayout();
			// 
			// TableGPUEntry
			// 
			this.TableGPUEntry.ColumnCount = 5;
			this.TableGPUEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TableGPUEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TableGPUEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TableGPUEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TableGPUEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TableGPUEntry.Controls.Add(this.TableManufacturing, 0, 0);
			this.TableGPUEntry.Location = new System.Drawing.Point(0, 0);
			this.TableGPUEntry.Name = "TableGPUEntry";
			this.TableGPUEntry.RowCount = 1;
			this.TableGPUEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TableGPUEntry.Size = new System.Drawing.Size(770, 118);
			this.TableGPUEntry.TabIndex = 0;
			// 
			// TableManufacturing
			// 
			this.TableManufacturing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TableManufacturing.ColumnCount = 4;
			this.TableManufacturing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableManufacturing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableManufacturing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableManufacturing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableManufacturing.Controls.Add(this.LabelBrand, 3, 0);
			this.TableManufacturing.Controls.Add(this.LabelModel, 3, 1);
			this.TableManufacturing.Controls.Add(this.LabelReleasePrice, 3, 3);
			this.TableManufacturing.Controls.Add(this.LabelLaunchDate, 3, 2);
			this.TableManufacturing.Location = new System.Drawing.Point(3, 3);
			this.TableManufacturing.Name = "TableManufacturing";
			this.TableManufacturing.RowCount = 4;
			this.TableManufacturing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.76344F));
			this.TableManufacturing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.23656F));
			this.TableManufacturing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.TableManufacturing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.TableManufacturing.Size = new System.Drawing.Size(148, 112);
			this.TableManufacturing.TabIndex = 0;
			// 
			// LabelBrand
			// 
			this.LabelBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelBrand.AutoSize = true;
			this.LabelBrand.Location = new System.Drawing.Point(43, 4);
			this.LabelBrand.Name = "LabelBrand";
			this.LabelBrand.Size = new System.Drawing.Size(61, 13);
			this.LabelBrand.TabIndex = 0;
			this.LabelBrand.Text = "LabelBrand";
			// 
			// LabelModel
			// 
			this.LabelModel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelModel.AutoSize = true;
			this.LabelModel.Location = new System.Drawing.Point(43, 25);
			this.LabelModel.Name = "LabelModel";
			this.LabelModel.Size = new System.Drawing.Size(62, 13);
			this.LabelModel.TabIndex = 1;
			this.LabelModel.Text = "LabelModel";
			// 
			// LabelLaunchDate
			// 
			this.LabelLaunchDate.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelLaunchDate.AutoSize = true;
			this.LabelLaunchDate.Location = new System.Drawing.Point(28, 52);
			this.LabelLaunchDate.Name = "LabelLaunchDate";
			this.LabelLaunchDate.Size = new System.Drawing.Size(92, 13);
			this.LabelLaunchDate.TabIndex = 2;
			this.LabelLaunchDate.Text = "LabelLaunchDate";
			// 
			// LabelReleasePrice
			// 
			this.LabelReleasePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelReleasePrice.AutoSize = true;
			this.LabelReleasePrice.Location = new System.Drawing.Point(26, 87);
			this.LabelReleasePrice.Name = "LabelReleasePrice";
			this.LabelReleasePrice.Size = new System.Drawing.Size(96, 13);
			this.LabelReleasePrice.TabIndex = 3;
			this.LabelReleasePrice.Text = "LabelReleasePrice";
			// 
			// GPUEntryView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Controls.Add(this.TableGPUEntry);
			this.Name = "GPUEntryView";
			this.Size = new System.Drawing.Size(770, 122);
			this.Load += new System.EventHandler(this.ListEntryForm_Load);
			this.TableGPUEntry.ResumeLayout(false);
			this.TableManufacturing.ResumeLayout(false);
			this.TableManufacturing.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableGPUEntry;
		private System.Windows.Forms.TableLayoutPanel TableManufacturing;
		private System.Windows.Forms.Label LabelBrand;
		private System.Windows.Forms.Label LabelModel;
		private System.Windows.Forms.Label LabelLaunchDate;
		private System.Windows.Forms.Label LabelReleasePrice;
	}
}
