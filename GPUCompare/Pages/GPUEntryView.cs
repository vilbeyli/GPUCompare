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
		private GPUEntry entry = null;
		public GPUEntryView(GPUEntry entry)
		{
			InitializeComponent();
			this.entry = entry;
		}

		private void ListEntryForm_Load(object sender, EventArgs e)
		{
			this.SuspendLayout();
			LabelBrand.Text = entry.Manufacturer.Brand;
			LabelModel.Text = entry.Manufacturer.ModelName;
			LabelLaunchDate.Text = "Launch: " + entry.Manufacturer.LaunchDate.ToShortDateString();
			LabelReleasePrice.Text = "$" + entry.Manufacturer.ReleasePrice.ToString();
			this.ResumeLayout();
		}
	}
}
