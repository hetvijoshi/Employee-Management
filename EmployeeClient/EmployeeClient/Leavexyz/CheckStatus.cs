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
	public partial class CheckStatus : Form
	{
		ServiceReference1.Service1Client client;
		public CheckStatus()
		{
			InitializeComponent();
			int eid = Login.sessionId;
			client = new ServiceReference1.Service1Client();
			ServiceReference1.Employee emp = client.GetEmployee(eid);
			string name = emp.Fullname;
			List<ServiceReference1.Leave> leave= client.GetLeavesemp(name).ToList();
			if(leave!=null)
			{
				dataGridView1.DataSource = leave;
				/*type.Text = leave.Type;
				status.Text = leave.Status;
				des.Text = leave.Description;
				if (leave.Status == "Approve")
				{
					label2.Text = "Congratulations";
				}
				if (leave.Status == "Decline")
				{
					label2.Text = "Better luck next time";
				}
				else
				{
					label2.Text = "Internal Error";
				}*/
			}
			else
			{
				label2.Text = "No leaves requested";
			}
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
