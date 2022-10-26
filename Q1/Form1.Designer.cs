namespace Q1
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
			this.button = new System.Windows.Forms.Button();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.displayLabel2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(146, 131);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(75, 23);
			this.button.TabIndex = 0;
			this.button.Text = "顯示";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// inputTextBox
			// 
			this.inputTextBox.Location = new System.Drawing.Point(75, 68);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(100, 22);
			this.inputTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(75, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "請輸入一個整數";
			// 
			// displayLabel2
			// 
			this.displayLabel2.AutoSize = true;
			this.displayLabel2.Location = new System.Drawing.Point(30, 136);
			this.displayLabel2.Name = "displayLabel2";
			this.displayLabel2.Size = new System.Drawing.Size(70, 12);
			this.displayLabel2.TabIndex = 3;
			this.displayLabel2.Text = "displayLabel2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(254, 205);
			this.Controls.Add(this.displayLabel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.button);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label displayLabel2;
	}
}

