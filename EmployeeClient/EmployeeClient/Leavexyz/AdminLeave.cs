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

namespace EmployeeClient.Admin
{
	public partial class AdminLeave : Form
	{
		ServiceReference1.Service1Client client;
		public static int sessionleave;
		public AdminLeave()
		{
			InitializeComponent();
			client = new ServiceReference1.Service1Client();
		}

		private void AdminLeave_Load(object sender, EventArgs e)
		{
			
			List<ServiceReference1.Leave> leave=client.GetLeaves().ToList();
			List<ServiceReference1.Employee> emplist = client.GetEmployees().ToList();
			if (leave.Count>0)
			{
				//Debug.WriteLine(leave[0].Employee.Fullname);
				//var x = (from sem in leave
				//				   join ses in emplist
				//				   on sem.Employee.EmployeeID equals ses.EmployeeID
				//				   select new
				//				   {
				//					   sem.LeaveId,
				//					   sem.Description,
				//					   sem.Status,
				//					   sem.Type,
				//					   Session = ses.Fullname
									   
				//				   }).ToList();
				dataGridView1.DataSource = leave;
			}
			else
			{
				label1.Text = "No leave requests";
				
			}

		}
		

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 5)
			{
				
				int row = e.RowIndex;
				type.Text= dataGridView1.Rows[row].Cells[4].Value.ToString();
				status.Text= dataGridView1.Rows[row].Cells[3].Value.ToString();
				des.Text= dataGridView1.Rows[row].Cells[2].Value.ToString();
				AdminLeave.sessionleave= Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value);


			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ServiceReference1.Leave leave = new ServiceReference1.Leave();
			leave.Description = des.Text;
			leave.Status = status.Text;
			leave.Type = type.Text;
			leave.LeaveId = sessionleave;
			int eid = Login.sessionId;
			client.UpdateLeave(eid,leave);
			label4.Text = "Updated Succesfully";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
