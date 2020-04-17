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
	public partial class Update : Form
	{
		ServiceReference1.Service1Client client;
		public Update()
		{
			InitializeComponent();
			client= new ServiceReference1.Service1Client();
		}

		

		private void button1_Click(object sender, EventArgs e)
		{
			ServiceReference1.Employee emp = new ServiceReference1.Employee();
			emp.Email = email.Text;
			emp.Fullname = name1.Text;
			emp.Experience = exp.Text;
			emp.Phone = phn.Text;
			emp.Qualification = qual.Text;
			client.Update(name.Text, emp) ;
			label2.Text = "updated successfully";

		}

		private void button2_Click(object sender, EventArgs e)
		{
			ServiceReference1.Employee emp = client.Search(name.Text);
			if (emp != null)
			{
				name1.Text = emp.Fullname;
				email.Text = emp.Email;
				qual.Text = emp.Qualification;
				exp.Text = emp.Experience;
				phn.Text = emp.Phone;
			}
			else
			{
				label2.Text = "Invalid name";
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
