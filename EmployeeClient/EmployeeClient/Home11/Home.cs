using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Reg f1 = new Reg();
			f1.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Delete f4 = new Delete();
			f4.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Update up = new Update();
			up.ShowDialog();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
