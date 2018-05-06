namespace GPUCompare.Pages
{
	partial class CompareUC
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
			this.label_placeholder = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_placeholder
			// 
			this.label_placeholder.AutoSize = true;
			this.label_placeholder.Location = new System.Drawing.Point(55, 53);
			this.label_placeholder.Name = "label_placeholder";
			this.label_placeholder.Size = new System.Drawing.Size(63, 13);
			this.label_placeholder.TabIndex = 0;
			this.label_placeholder.Text = "Placeholder";
			// 
			// CompareUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Controls.Add(this.label_placeholder);
			this.Name = "CompareUC";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_placeholder;
	}
}
