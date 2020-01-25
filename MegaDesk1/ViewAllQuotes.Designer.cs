using System;
using System.Windows.Forms;

namespace MegaDesk
{
	partial class ViewAllQuotes
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
			this.allQuotesGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.allQuotesGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// allQuotesGridView
			// 
			this.allQuotesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.allQuotesGridView.Location = new System.Drawing.Point(0, -1);
			this.allQuotesGridView.Name = "allQuotesGridView";
			this.allQuotesGridView.Size = new System.Drawing.Size(845, 439);
			this.allQuotesGridView.TabIndex = 0;
			// 
			// ViewAllQuotes
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(844, 450);
			this.Controls.Add(this.allQuotesGridView);
			this.Name = "ViewAllQuotes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "View All Quotes";
		
			((System.ComponentModel.ISupportInitialize)(this.allQuotesGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView allQuotesGridView;
	}
}
