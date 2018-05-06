namespace GPUCompare.Pages
{
	partial class ListPageUC
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
			this.PageLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.Group_Manufacturer = new System.Windows.Forms.GroupBox();
			this.TableLayout_ManufacturerControls = new System.Windows.Forms.TableLayoutPanel();
			this.AmdCheckbox = new System.Windows.Forms.CheckBox();
			this.IntelCheckbox = new System.Windows.Forms.CheckBox();
			this.NvidiaCheckbox = new System.Windows.Forms.CheckBox();
			this.GPUEntryTableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.PageLayoutPanel.SuspendLayout();
			this.Group_Manufacturer.SuspendLayout();
			this.TableLayout_ManufacturerControls.SuspendLayout();
			this.SuspendLayout();
			// 
			// PageLayoutPanel
			// 
			this.PageLayoutPanel.AutoScroll = true;
			this.PageLayoutPanel.AutoSize = true;
			this.PageLayoutPanel.ColumnCount = 2;
			this.PageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.0545F));
			this.PageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.9455F));
			this.PageLayoutPanel.Controls.Add(this.Group_Manufacturer, 0, 0);
			this.PageLayoutPanel.Controls.Add(this.GPUEntryTableLayout, 1, 0);
			this.PageLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PageLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.PageLayoutPanel.Name = "PageLayoutPanel";
			this.PageLayoutPanel.RowCount = 1;
			this.PageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.PageLayoutPanel.Size = new System.Drawing.Size(1578, 53);
			this.PageLayoutPanel.TabIndex = 1;
			// 
			// Group_Manufacturer
			// 
			this.Group_Manufacturer.Controls.Add(this.TableLayout_ManufacturerControls);
			this.Group_Manufacturer.Location = new System.Drawing.Point(3, 3);
			this.Group_Manufacturer.Name = "Group_Manufacturer";
			this.Group_Manufacturer.Size = new System.Drawing.Size(200, 47);
			this.Group_Manufacturer.TabIndex = 0;
			this.Group_Manufacturer.TabStop = false;
			this.Group_Manufacturer.Text = "Manufacturer";
			// 
			// TableLayout_ManufacturerControls
			// 
			this.TableLayout_ManufacturerControls.ColumnCount = 3;
			this.TableLayout_ManufacturerControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TableLayout_ManufacturerControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
			this.TableLayout_ManufacturerControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.TableLayout_ManufacturerControls.Controls.Add(this.AmdCheckbox, 0, 0);
			this.TableLayout_ManufacturerControls.Controls.Add(this.IntelCheckbox, 1, 0);
			this.TableLayout_ManufacturerControls.Controls.Add(this.NvidiaCheckbox, 2, 0);
			this.TableLayout_ManufacturerControls.Location = new System.Drawing.Point(3, 19);
			this.TableLayout_ManufacturerControls.Name = "TableLayout_ManufacturerControls";
			this.TableLayout_ManufacturerControls.RowCount = 1;
			this.TableLayout_ManufacturerControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TableLayout_ManufacturerControls.Size = new System.Drawing.Size(196, 25);
			this.TableLayout_ManufacturerControls.TabIndex = 0;
			// 
			// AmdCheckbox
			// 
			this.AmdCheckbox.AutoSize = true;
			this.AmdCheckbox.Location = new System.Drawing.Point(3, 3);
			this.AmdCheckbox.Name = "AmdCheckbox";
			this.AmdCheckbox.Size = new System.Drawing.Size(50, 17);
			this.AmdCheckbox.TabIndex = 0;
			this.AmdCheckbox.Text = "AMD";
			this.AmdCheckbox.UseVisualStyleBackColor = true;
			// 
			// IntelCheckbox
			// 
			this.IntelCheckbox.AutoSize = true;
			this.IntelCheckbox.Location = new System.Drawing.Point(64, 3);
			this.IntelCheckbox.Name = "IntelCheckbox";
			this.IntelCheckbox.Size = new System.Drawing.Size(46, 17);
			this.IntelCheckbox.TabIndex = 1;
			this.IntelCheckbox.Text = "Intel";
			this.IntelCheckbox.UseVisualStyleBackColor = true;
			// 
			// NvidiaCheckbox
			// 
			this.NvidiaCheckbox.AutoSize = true;
			this.NvidiaCheckbox.Location = new System.Drawing.Point(129, 3);
			this.NvidiaCheckbox.Name = "NvidiaCheckbox";
			this.NvidiaCheckbox.Size = new System.Drawing.Size(57, 17);
			this.NvidiaCheckbox.TabIndex = 2;
			this.NvidiaCheckbox.Text = "NVidia";
			this.NvidiaCheckbox.UseVisualStyleBackColor = true;
			// 
			// GPUEntryTableLayout
			// 
			this.GPUEntryTableLayout.AutoScroll = true;
			this.GPUEntryTableLayout.AutoSize = true;
			this.GPUEntryTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.GPUEntryTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.GPUEntryTableLayout.ColumnCount = 1;
			this.GPUEntryTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.GPUEntryTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GPUEntryTableLayout.Location = new System.Drawing.Point(209, 3);
			this.GPUEntryTableLayout.Name = "GPUEntryTableLayout";
			this.GPUEntryTableLayout.RowCount = 1;
			this.GPUEntryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.GPUEntryTableLayout.Size = new System.Drawing.Size(1366, 47);
			this.GPUEntryTableLayout.TabIndex = 1;
			// 
			// ListPageUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.PageLayoutPanel);
			this.Name = "ListPageUC";
			this.Size = new System.Drawing.Size(1578, 53);
			this.PageLayoutPanel.ResumeLayout(false);
			this.PageLayoutPanel.PerformLayout();
			this.Group_Manufacturer.ResumeLayout(false);
			this.TableLayout_ManufacturerControls.ResumeLayout(false);
			this.TableLayout_ManufacturerControls.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel PageLayoutPanel;
		private System.Windows.Forms.GroupBox Group_Manufacturer;
		private System.Windows.Forms.TableLayoutPanel TableLayout_ManufacturerControls;
		private System.Windows.Forms.CheckBox AmdCheckbox;
		private System.Windows.Forms.CheckBox IntelCheckbox;
		private System.Windows.Forms.CheckBox NvidiaCheckbox;
		private System.Windows.Forms.TableLayoutPanel GPUEntryTableLayout;
	}
}
