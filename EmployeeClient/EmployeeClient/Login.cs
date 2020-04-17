using EmployeeClient.Admin;
using EmployeeClient.Home11;
using EmployeeClient.Leave;
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
	
	public partial class Login : Form
	{
		public static int sessionId;
		public Login()
		{
			InitializeComponent();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
			ServiceReference1.Employee emp = client.auth(email.Text, pwd.Text);
			if (emp != null)
			{
				Login.sessionId = emp.EmployeeID;
				client.setEmployee(emp);
				if (emp.Role == "Admin")
				{
					this.Hide();
					Index index = new Index();
					index.ShowDialog();
				}

				if (emp.Role == "Employee")
				{
					label5.Text = emp.Fullname + "have succesfully logged in";
					this.Hide();
					EmployeeLeave el = new EmployeeLeave();
					el.ShowDialog();
				}
				else
				{
					label5.Text = "Enter valid credentials";
				}

			}
			else
			{
				label5.Text = "Enter valid credentials";
			}

		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			Reg reg = new Reg();
			reg.ShowDialog();
		}
	}
}



