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
			this.LabelModel = new System.Windows.Forms.Label();
			this.LabelReleasePrice = new System.Windows.Forms.Label();
			this.LabelLaunchDate = new System.Windows.Forms.Label();
			this.TableGPUEntry.SuspendLayout();
			this.TableManufacturing.SuspendLayout();
			this.SuspendLayout();
			// 
			// TableGPUEntry
			// 
			this.TableGPUEntry.BackColor = System.Drawing.Color.Transparent;
			this.TableGPUEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
			this.TableGPUEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TableGPUEntry.Size = new System.Drawing.Size(770, 122);
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
			this.TableManufacturing.Controls.Add(this.LabelReleasePrice, 3, 1);
			this.TableManufacturing.Controls.Add(this.LabelLaunchDate, 3, 2);
			this.TableManufacturing.Controls.Add(this.LabelModel, 3, 0);
			this.TableManufacturing.Location = new System.Drawing.Point(3, 3);
			this.TableManufacturing.Name = "TableManufacturing";
			this.TableManufacturing.RowCount = 3;
			this.TableManufacturing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.TableManufacturing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.TableManufacturing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.TableManufacturing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TableManufacturing.Size = new System.Drawing.Size(148, 116);
			this.TableManufacturing.TabIndex = 0;
			// 
			// LabelModel
			// 
			this.LabelModel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelModel.AutoSize = true;
			this.LabelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelModel.ForeColor = System.Drawing.Color.Silver;
			this.LabelModel.Location = new System.Drawing.Point(32, 15);
			this.LabelModel.MaximumSize = new System.Drawing.Size(148, 0);
			this.LabelModel.Name = "LabelModel";
			this.LabelModel.Size = new System.Drawing.Size(83, 15);
			this.LabelModel.TabIndex = 1;
			this.LabelModel.Text = "LabelModel";
			this.LabelModel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// LabelReleasePrice
			// 
			this.LabelReleasePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelReleasePrice.AutoSize = true;
			this.LabelReleasePrice.ForeColor = System.Drawing.Color.Silver;
			this.LabelReleasePrice.Location = new System.Drawing.Point(26, 56);
			this.LabelReleasePrice.Name = "LabelReleasePrice";
			this.LabelReleasePrice.Size = new System.Drawing.Size(96, 13);
			this.LabelReleasePrice.TabIndex = 3;
			this.LabelReleasePrice.Text = "LabelReleasePrice";
			// 
			// LabelLaunchDate
			// 
			this.LabelLaunchDate.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelLaunchDate.AutoSize = true;
			this.LabelLaunchDate.ForeColor = System.Drawing.Color.Silver;
			this.LabelLaunchDate.Location = new System.Drawing.Point(28, 91);
			this.LabelLaunchDate.Name = "LabelLaunchDate";
			this.LabelLaunchDate.Size = new System.Drawing.Size(92, 13);
			this.LabelLaunchDate.TabIndex = 2;
			this.LabelLaunchDate.Text = "LabelLaunchDate";
			// 
			// GPUEntryView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Controls.Add(this.TableGPUEntry);
			this.DoubleBuffered = true;
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
		private System.Windows.Forms.Label LabelModel;
		private System.Windows.Forms.Label LabelReleasePrice;
		private System.Windows.Forms.Label LabelLaunchDate;
	}
}
