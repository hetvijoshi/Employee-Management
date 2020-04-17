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
	public partial class Reg : Form
	{
		public Reg()
		{
			InitializeComponent();
		}

		

		private void button1_Click(object sender, EventArgs e)
		{
			ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
			ServiceReference1.Employee emp = new ServiceReference1.Employee();
			emp.Fullname = name.Text;
			emp.Email= email.Text;
			emp.Password = pwd.Text;
			emp.Phone = phn.Text;
			
			emp.Qualification= qual.Text;
			emp.Experience= exp.Text;
			emp.Role = comboBox1.Text;
			

			
			
			
			label5.Text = client.Register(emp).ToString();
			this.Hide();
			Login of = new Login();


			of.ShowDialog();

		}

		
		

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			Login login = new Login();
			login.ShowDialog();
		}
	}
}
