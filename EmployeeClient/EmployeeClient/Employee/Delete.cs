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
	public partial class Delete : Form
	{
		public Delete()
		{
			InitializeComponent();
		}

		

		private void button1_Click(object sender, EventArgs e)
		{
			ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
			ServiceReference1.Employee emp= client.Search(name.Text);
			if(emp!=null)
			{
				int eid = emp.EmployeeID;
				ServiceReference1.Leave leave = client.GetLeave(eid);
				if(leave!=null)
				{
					client.DeleteLeave(eid);
				}
				bool del = client.Delete(name.Text);
				if (del == true)
				{
					label2.Text = "Deleted successfully";
				}
				else
				{
					label2.Text = "Enter a valid name";
				}
				
			}
			else
			{
				label2.Text = "Enter a valid name";
			}


		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
