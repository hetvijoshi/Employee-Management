using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Leave
{
	public partial class EmployeeLeave : Form
	{
		public EmployeeLeave()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			RequestLeave requestLeave = new RequestLeave();
			requestLeave.Visible = true;
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			CheckStatus checkStatus = new CheckStatus();
			checkStatus.Visible=true;
		}

		

		private void button4_Click(object sender, EventArgs e)
		{
			Leavexyz.DeleteLeave delete = new Leavexyz.DeleteLeave();
			delete.Visible = true;
		}
	}
}
