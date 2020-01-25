namespace MegaDesk
{
	partial class SearchQuotes
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
            this.searchQuotesGridView = new System.Windows.Forms.DataGridView();
            this.surfaceMaterialLabel = new System.Windows.Forms.Label();
            this.surfaceMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.MainMenuReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchQuotesGridView
            // 
            this.searchQuotesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchQuotesGridView.Location = new System.Drawing.Point(0, 84);
            this.searchQuotesGridView.Name = "searchQuotesGridView";
            this.searchQuotesGridView.Size = new System.Drawing.Size(849, 361);
            this.searchQuotesGridView.TabIndex = 1;
            // 
            // surfaceMaterialLabel
            // 
            this.surfaceMaterialLabel.AutoSize = true;
            this.surfaceMaterialLabel.Location = new System.Drawing.Point(12, 30);
            this.surfaceMaterialLabel.Name = "surfaceMaterialLabel";
            this.surfaceMaterialLabel.Size = new System.Drawing.Size(84, 13);
            this.surfaceMaterialLabel.TabIndex = 2;
            this.surfaceMaterialLabel.Text = "Surface Material";
            // 
            // surfaceMaterialComboBox
            // 
            this.surfaceMaterialComboBox.FormattingEnabled = true;
            this.surfaceMaterialComboBox.Location = new System.Drawing.Point(175, 27);
            this.surfaceMaterialComboBox.Name = "surfaceMaterialComboBox";
            this.surfaceMaterialComboBox.Size = new System.Drawing.Size(121, 21);
            this.surfaceMaterialComboBox.TabIndex = 3;
            this.surfaceMaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.SurfaceMaterialComboBox_SelectedIndexChanged);
            // 
            // MainMenuReturn
            // 
            this.MainMenuReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuReturn.Location = new System.Drawing.Point(680, 403);
            this.MainMenuReturn.Name = "MainMenuReturn";
            this.MainMenuReturn.Size = new System.Drawing.Size(134, 35);
            this.MainMenuReturn.TabIndex = 4;
            this.MainMenuReturn.Text = "Main Menu";
            this.MainMenuReturn.UseVisualStyleBackColor = true;
            this.MainMenuReturn.Click += new System.EventHandler(this.MainMenuReturn_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.MainMenuReturn);
            this.Controls.Add(this.surfaceMaterialComboBox);
            this.Controls.Add(this.surfaceMaterialLabel);
            this.Controls.Add(this.searchQuotesGridView);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
           
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView searchQuotesGridView;
		private System.Windows.Forms.Label surfaceMaterialLabel;
		private System.Windows.Forms.ComboBox surfaceMaterialComboBox;
		private System.Windows.Forms.Button MainMenuReturn;
	}
}