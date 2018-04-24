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
		public GPUEntry Entry { get; private set; } = null;
		public GPUEntryView(GPUEntry entry)
		{
			InitializeComponent();
			this.Entry = entry;
		}

		private void ListEntryForm_Load(object sender, EventArgs e)
		{
			this.SuspendLayout();
			LabelBrand.Text = Entry.Manufacturer.Brand;
			LabelModel.Text = Entry.Manufacturer.ModelName;
			LabelLaunchDate.Text = "Launch: " + Entry.Manufacturer.LaunchDate.ToShortDateString();
			LabelReleasePrice.Text = "$" + Entry.Manufacturer.ReleasePrice.ToString();
			this.ResumeLayout();
		}
	}
}
