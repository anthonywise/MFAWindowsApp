namespace TradeStation.SystemTeam.Tools.WebAPI.MFAWindowsApp
{
	partial class AdHocForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgQuote = new System.Windows.Forms.DataGridView();
			this.txtSymbols = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGetQuote = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblSymbolSearchFeedback = new System.Windows.Forms.Label();
			this.dgSymbols = new System.Windows.Forms.DataGridView();
			this.optEQ = new System.Windows.Forms.RadioButton();
			this.optIdx = new System.Windows.Forms.RadioButton();
			this.optFX = new System.Windows.Forms.RadioButton();
			this.cboSymbol = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnGetSymbol = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblFeedback = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgQuote)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgSymbols)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgQuote);
			this.groupBox1.Controls.Add(this.txtSymbols);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnGetQuote);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(752, 179);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Quotes";
			// 
			// dgQuote
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgQuote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgQuote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgQuote.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgQuote.Location = new System.Drawing.Point(14, 45);
			this.dgQuote.Name = "dgQuote";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgQuote.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgQuote.Size = new System.Drawing.Size(723, 128);
			this.dgQuote.TabIndex = 6;
			// 
			// txtSymbols
			// 
			this.txtSymbols.Location = new System.Drawing.Point(64, 19);
			this.txtSymbols.Name = "txtSymbols";
			this.txtSymbols.Size = new System.Drawing.Size(164, 20);
			this.txtSymbols.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Symbols";
			// 
			// btnGetQuote
			// 
			this.btnGetQuote.Location = new System.Drawing.Point(237, 16);
			this.btnGetQuote.Name = "btnGetQuote";
			this.btnGetQuote.Size = new System.Drawing.Size(75, 23);
			this.btnGetQuote.TabIndex = 5;
			this.btnGetQuote.Text = "Get Quote";
			this.btnGetQuote.UseVisualStyleBackColor = true;
			this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lblSymbolSearchFeedback);
			this.groupBox3.Controls.Add(this.dgSymbols);
			this.groupBox3.Controls.Add(this.optEQ);
			this.groupBox3.Controls.Add(this.optIdx);
			this.groupBox3.Controls.Add(this.optFX);
			this.groupBox3.Controls.Add(this.cboSymbol);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.btnGetSymbol);
			this.groupBox3.Location = new System.Drawing.Point(12, 206);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(752, 129);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Symbols";
			// 
			// lblSymbolSearchFeedback
			// 
			this.lblSymbolSearchFeedback.AutoSize = true;
			this.lblSymbolSearchFeedback.Location = new System.Drawing.Point(330, 19);
			this.lblSymbolSearchFeedback.Name = "lblSymbolSearchFeedback";
			this.lblSymbolSearchFeedback.Size = new System.Drawing.Size(19, 13);
			this.lblSymbolSearchFeedback.TabIndex = 14;
			this.lblSymbolSearchFeedback.Text = "....";
			// 
			// dgSymbols
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgSymbols.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dgSymbols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgSymbols.DefaultCellStyle = dataGridViewCellStyle11;
			this.dgSymbols.Location = new System.Drawing.Point(14, 51);
			this.dgSymbols.Name = "dgSymbols";
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgSymbols.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dgSymbols.Size = new System.Drawing.Size(723, 65);
			this.dgSymbols.TabIndex = 12;
			// 
			// optEQ
			// 
			this.optEQ.AutoSize = true;
			this.optEQ.Location = new System.Drawing.Point(179, 17);
			this.optEQ.Name = "optEQ";
			this.optEQ.Size = new System.Drawing.Size(40, 17);
			this.optEQ.TabIndex = 7;
			this.optEQ.TabStop = true;
			this.optEQ.Text = "EQ";
			this.optEQ.UseVisualStyleBackColor = true;
			// 
			// optIdx
			// 
			this.optIdx.AutoSize = true;
			this.optIdx.Location = new System.Drawing.Point(269, 17);
			this.optIdx.Name = "optIdx";
			this.optIdx.Size = new System.Drawing.Size(43, 17);
			this.optIdx.TabIndex = 9;
			this.optIdx.TabStop = true;
			this.optIdx.Text = "IDX";
			this.optIdx.UseVisualStyleBackColor = true;
			// 
			// optFX
			// 
			this.optFX.AutoSize = true;
			this.optFX.Location = new System.Drawing.Point(225, 17);
			this.optFX.Name = "optFX";
			this.optFX.Size = new System.Drawing.Size(38, 17);
			this.optFX.TabIndex = 8;
			this.optFX.TabStop = true;
			this.optFX.Text = "FX";
			this.optFX.UseVisualStyleBackColor = true;
			// 
			// cboSymbol
			// 
			this.cboSymbol.FormattingEnabled = true;
			this.cboSymbol.Location = new System.Drawing.Point(52, 19);
			this.cboSymbol.Name = "cboSymbol";
			this.cboSymbol.Size = new System.Drawing.Size(121, 21);
			this.cboSymbol.TabIndex = 6;
			this.cboSymbol.TextUpdate += new System.EventHandler(this.cboSymbol_TextUpdate);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Symbol";
			// 
			// btnGetSymbol
			// 
			this.btnGetSymbol.Location = new System.Drawing.Point(650, 17);
			this.btnGetSymbol.Name = "btnGetSymbol";
			this.btnGetSymbol.Size = new System.Drawing.Size(75, 23);
			this.btnGetSymbol.TabIndex = 11;
			this.btnGetSymbol.Text = "Get Symbol";
			this.btnGetSymbol.UseVisualStyleBackColor = true;
			this.btnGetSymbol.Click += new System.EventHandler(this.btnGetSymbol_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(689, 352);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblFeedback
			// 
			this.lblFeedback.AutoSize = true;
			this.lblFeedback.Location = new System.Drawing.Point(12, 362);
			this.lblFeedback.Name = "lblFeedback";
			this.lblFeedback.Size = new System.Drawing.Size(16, 13);
			this.lblFeedback.TabIndex = 13;
			this.lblFeedback.Text = "...";
			// 
			// AdHocForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 384);
			this.Controls.Add(this.lblFeedback);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Name = "AdHocForm";
			this.Text = "Quotes and Symbols";
			this.Load += new System.EventHandler(this.AdHocForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgQuote)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgSymbols)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgQuote;
		private System.Windows.Forms.TextBox txtSymbols;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGetQuote;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dgSymbols;
		private System.Windows.Forms.RadioButton optEQ;
		private System.Windows.Forms.RadioButton optIdx;
		private System.Windows.Forms.RadioButton optFX;
		private System.Windows.Forms.ComboBox cboSymbol;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnGetSymbol;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblFeedback;
		private System.Windows.Forms.Label lblSymbolSearchFeedback;
	}
}