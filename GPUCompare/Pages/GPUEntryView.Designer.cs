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
			this.LabelReleasePrice = new System.Windows.Forms.Label();
			this.LabelLaunchDate = new System.Windows.Forms.Label();
			this.LabelModel = new System.Windows.Forms.Label();
			this.ArchitectureGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.LabelGen = new System.Windows.Forms.Label();
			this.LabelLithography = new System.Windows.Forms.Label();
			this.LabelTransistorCountAndDieSize = new System.Windows.Forms.Label();
			this.LabelBus = new System.Windows.Forms.Label();
			this.GroupBox_Core = new System.Windows.Forms.GroupBox();
			this.TableLayout_Core = new System.Windows.Forms.TableLayoutPanel();
			this.Label_Clock = new System.Windows.Forms.Label();
			this.Label_ROP = new System.Windows.Forms.Label();
			this.Label_TMU = new System.Windows.Forms.Label();
			this.Label_ShaderCores = new System.Windows.Forms.Label();
			this.GroupBox_Memory = new System.Windows.Forms.GroupBox();
			this.TableLayout_Memory = new System.Windows.Forms.TableLayoutPanel();
			this.Label_VRAM = new System.Windows.Forms.Label();
			this.Label_MemBandwidth = new System.Windows.Forms.Label();
			this.Label_MemClock = new System.Windows.Forms.Label();
			this.Label_BusTypeWidth = new System.Windows.Forms.Label();
			this.GroupBox_Perf = new System.Windows.Forms.GroupBox();
			this.TableLayout_Perf = new System.Windows.Forms.TableLayoutPanel();
			this.Label_ProcessingPower = new System.Windows.Forms.Label();
			this.Label_PerfHeaderDefault = new System.Windows.Forms.Label();
			this.Label_PerfHeaderTurbo = new System.Windows.Forms.Label();
			this.Label_FillRate = new System.Windows.Forms.Label();
			this.Label_Perf_Proc = new System.Windows.Forms.Label();
			this.Label_Perf_Fill = new System.Windows.Forms.Label();
			this.Label_Perf_Proc_Turbo = new System.Windows.Forms.Label();
			this.Label_Perf_Fill_Turbo = new System.Windows.Forms.Label();
			this.Label_TDP = new System.Windows.Forms.Label();
			this.Label_TDPVal = new System.Windows.Forms.Label();
			this.TableGPUEntry.SuspendLayout();
			this.TableManufacturing.SuspendLayout();
			this.ArchitectureGroupBox.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.GroupBox_Core.SuspendLayout();
			this.TableLayout_Core.SuspendLayout();
			this.GroupBox_Memory.SuspendLayout();
			this.TableLayout_Memory.SuspendLayout();
			this.GroupBox_Perf.SuspendLayout();
			this.TableLayout_Perf.SuspendLayout();
			this.SuspendLayout();
			// 
			// TableGPUEntry
			// 
			this.TableGPUEntry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableGPUEntry.BackColor = System.Drawing.Color.Transparent;
			this.TableGPUEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.TableGPUEntry.ColumnCount = 5;
			this.TableGPUEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.412483F));
			this.TableGPUEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.35278F));
			this.TableGPUEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.35278F));
			this.TableGPUEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.35278F));
			this.TableGPUEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.52917F));
			this.TableGPUEntry.Controls.Add(this.GroupBox_Perf, 4, 0);
			this.TableGPUEntry.Controls.Add(this.GroupBox_Memory, 3, 0);
			this.TableGPUEntry.Controls.Add(this.GroupBox_Core, 2, 0);
			this.TableGPUEntry.Controls.Add(this.TableManufacturing, 0, 0);
			this.TableGPUEntry.Controls.Add(this.ArchitectureGroupBox, 1, 0);
			this.TableGPUEntry.Location = new System.Drawing.Point(0, 0);
			this.TableGPUEntry.Name = "TableGPUEntry";
			this.TableGPUEntry.RowCount = 1;
			this.TableGPUEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableGPUEntry.Size = new System.Drawing.Size(1200, 122);
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
			this.TableManufacturing.Size = new System.Drawing.Size(94, 116);
			this.TableManufacturing.TabIndex = 0;
			// 
			// LabelReleasePrice
			// 
			this.LabelReleasePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelReleasePrice.AutoSize = true;
			this.LabelReleasePrice.ForeColor = System.Drawing.Color.Silver;
			this.LabelReleasePrice.Location = new System.Drawing.Point(3, 56);
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
			this.LabelLaunchDate.Location = new System.Drawing.Point(5, 91);
			this.LabelLaunchDate.Name = "LabelLaunchDate";
			this.LabelLaunchDate.Size = new System.Drawing.Size(92, 13);
			this.LabelLaunchDate.TabIndex = 2;
			this.LabelLaunchDate.Text = "LabelLaunchDate";
			// 
			// LabelModel
			// 
			this.LabelModel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelModel.AutoSize = true;
			this.LabelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelModel.ForeColor = System.Drawing.Color.Silver;
			this.LabelModel.Location = new System.Drawing.Point(9, 15);
			this.LabelModel.MaximumSize = new System.Drawing.Size(101, 0);
			this.LabelModel.Name = "LabelModel";
			this.LabelModel.Size = new System.Drawing.Size(83, 15);
			this.LabelModel.TabIndex = 1;
			this.LabelModel.Text = "LabelModel";
			this.LabelModel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// ArchitectureGroupBox
			// 
			this.ArchitectureGroupBox.AutoSize = true;
			this.ArchitectureGroupBox.Controls.Add(this.tableLayoutPanel1);
			this.ArchitectureGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ArchitectureGroupBox.ForeColor = System.Drawing.Color.Silver;
			this.ArchitectureGroupBox.Location = new System.Drawing.Point(100, 0);
			this.ArchitectureGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.ArchitectureGroupBox.Name = "ArchitectureGroupBox";
			this.ArchitectureGroupBox.Size = new System.Drawing.Size(244, 122);
			this.ArchitectureGroupBox.TabIndex = 1;
			this.ArchitectureGroupBox.TabStop = false;
			this.ArchitectureGroupBox.Text = "Architecture";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.LabelBus, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.LabelTransistorCountAndDieSize, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.LabelLithography, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.LabelGen, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 103);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// LabelGen
			// 
			this.LabelGen.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelGen.AutoSize = true;
			this.LabelGen.ForeColor = System.Drawing.Color.Silver;
			this.LabelGen.Location = new System.Drawing.Point(83, 6);
			this.LabelGen.Name = "LabelGen";
			this.LabelGen.Size = new System.Drawing.Size(71, 13);
			this.LabelGen.TabIndex = 4;
			this.LabelGen.Text = "GCN 5th Gen";
			// 
			// LabelLithography
			// 
			this.LabelLithography.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelLithography.AutoSize = true;
			this.LabelLithography.ForeColor = System.Drawing.Color.Silver;
			this.LabelLithography.Location = new System.Drawing.Point(72, 31);
			this.LabelLithography.Name = "LabelLithography";
			this.LabelLithography.Size = new System.Drawing.Size(94, 13);
			this.LabelLithography.TabIndex = 5;
			this.LabelLithography.Text = "Lithography: 14nm";
			// 
			// LabelTransistorCountAndDieSize
			// 
			this.LabelTransistorCountAndDieSize.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelTransistorCountAndDieSize.AutoSize = true;
			this.LabelTransistorCountAndDieSize.ForeColor = System.Drawing.Color.Silver;
			this.LabelTransistorCountAndDieSize.Location = new System.Drawing.Point(37, 56);
			this.LabelTransistorCountAndDieSize.Name = "LabelTransistorCountAndDieSize";
			this.LabelTransistorCountAndDieSize.Size = new System.Drawing.Size(163, 13);
			this.LabelTransistorCountAndDieSize.TabIndex = 6;
			this.LabelTransistorCountAndDieSize.Text = "Transistors: 125B  Die: 486mm^2";
			// 
			// LabelBus
			// 
			this.LabelBus.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LabelBus.AutoSize = true;
			this.LabelBus.ForeColor = System.Drawing.Color.Silver;
			this.LabelBus.Location = new System.Drawing.Point(56, 82);
			this.LabelBus.Name = "LabelBus";
			this.LabelBus.Size = new System.Drawing.Size(126, 13);
			this.LabelBus.TabIndex = 7;
			this.LabelBus.Text = "Bus: PCI-Express 3.0 x16";
			// 
			// GroupBox_Core
			// 
			this.GroupBox_Core.AutoSize = true;
			this.GroupBox_Core.Controls.Add(this.TableLayout_Core);
			this.GroupBox_Core.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupBox_Core.ForeColor = System.Drawing.Color.Silver;
			this.GroupBox_Core.Location = new System.Drawing.Point(344, 0);
			this.GroupBox_Core.Margin = new System.Windows.Forms.Padding(0);
			this.GroupBox_Core.Name = "GroupBox_Core";
			this.GroupBox_Core.Size = new System.Drawing.Size(244, 122);
			this.GroupBox_Core.TabIndex = 2;
			this.GroupBox_Core.TabStop = false;
			this.GroupBox_Core.Text = "Core";
			// 
			// TableLayout_Core
			// 
			this.TableLayout_Core.AutoSize = true;
			this.TableLayout_Core.ColumnCount = 1;
			this.TableLayout_Core.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayout_Core.Controls.Add(this.Label_Clock, 0, 3);
			this.TableLayout_Core.Controls.Add(this.Label_ROP, 0, 2);
			this.TableLayout_Core.Controls.Add(this.Label_TMU, 0, 1);
			this.TableLayout_Core.Controls.Add(this.Label_ShaderCores, 0, 0);
			this.TableLayout_Core.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayout_Core.Location = new System.Drawing.Point(3, 16);
			this.TableLayout_Core.Name = "TableLayout_Core";
			this.TableLayout_Core.RowCount = 4;
			this.TableLayout_Core.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TableLayout_Core.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TableLayout_Core.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TableLayout_Core.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TableLayout_Core.Size = new System.Drawing.Size(238, 103);
			this.TableLayout_Core.TabIndex = 0;
			// 
			// Label_Clock
			// 
			this.Label_Clock.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_Clock.AutoSize = true;
			this.Label_Clock.ForeColor = System.Drawing.Color.Silver;
			this.Label_Clock.Location = new System.Drawing.Point(33, 82);
			this.Label_Clock.Name = "Label_Clock";
			this.Label_Clock.Size = new System.Drawing.Size(172, 13);
			this.Label_Clock.TabIndex = 7;
			this.Label_Clock.Text = "Clock: 1480MHz  Turbo: 1582MHz";
			// 
			// Label_ROP
			// 
			this.Label_ROP.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_ROP.AutoSize = true;
			this.Label_ROP.ForeColor = System.Drawing.Color.Silver;
			this.Label_ROP.Location = new System.Drawing.Point(64, 56);
			this.Label_ROP.Name = "Label_ROP";
			this.Label_ROP.Size = new System.Drawing.Size(110, 13);
			this.Label_ROP.TabIndex = 6;
			this.Label_ROP.Text = "Render Output Units: ";
			// 
			// Label_TMU
			// 
			this.Label_TMU.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_TMU.AutoSize = true;
			this.Label_TMU.ForeColor = System.Drawing.Color.Silver;
			this.Label_TMU.Location = new System.Drawing.Point(59, 31);
			this.Label_TMU.Name = "Label_TMU";
			this.Label_TMU.Size = new System.Drawing.Size(120, 13);
			this.Label_TMU.TabIndex = 5;
			this.Label_TMU.Text = "Texture Mapping Units: ";
			// 
			// Label_ShaderCores
			// 
			this.Label_ShaderCores.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_ShaderCores.AutoSize = true;
			this.Label_ShaderCores.ForeColor = System.Drawing.Color.Silver;
			this.Label_ShaderCores.Location = new System.Drawing.Point(80, 6);
			this.Label_ShaderCores.Name = "Label_ShaderCores";
			this.Label_ShaderCores.Size = new System.Drawing.Size(77, 13);
			this.Label_ShaderCores.TabIndex = 4;
			this.Label_ShaderCores.Text = "Shader Cores: ";
			// 
			// GroupBox_Memory
			// 
			this.GroupBox_Memory.AutoSize = true;
			this.GroupBox_Memory.Controls.Add(this.TableLayout_Memory);
			this.GroupBox_Memory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupBox_Memory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GroupBox_Memory.ForeColor = System.Drawing.Color.White;
			this.GroupBox_Memory.Location = new System.Drawing.Point(588, 0);
			this.GroupBox_Memory.Margin = new System.Windows.Forms.Padding(0);
			this.GroupBox_Memory.Name = "GroupBox_Memory";
			this.GroupBox_Memory.Size = new System.Drawing.Size(244, 122);
			this.GroupBox_Memory.TabIndex = 3;
			this.GroupBox_Memory.TabStop = false;
			this.GroupBox_Memory.Text = "Memory";
			// 
			// TableLayout_Memory
			// 
			this.TableLayout_Memory.AutoSize = true;
			this.TableLayout_Memory.ColumnCount = 1;
			this.TableLayout_Memory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayout_Memory.Controls.Add(this.Label_MemBandwidth, 0, 1);
			this.TableLayout_Memory.Controls.Add(this.Label_VRAM, 0, 0);
			this.TableLayout_Memory.Controls.Add(this.Label_MemClock, 0, 3);
			this.TableLayout_Memory.Controls.Add(this.Label_BusTypeWidth, 0, 1);
			this.TableLayout_Memory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayout_Memory.Location = new System.Drawing.Point(3, 16);
			this.TableLayout_Memory.Name = "TableLayout_Memory";
			this.TableLayout_Memory.RowCount = 4;
			this.TableLayout_Memory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TableLayout_Memory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TableLayout_Memory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TableLayout_Memory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TableLayout_Memory.Size = new System.Drawing.Size(238, 103);
			this.TableLayout_Memory.TabIndex = 0;
			// 
			// Label_VRAM
			// 
			this.Label_VRAM.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_VRAM.AutoSize = true;
			this.Label_VRAM.ForeColor = System.Drawing.Color.Silver;
			this.Label_VRAM.Location = new System.Drawing.Point(100, 6);
			this.Label_VRAM.Name = "Label_VRAM";
			this.Label_VRAM.Size = new System.Drawing.Size(37, 13);
			this.Label_VRAM.TabIndex = 4;
			this.Label_VRAM.Text = "11 GB";
			// 
			// Label_MemBandwidth
			// 
			this.Label_MemBandwidth.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_MemBandwidth.AutoSize = true;
			this.Label_MemBandwidth.ForeColor = System.Drawing.Color.Silver;
			this.Label_MemBandwidth.Location = new System.Drawing.Point(64, 56);
			this.Label_MemBandwidth.Name = "Label_MemBandwidth";
			this.Label_MemBandwidth.Size = new System.Drawing.Size(109, 13);
			this.Label_MemBandwidth.TabIndex = 8;
			this.Label_MemBandwidth.Text = "Bandwidth: 484 GB/s";
			// 
			// Label_MemClock
			// 
			this.Label_MemClock.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_MemClock.AutoSize = true;
			this.Label_MemClock.ForeColor = System.Drawing.Color.Silver;
			this.Label_MemClock.Location = new System.Drawing.Point(81, 82);
			this.Label_MemClock.Name = "Label_MemClock";
			this.Label_MemClock.Size = new System.Drawing.Size(76, 13);
			this.Label_MemClock.TabIndex = 9;
			this.Label_MemClock.Text = "Clock: 11 GHz";
			// 
			// Label_BusTypeWidth
			// 
			this.Label_BusTypeWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_BusTypeWidth.AutoSize = true;
			this.Label_BusTypeWidth.ForeColor = System.Drawing.Color.Silver;
			this.Label_BusTypeWidth.Location = new System.Drawing.Point(75, 31);
			this.Label_BusTypeWidth.Name = "Label_BusTypeWidth";
			this.Label_BusTypeWidth.Size = new System.Drawing.Size(87, 13);
			this.Label_BusTypeWidth.TabIndex = 10;
			this.Label_BusTypeWidth.Text = "352-bit GDDR5X";
			// 
			// GroupBox_Perf
			// 
			this.GroupBox_Perf.AutoSize = true;
			this.GroupBox_Perf.Controls.Add(this.TableLayout_Perf);
			this.GroupBox_Perf.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupBox_Perf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GroupBox_Perf.ForeColor = System.Drawing.Color.White;
			this.GroupBox_Perf.Location = new System.Drawing.Point(832, 0);
			this.GroupBox_Perf.Margin = new System.Windows.Forms.Padding(0);
			this.GroupBox_Perf.Name = "GroupBox_Perf";
			this.GroupBox_Perf.Size = new System.Drawing.Size(368, 122);
			this.GroupBox_Perf.TabIndex = 4;
			this.GroupBox_Perf.TabStop = false;
			this.GroupBox_Perf.Text = "Performance";
			// 
			// TableLayout_Perf
			// 
			this.TableLayout_Perf.AutoSize = true;
			this.TableLayout_Perf.ColumnCount = 3;
			this.TableLayout_Perf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.33335F));
			this.TableLayout_Perf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.93156F));
			this.TableLayout_Perf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.73508F));
			this.TableLayout_Perf.Controls.Add(this.Label_PerfHeaderTurbo, 2, 0);
			this.TableLayout_Perf.Controls.Add(this.Label_ProcessingPower, 0, 1);
			this.TableLayout_Perf.Controls.Add(this.Label_PerfHeaderDefault, 1, 0);
			this.TableLayout_Perf.Controls.Add(this.Label_Perf_Proc, 1, 1);
			this.TableLayout_Perf.Controls.Add(this.Label_Perf_Proc_Turbo, 2, 1);
			this.TableLayout_Perf.Controls.Add(this.Label_Perf_Fill_Turbo, 2, 2);
			this.TableLayout_Perf.Controls.Add(this.Label_Perf_Fill, 1, 2);
			this.TableLayout_Perf.Controls.Add(this.Label_FillRate, 0, 2);
			this.TableLayout_Perf.Controls.Add(this.Label_TDPVal, 1, 3);
			this.TableLayout_Perf.Controls.Add(this.Label_TDP, 0, 3);
			this.TableLayout_Perf.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayout_Perf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TableLayout_Perf.Location = new System.Drawing.Point(3, 16);
			this.TableLayout_Perf.Name = "TableLayout_Perf";
			this.TableLayout_Perf.RowCount = 4;
			this.TableLayout_Perf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TableLayout_Perf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.TableLayout_Perf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.TableLayout_Perf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TableLayout_Perf.Size = new System.Drawing.Size(362, 103);
			this.TableLayout_Perf.TabIndex = 0;
			// 
			// Label_ProcessingPower
			// 
			this.Label_ProcessingPower.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_ProcessingPower.AutoSize = true;
			this.Label_ProcessingPower.ForeColor = System.Drawing.Color.Silver;
			this.Label_ProcessingPower.Location = new System.Drawing.Point(7, 26);
			this.Label_ProcessingPower.Name = "Label_ProcessingPower";
			this.Label_ProcessingPower.Size = new System.Drawing.Size(59, 13);
			this.Label_ProcessingPower.TabIndex = 8;
			this.Label_ProcessingPower.Text = "Processing";
			// 
			// Label_PerfHeaderDefault
			// 
			this.Label_PerfHeaderDefault.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_PerfHeaderDefault.AutoSize = true;
			this.Label_PerfHeaderDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_PerfHeaderDefault.ForeColor = System.Drawing.Color.Silver;
			this.Label_PerfHeaderDefault.Location = new System.Drawing.Point(119, 1);
			this.Label_PerfHeaderDefault.Name = "Label_PerfHeaderDefault";
			this.Label_PerfHeaderDefault.Size = new System.Drawing.Size(41, 13);
			this.Label_PerfHeaderDefault.TabIndex = 4;
			this.Label_PerfHeaderDefault.Text = "Default";
			// 
			// Label_PerfHeaderTurbo
			// 
			this.Label_PerfHeaderTurbo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_PerfHeaderTurbo.AutoSize = true;
			this.Label_PerfHeaderTurbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_PerfHeaderTurbo.ForeColor = System.Drawing.Color.Silver;
			this.Label_PerfHeaderTurbo.Location = new System.Drawing.Point(266, 1);
			this.Label_PerfHeaderTurbo.Name = "Label_PerfHeaderTurbo";
			this.Label_PerfHeaderTurbo.Size = new System.Drawing.Size(35, 13);
			this.Label_PerfHeaderTurbo.TabIndex = 11;
			this.Label_PerfHeaderTurbo.Text = "Turbo";
			// 
			// Label_FillRate
			// 
			this.Label_FillRate.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_FillRate.AutoSize = true;
			this.Label_FillRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_FillRate.ForeColor = System.Drawing.Color.Silver;
			this.Label_FillRate.Location = new System.Drawing.Point(14, 59);
			this.Label_FillRate.Name = "Label_FillRate";
			this.Label_FillRate.Size = new System.Drawing.Size(45, 13);
			this.Label_FillRate.TabIndex = 12;
			this.Label_FillRate.Text = "Fill Rate";
			// 
			// Label_Perf_Proc
			// 
			this.Label_Perf_Proc.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_Perf_Proc.AutoSize = true;
			this.Label_Perf_Proc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_Perf_Proc.ForeColor = System.Drawing.Color.Silver;
			this.Label_Perf_Proc.Location = new System.Drawing.Point(121, 26);
			this.Label_Perf_Proc.Name = "Label_Perf_Proc";
			this.Label_Perf_Proc.Size = new System.Drawing.Size(37, 13);
			this.Label_Perf_Proc.TabIndex = 13;
			this.Label_Perf_Proc.Text = "11 GB";
			// 
			// Label_Perf_Fill
			// 
			this.Label_Perf_Fill.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_Perf_Fill.AutoSize = true;
			this.Label_Perf_Fill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_Perf_Fill.ForeColor = System.Drawing.Color.Silver;
			this.Label_Perf_Fill.Location = new System.Drawing.Point(121, 59);
			this.Label_Perf_Fill.Name = "Label_Perf_Fill";
			this.Label_Perf_Fill.Size = new System.Drawing.Size(37, 13);
			this.Label_Perf_Fill.TabIndex = 14;
			this.Label_Perf_Fill.Text = "11 GB";
			// 
			// Label_Perf_Proc_Turbo
			// 
			this.Label_Perf_Proc_Turbo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_Perf_Proc_Turbo.AutoSize = true;
			this.Label_Perf_Proc_Turbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_Perf_Proc_Turbo.ForeColor = System.Drawing.Color.Silver;
			this.Label_Perf_Proc_Turbo.Location = new System.Drawing.Point(265, 26);
			this.Label_Perf_Proc_Turbo.Name = "Label_Perf_Proc_Turbo";
			this.Label_Perf_Proc_Turbo.Size = new System.Drawing.Size(37, 13);
			this.Label_Perf_Proc_Turbo.TabIndex = 15;
			this.Label_Perf_Proc_Turbo.Text = "11 GB";
			// 
			// Label_Perf_Fill_Turbo
			// 
			this.Label_Perf_Fill_Turbo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_Perf_Fill_Turbo.AutoSize = true;
			this.Label_Perf_Fill_Turbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_Perf_Fill_Turbo.ForeColor = System.Drawing.Color.Silver;
			this.Label_Perf_Fill_Turbo.Location = new System.Drawing.Point(265, 59);
			this.Label_Perf_Fill_Turbo.Name = "Label_Perf_Fill_Turbo";
			this.Label_Perf_Fill_Turbo.Size = new System.Drawing.Size(37, 13);
			this.Label_Perf_Fill_Turbo.TabIndex = 16;
			this.Label_Perf_Fill_Turbo.Text = "11 GB";
			// 
			// Label_TDP
			// 
			this.Label_TDP.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_TDP.AutoSize = true;
			this.Label_TDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_TDP.ForeColor = System.Drawing.Color.Silver;
			this.Label_TDP.Location = new System.Drawing.Point(22, 86);
			this.Label_TDP.Name = "Label_TDP";
			this.Label_TDP.Size = new System.Drawing.Size(29, 13);
			this.Label_TDP.TabIndex = 17;
			this.Label_TDP.Text = "TDP";
			// 
			// Label_TDPVal
			// 
			this.Label_TDPVal.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label_TDPVal.AutoSize = true;
			this.Label_TDPVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_TDPVal.ForeColor = System.Drawing.Color.Silver;
			this.Label_TDPVal.Location = new System.Drawing.Point(120, 86);
			this.Label_TDPVal.Name = "Label_TDPVal";
			this.Label_TDPVal.Size = new System.Drawing.Size(39, 13);
			this.Label_TDPVal.TabIndex = 18;
			this.Label_TDPVal.Text = "195 W";
			// 
			// GPUEntryView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.TableGPUEntry);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "GPUEntryView";
			this.Size = new System.Drawing.Size(1543, 125);
			this.Load += new System.EventHandler(this.ListEntryForm_Load);
			this.TableGPUEntry.ResumeLayout(false);
			this.TableGPUEntry.PerformLayout();
			this.TableManufacturing.ResumeLayout(false);
			this.TableManufacturing.PerformLayout();
			this.ArchitectureGroupBox.ResumeLayout(false);
			this.ArchitectureGroupBox.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.GroupBox_Core.ResumeLayout(false);
			this.GroupBox_Core.PerformLayout();
			this.TableLayout_Core.ResumeLayout(false);
			this.TableLayout_Core.PerformLayout();
			this.GroupBox_Memory.ResumeLayout(false);
			this.GroupBox_Memory.PerformLayout();
			this.TableLayout_Memory.ResumeLayout(false);
			this.TableLayout_Memory.PerformLayout();
			this.GroupBox_Perf.ResumeLayout(false);
			this.GroupBox_Perf.PerformLayout();
			this.TableLayout_Perf.ResumeLayout(false);
			this.TableLayout_Perf.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableGPUEntry;
		private System.Windows.Forms.TableLayoutPanel TableManufacturing;
		private System.Windows.Forms.Label LabelModel;
		private System.Windows.Forms.Label LabelReleasePrice;
		private System.Windows.Forms.Label LabelLaunchDate;
		private System.Windows.Forms.GroupBox ArchitectureGroupBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label LabelBus;
		private System.Windows.Forms.Label LabelTransistorCountAndDieSize;
		private System.Windows.Forms.Label LabelLithography;
		private System.Windows.Forms.Label LabelGen;
		private System.Windows.Forms.GroupBox GroupBox_Memory;
		private System.Windows.Forms.TableLayoutPanel TableLayout_Memory;
		private System.Windows.Forms.Label Label_VRAM;
		private System.Windows.Forms.GroupBox GroupBox_Core;
		private System.Windows.Forms.TableLayoutPanel TableLayout_Core;
		private System.Windows.Forms.Label Label_Clock;
		private System.Windows.Forms.Label Label_ROP;
		private System.Windows.Forms.Label Label_TMU;
		private System.Windows.Forms.Label Label_ShaderCores;
		private System.Windows.Forms.Label Label_MemBandwidth;
		private System.Windows.Forms.Label Label_MemClock;
		private System.Windows.Forms.Label Label_BusTypeWidth;
		private System.Windows.Forms.GroupBox GroupBox_Perf;
		private System.Windows.Forms.TableLayoutPanel TableLayout_Perf;
		private System.Windows.Forms.Label Label_ProcessingPower;
		private System.Windows.Forms.Label Label_PerfHeaderDefault;
		private System.Windows.Forms.Label Label_PerfHeaderTurbo;
		private System.Windows.Forms.Label Label_FillRate;
		private System.Windows.Forms.Label Label_Perf_Fill;
		private System.Windows.Forms.Label Label_Perf_Proc;
		private System.Windows.Forms.Label Label_Perf_Proc_Turbo;
		private System.Windows.Forms.Label Label_Perf_Fill_Turbo;
		private System.Windows.Forms.Label Label_TDPVal;
		private System.Windows.Forms.Label Label_TDP;
	}
}
