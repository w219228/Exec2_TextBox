using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void generateButton_Click(object sender, EventArgs e)
		{
			
			try
			{
				DateTime birth =  InputBirth();
				YearSpan(birth);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void YearSpan(DateTime value)
		{
			//DateTime birthyear = InputBirth();
			int birth = (int)value.Year;
			int thisyear = DateTime.Today.Year;
			int yeargap = thisyear - birth;

			if (yeargap>=13)
			{
				MessageBox.Show("滿13歲");
			}
			else
			{
				MessageBox.Show("未滿13歲");
			}
		}

		private DateTime InputBirth()
		{
			string birth = inputTextBox.Text;
			bool IsInt = DateTime.TryParse(birth, out DateTime dt);
			return IsInt? dt : throw new Exception("請輸入生日");
		}
	}
}
