using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void displayButton_Click(object sender, EventArgs e)
		{
			DateTime inputDay;
			string day = inputTextBox.Text;
			try {
				inputDay = GetInputDay(day);
				Compare(day);
			} catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}  
			
		}
		private void Compare(string day)
		{
			DateTime today = DateTime.Today;
			DateTime compareDt = GetInputDay(day);

			if (compareDt > today)
			{
				MessageBox.Show("輸入日期大於今天");
			}
			else
			{
				MessageBox.Show("輸入日期不大於今天");
			}
		}
		private DateTime GetInputDay(string input)
		{
			bool IsDt = DateTime.TryParse(input, out DateTime inputDt);
			return IsDt ? inputDt : throw new Exception("請輸入日期");
		}
	}
}
