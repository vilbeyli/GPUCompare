using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPUCompare
{
    public partial class MainForm : Form
    {
		Pages.GPUEntryView GPUEntryViewTestAMD = new Pages.GPUEntryView(GPUEntryBuilder.GenerateTestEntry(GPUBrand.AMD));
		Pages.GPUEntryView GPUEntryViewTestNVD = new Pages.GPUEntryView(GPUEntryBuilder.GenerateTestEntry(GPUBrand.NVIDIA));
		Pages.GPUEntryView GPUEntryViewTestITL = new Pages.GPUEntryView(GPUEntryBuilder.GenerateTestEntry(GPUBrand.INTEL));

		static readonly Size OFFSET = new Size(0, 10);
		static int CurrentHeight = 10;

		void AddEntryView(Pages.GPUEntryView entryView)
		{
			entryView.Location += new Size(0, CurrentHeight) + OFFSET;
			Controls.Add(entryView);
			CurrentHeight = entryView.Location.Y + entryView.Size.Height;
		}

		public MainForm()
		{
			InitializeComponent();

			AddEntryView(GPUEntryViewTestAMD);
			AddEntryView(GPUEntryViewTestNVD);
		}

		async void AddDelayedEntry()
		{
			await Task.Delay(3000);
			AddEntryView(GPUEntryViewTestITL);
			return;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// TODO: start web query, get a result, parse and add control
			AddDelayedEntry();
		}
	}
}
