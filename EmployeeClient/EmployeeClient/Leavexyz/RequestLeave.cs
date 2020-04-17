using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmployeeClient.Leave
{
	public partial class RequestLeave : Form
	{
		public Login login;
		ServiceReference1.Service1Client client;
		public RequestLeave()
		{
			InitializeComponent();
			client = new ServiceReference1.Service1Client();


		}

		private void button1_Click(object sender, EventArgs e)
		{
			int eid = Login.sessionId;
			Debug.WriteLine("+++" + eid);
			ServiceReference1.Leave leave = new ServiceReference1.Leave();
			ServiceReference1.Employee emp = client.GetEmployee(eid);
			leave.Type = comboBox1.Text;
			leave.Description = des.Text;
			leave.Status = "Pending...";
			if(client.ReqLeave(leave,eid))
			{
				label3.Text = "Leave requested";
			}
			else
			{
				label3.Text = "Something went wrong.";
			}
			
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
