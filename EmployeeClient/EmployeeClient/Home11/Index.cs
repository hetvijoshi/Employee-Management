using EmployeeClient.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Home11
{
	public partial class Index : Form
	{
		public Index()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Home home = new Home();
			home.Visible = true;
		}

		

		private void button2_Click_1(object sender, EventArgs e)
		{
			AdminLeave adminLeave = new AdminLeave();
			adminLeave.Visible = true;

		}
	}
}
