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
			//SetLabelText(LabelBrand, Entry.Manufacturer.Brand);
			SetLabelText(LabelModel, Entry.Manufacturer.ModelName);
			SetLabelText(LabelLaunchDate, Entry.Manufacturer.LaunchDate.ToShortDateString());
			SetLabelText(LabelReleasePrice, "$" + Entry.Manufacturer.ReleasePrice.ToString());
			this.ResumeLayout(true);

			ControlHelper.ResumeDrawing(this);
		}
	}
}
