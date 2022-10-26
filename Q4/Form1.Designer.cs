namespace Q4
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.personTextBox = new System.Windows.Forms.TextBox();
			this.carTextBox = new System.Windows.Forms.TextBox();
			this.calcButton1 = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "人數";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(175, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "車";
			// 
			// personTextBox
			// 
			this.personTextBox.Location = new System.Drawing.Point(53, 34);
			this.personTextBox.Name = "personTextBox";
			this.personTextBox.Size = new System.Drawing.Size(100, 22);
			this.personTextBox.TabIndex = 1;
			// 
			// carTextBox
			// 
			this.carTextBox.Location = new System.Drawing.Point(198, 34);
			this.carTextBox.Name = "carTextBox";
			this.carTextBox.Size = new System.Drawing.Size(100, 22);
			this.carTextBox.TabIndex = 1;
			// 
			// calcButton1
			// 
			this.calcButton1.Location = new System.Drawing.Point(211, 93);
			this.calcButton1.Name = "calcButton1";
			this.calcButton1.Size = new System.Drawing.Size(75, 23);
			this.calcButton1.TabIndex = 2;
			this.calcButton1.Text = "計算";
			this.calcButton1.UseVisualStyleBackColor = true;
			this.calcButton1.Click += new System.EventHandler(this.calcButton1_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.Location = new System.Drawing.Point(123, 128);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(163, 34);
			this.resultLabel.TabIndex = 3;
			this.resultLabel.Text = "人:$ 車:$ 共:$";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 186);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.calcButton1);
			this.Controls.Add(this.carTextBox);
			this.Controls.Add(this.personTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox personTextBox;
		private System.Windows.Forms.TextBox carTextBox;
		private System.Windows.Forms.Button calcButton1;
		private System.Windows.Forms.Label resultLabel;
	}
}

