namespace GPUCompare
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.HeaderAndContentPanel = new System.Windows.Forms.TableLayoutPanel();
			this.HeaderFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.ListButton = new System.Windows.Forms.Button();
			this.CompareButton = new System.Windows.Forms.Button();
			this.HeaderAndContentPanel.SuspendLayout();
			this.HeaderFlowLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// HeaderAndContentPanel
			// 
			this.HeaderAndContentPanel.BackColor = System.Drawing.SystemColors.Control;
			this.HeaderAndContentPanel.ColumnCount = 1;
			this.HeaderAndContentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.HeaderAndContentPanel.Controls.Add(this.HeaderFlowLayout, 0, 0);
			this.HeaderAndContentPanel.Location = new System.Drawing.Point(0, 0);
			this.HeaderAndContentPanel.Name = "HeaderAndContentPanel";
			this.HeaderAndContentPanel.RowCount = 2;
			this.HeaderAndContentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.790698F));
			this.HeaderAndContentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.2093F));
			this.HeaderAndContentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.HeaderAndContentPanel.Size = new System.Drawing.Size(1584, 860);
			this.HeaderAndContentPanel.TabIndex = 0;
			// 
			// HeaderFlowLayout
			// 
			this.HeaderFlowLayout.Controls.Add(this.ListButton);
			this.HeaderFlowLayout.Controls.Add(this.CompareButton);
			this.HeaderFlowLayout.Location = new System.Drawing.Point(3, 3);
			this.HeaderFlowLayout.Name = "HeaderFlowLayout";
			this.HeaderFlowLayout.Size = new System.Drawing.Size(1578, 61);
			this.HeaderFlowLayout.TabIndex = 1;
			// 
			// ListButton
			// 
			this.ListButton.Location = new System.Drawing.Point(3, 3);
			this.ListButton.Name = "ListButton";
			this.ListButton.Size = new System.Drawing.Size(150, 58);
			this.ListButton.TabIndex = 0;
			this.ListButton.Text = "LIST";
			this.ListButton.UseVisualStyleBackColor = true;
			this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
			// 
			// CompareButton
			// 
			this.CompareButton.Location = new System.Drawing.Point(159, 3);
			this.CompareButton.Name = "CompareButton";
			this.CompareButton.Size = new System.Drawing.Size(148, 58);
			this.CompareButton.TabIndex = 1;
			this.CompareButton.Text = "COMPARE";
			this.CompareButton.UseVisualStyleBackColor = true;
			this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1584, 861);
			this.Controls.Add(this.HeaderAndContentPanel);
			this.Name = "MainForm";
			this.Text = "GPU Compare";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.HeaderAndContentPanel.ResumeLayout(false);
			this.HeaderFlowLayout.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.TableLayoutPanel HeaderAndContentPanel;
		private System.Windows.Forms.FlowLayoutPanel HeaderFlowLayout;
		private System.Windows.Forms.Button ListButton;
		private System.Windows.Forms.Button CompareButton;
	}
}

