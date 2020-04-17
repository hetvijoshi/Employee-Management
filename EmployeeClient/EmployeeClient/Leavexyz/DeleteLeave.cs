using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Leavexyz
{
	public partial class DeleteLeave : Form
	{
		ServiceReference1.Service1Client client;
		public DeleteLeave()
		{
			InitializeComponent();
			client = new ServiceReference1.Service1Client();
			

			int eid = Login.sessionId; ;
			if (eid != 0)
			{
				List<ServiceReference1.Leave> leaves = client.GetLeavesstat(eid).ToList();
				dataGridView1.DataSource = leaves;
			}
			else
			{
				label2.Text = "Enter a valid name two";
			}


		}

		private void button1_Click(object sender, EventArgs e)
		{
			

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex==5)
			{
				int row = e.RowIndex;
				int eid = Login.sessionId;			
				int lid = Convert.ToInt32(dataGridView1.Rows[row].Cells[2].Value);
				
				bool del=client.DeleteLeavewlid(lid);
				if(del==true)
				{
					label2.Text = "Cancelled Successfully";
				}
				else
				{
					label2.Text = "Leave cannot be cancelled";
				}
			}

		}

		
	}
}

