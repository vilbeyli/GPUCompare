using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GPUCompare.Pages
{
	public partial class ListPageUC : UserControl
	{
		public ListPageUC()
		{
			InitializeComponent();

			// TODO: start web query, get a result, parse and add control
			AddDelayedEntry();
			AddDelayedEntry(215);
		}



		void AddEntryView(GPUEntryView entryView)
		{
			GPUEntryTableLayout.SuspendLayout();
			GPUEntryTableLayout.Controls.Add(new Pages.GPUEntryView(entryView.Entry));
			GPUEntryTableLayout.ResumeLayout();
		}
		async void AddDelayedEntry(int delay = 0)
		{
			GPUEntryView GPUEntryViewTestAMD = new GPUEntryView(GPUEntryBuilder.GenerateTestEntry(GPUBrand.AMD));
			GPUEntryView GPUEntryViewTestNVD = new GPUEntryView(GPUEntryBuilder.GenerateTestEntry(GPUBrand.NVIDIA));
			GPUEntryView GPUEntryViewTestITL = new GPUEntryView(GPUEntryBuilder.GenerateTestEntry(GPUBrand.INTEL));

			await Task.Delay(delay);
			AddEntryView(GPUEntryViewTestITL);
			await Task.Delay(200);
			AddEntryView(GPUEntryViewTestNVD);
			await Task.Delay(200);
			AddEntryView(GPUEntryViewTestAMD);
			return;
		}
	}
}
