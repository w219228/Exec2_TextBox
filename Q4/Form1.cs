using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void calcButton1_Click(object sender, EventArgs e)
		{
			try
			{
				PersonCount();
				CarCount();
				Opration();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Opration()
		{
			PersonCount();
			CarCount();
			int personMoney = PersonCount() * 60;
			int carMoney = CarCount() * 200;
			resultLabel.Text = $"人:{personMoney}元 車:{carMoney}元 總計{personMoney + carMoney}元";
		}

		private int CarCount()
		{
			string count = carTextBox.Text;
			bool isInt = int.TryParse(count, out int cc);
			if(isInt==false)
			{
				throw new Exception("請輸入車子數");
			}

			if(cc<0)
			{
				throw new Exception("車數必須大於零");
			}
			return cc;
		}

		private int PersonCount()
		{
			string count = personTextBox.Text;
			bool isInt = int.TryParse(count, out int pc);
			if (isInt == false)
			{
				throw new Exception("請輸入人數");
			}

			if (pc < 0)
			{
				throw new Exception("人數必須大於零");
			}
			return pc;
		}
	}
}
