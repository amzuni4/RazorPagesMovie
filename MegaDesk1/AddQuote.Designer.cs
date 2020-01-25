namespace MegaDesk
{
	partial class AddQuote
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
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.depthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.fullNameInput = new System.Windows.Forms.TextBox();
            this.numberOfDrawersUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.materialSelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rushOrderSelect = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.getQuoteButton = new System.Windows.Forms.Button();
            this.nameRequiredErrorMessage = new System.Windows.Forms.Label();
            this.wLimit = new System.Windows.Forms.Label();
            this.dLimit = new System.Windows.Forms.Label();
            this.drLimit = new System.Windows.Forms.Label();
            this.AddQuote_Form = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDrawersUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // widthUpDown
            // 
            this.widthUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthUpDown.Location = new System.Drawing.Point(298, 82);
            this.widthUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthUpDown.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(80, 26);
            this.widthUpDown.TabIndex = 1;
            this.widthUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.widthUpDown_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width (in)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Depth (in)";
            // 
            // depthUpDown
            // 
            this.depthUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthUpDown.Location = new System.Drawing.Point(298, 142);
            this.depthUpDown.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthUpDown.Name = "depthUpDown";
            this.depthUpDown.Size = new System.Drawing.Size(80, 26);
            this.depthUpDown.TabIndex = 2;
            this.depthUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name";
            // 
            // fullNameInput
            // 
            this.fullNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameInput.Location = new System.Drawing.Point(298, 26);
            this.fullNameInput.Name = "fullNameInput";
            this.fullNameInput.Size = new System.Drawing.Size(240, 26);
            this.fullNameInput.TabIndex = 0;
            this.fullNameInput.Text = "Enter Name Here";
            // 
            // numberOfDrawersUpDown
            // 
            this.numberOfDrawersUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDrawersUpDown.Location = new System.Drawing.Point(296, 200);
            this.numberOfDrawersUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numberOfDrawersUpDown.Name = "numberOfDrawersUpDown";
            this.numberOfDrawersUpDown.Size = new System.Drawing.Size(82, 26);
            this.numberOfDrawersUpDown.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Drawers";
            // 
            // materialSelect
            // 
            this.materialSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.materialSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.materialSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSelect.FormattingEnabled = true;
            this.materialSelect.Location = new System.Drawing.Point(298, 258);
            this.materialSelect.Name = "materialSelect";
            this.materialSelect.Size = new System.Drawing.Size(121, 28);
            this.materialSelect.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Surface Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rush Order";
            // 
            // rushOrderSelect
            // 
            this.rushOrderSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrderSelect.FormattingEnabled = true;
            this.rushOrderSelect.Location = new System.Drawing.Point(298, 319);
            this.rushOrderSelect.Name = "rushOrderSelect";
            this.rushOrderSelect.Size = new System.Drawing.Size(139, 28);
            this.rushOrderSelect.TabIndex = 5;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(12, 380);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(52, 24);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "Date";
            // 
            // getQuoteButton
            // 
            this.getQuoteButton.AutoSize = true;
            this.getQuoteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.getQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getQuoteButton.Location = new System.Drawing.Point(238, 370);
            this.getQuoteButton.Name = "getQuoteButton";
            this.getQuoteButton.Size = new System.Drawing.Size(264, 47);
            this.getQuoteButton.TabIndex = 6;
            this.getQuoteButton.Text = "Get Quote";
            this.getQuoteButton.UseVisualStyleBackColor = true;
            this.getQuoteButton.Click += new System.EventHandler(this.GetQuoteButton_Click);
            // 
            // nameRequiredErrorMessage
            // 
            this.nameRequiredErrorMessage.AutoSize = true;
            this.nameRequiredErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.nameRequiredErrorMessage.Location = new System.Drawing.Point(293, 54);
            this.nameRequiredErrorMessage.Name = "nameRequiredErrorMessage";
            this.nameRequiredErrorMessage.Size = new System.Drawing.Size(81, 13);
            this.nameRequiredErrorMessage.TabIndex = 14;
            this.nameRequiredErrorMessage.Text = "{error message}";
            // 
            // wLimit
            // 
            this.wLimit.AutoSize = true;
            this.wLimit.ForeColor = System.Drawing.Color.Red;
            this.wLimit.Location = new System.Drawing.Point(18, 113);
            this.wLimit.Name = "wLimit";
            this.wLimit.Size = new System.Drawing.Size(70, 13);
            this.wLimit.TabIndex = 15;
            this.wLimit.Text = "24\'-96\'in Limit";
            // 
            // dLimit
            // 
            this.dLimit.AutoSize = true;
            this.dLimit.ForeColor = System.Drawing.Color.Red;
            this.dLimit.Location = new System.Drawing.Point(22, 178);
            this.dLimit.Name = "dLimit";
            this.dLimit.Size = new System.Drawing.Size(66, 13);
            this.dLimit.TabIndex = 16;
            this.dLimit.Text = "12-48in Limit";
            // 
            // drLimit
            // 
            this.drLimit.AutoSize = true;
            this.drLimit.ForeColor = System.Drawing.Color.Red;
            this.drLimit.Location = new System.Drawing.Point(23, 227);
            this.drLimit.Name = "drLimit";
            this.drLimit.Size = new System.Drawing.Size(80, 13);
            this.drLimit.TabIndex = 17;
            this.drLimit.Text = "up to 7 drawers";
            // 
            // AddQuote_Form
            // 
            this.AddQuote_Form.Location = new System.Drawing.Point(587, 413);
            this.AddQuote_Form.Name = "AddQuote_Form";
            this.AddQuote_Form.Size = new System.Drawing.Size(96, 25);
            this.AddQuote_Form.TabIndex = 18;
            this.AddQuote_Form.Text = "Home";
            this.AddQuote_Form.UseVisualStyleBackColor = true;
            this.AddQuote_Form.Click += new System.EventHandler(this.AddQuote_Form_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.AddQuote_Form);
            this.Controls.Add(this.drLimit);
            this.Controls.Add(this.dLimit);
            this.Controls.Add(this.wLimit);
            this.Controls.Add(this.nameRequiredErrorMessage);
            this.Controls.Add(this.getQuoteButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rushOrderSelect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.materialSelect);
            this.Controls.Add(this.numberOfDrawersUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fullNameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.depthUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthUpDown);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDrawersUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown widthUpDown;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown depthUpDown;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox fullNameInput;
		private System.Windows.Forms.NumericUpDown numberOfDrawersUpDown;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox materialSelect;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox rushOrderSelect;
		private System.Windows.Forms.Label dateLabel;
		private System.Windows.Forms.Button getQuoteButton;
		private System.Windows.Forms.Label nameRequiredErrorMessage;
        private System.Windows.Forms.Label wLimit;
        private System.Windows.Forms.Label dLimit;
        private System.Windows.Forms.Label drLimit;
        private System.Windows.Forms.Button AddQuote_Form;
    }
}