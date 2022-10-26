using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			displayLabel2.Text = string.Empty;
		}

		private void button_Click(object sender, EventArgs e)
		{
			
			string input = inputTextBox.Text;
			try
			{
				GetInt(input);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}



		private void GetInt(string input)
		{
			
			bool IsInt = int.TryParse(input,out int num);
			if(IsInt == false)
			{
				throw new Exception("請輸入值");
			}

			if (1 <= num && 99 >= num)
			{
				
				displayLabel2.Text = $"{num}在1~99內";
			}
			else
			{
				displayLabel2.Text = $"{num}不在1~99內";
			}
		}
	}
}
