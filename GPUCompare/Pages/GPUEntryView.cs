using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPUCompare.Pages
{
	public partial class GPUEntryView : UserControl
	{
		static Dictionary<string, Bitmap> BackgroundImageLookup = new Dictionary<string, Bitmap>()
		{
			{ "amd", Properties.Resources.amd_logo_lo },
			{ "nvidia", Properties.Resources.nvd_logo_lo },
			{ "intel", Properties.Resources.itl_logo_lo }
		};

		Bitmap BackgroundImg = null;
		public GPUEntry Entry { get; private set; } = null;

		public GPUEntryView(GPUEntry entry)
		{
			InitializeComponent();
			this.Entry = entry;
			BackgroundImg = BackgroundImageLookup[entry.Manufacturer.Brand.ToLower()];
		}

		private void SetLabelText(Label label, string text)
		{
			label.SuspendLayout();
			label.Text = text;
			label.ResumeLayout();
		}
		
		private void ListEntryForm_Load(object sender, EventArgs e)
		{

			ControlHelper.SuspendDrawing(this);
			this.SuspendLayout();
			this.BackgroundImage = BackgroundImg;
			this.ResumeLayout(true);

			this.SuspendLayout();
			SetLabelText(LabelModel, Entry.Manufacturer.ModelName);
			SetLabelText(LabelLaunchDate, Entry.Manufacturer.LaunchDate.ToShortDateString());
			SetLabelText(LabelReleasePrice, "$" + Entry.Manufacturer.ReleasePrice.ToString());

			List<string> UITexts = null;

			UITexts = Entry.Architecture == null ? ArchitectureInfo.GetDefaultUIText() : Entry.Architecture.GetUIText();
			SetLabelText(LabelGen, UITexts[0]);
			SetLabelText(LabelLithography, UITexts[1]);
			SetLabelText(LabelTransistorCountAndDieSize, UITexts[2]);
			SetLabelText(LabelBus, UITexts[3]);

			UITexts.Clear();

			UITexts = Entry.Core == null ? CoreInfo.GetDefaultUIText() : Entry.Core.GetUIText();
			SetLabelText(Label_ShaderCores, UITexts[0]);
			SetLabelText(Label_TMU, UITexts[1]);
			SetLabelText(Label_ROP, UITexts[2]);
			SetLabelText(Label_Clock, UITexts[3]);

			UITexts.Clear();

			UITexts = Entry.Memory == null ? MemoryInfo.GetDefaultUIText() : Entry.Memory.GetUIText();
			SetLabelText(Label_VRAM, UITexts[0]);
			SetLabelText(Label_BusTypeWidth, UITexts[1]);
			SetLabelText(Label_MemBandwidth, UITexts[2]);
			SetLabelText(Label_MemClock, UITexts[3]);

			UITexts.Clear();

			UITexts = Entry.Perf == null ? Performance.GetDefaultUIText() : Entry.Perf.GetUIText();
			SetLabelText(Label_Perf_Proc, UITexts[0]);
			SetLabelText(Label_Perf_Proc_Turbo, UITexts[1]);
			SetLabelText(Label_Perf_Fill, UITexts[2]);
			SetLabelText(Label_Perf_Fill_Turbo, UITexts[3]);
			SetLabelText(Label_TDPVal, UITexts[4]);

			this.ResumeLayout(true);

			ControlHelper.ResumeDrawing(this);
		}
	}
}
