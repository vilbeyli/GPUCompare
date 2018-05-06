using GPUCompare.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPUCompare
{
    public partial class MainForm : Form
    {
		public enum Pages
		{
			LIST,
			COMPARE
		}

		Pages SelectedPage;

		ListPageUC PageList = new ListPageUC();
		CompareUC PageCompare = new CompareUC();

		UserControl SelectedUC = null;

		public MainForm()
		{
			InitializeComponent();

			SelectedPage = Pages.LIST;
			SelectedUC = PageList;
		}

		private void ShowPage(Pages page)
		{
			HeaderAndContentPanel.SuspendLayout();
			HeaderAndContentPanel.Controls.Remove(SelectedUC);
			switch (page)
			{
				case Pages.LIST:
					SelectedUC = PageList;
					break;
				case Pages.COMPARE:
					SelectedUC = PageCompare;
					break;
			}
			SelectedUC.Dock = DockStyle.Right; ; // DockStyle.Bottom;
			SelectedUC.AutoSize = true;
			HeaderAndContentPanel.Controls.Add(SelectedUC);
			HeaderAndContentPanel.ResumeLayout(true);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

			ShowPage(SelectedPage);
		}

		private void ListButton_Click(object sender, EventArgs e){ ShowPage(Pages.LIST); }
		private void CompareButton_Click(object sender, EventArgs e){ ShowPage(Pages.COMPARE); }
	}
}
