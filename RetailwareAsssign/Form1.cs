using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RetailwareAssign
{
	public partial class Form1 : Form
	{
		private System.Windows.Forms.Timer timer;
		private int animationStep;

		public Form1()
		{
			InitializeComponent();
			InitializeAnimation();
		}

		private void InitializeAnimation()
		{
			timer = new System.Windows.Forms.Timer();
			timer.Interval = 10; // Set the interval for the timer (10 ms)
			timer.Tick += Timer_Tick;
			animationStep = 0;
			button1.MouseEnter += Button1_MouseEnter;
			button1.MouseLeave += Button1_MouseLeave;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			// Animation logic
			if (animationStep <= 20)
			{
				button1.Size = new Size(button1.Size.Width + 1, button1.Size.Height + 1);
				button1.Location = new Point(button1.Location.X - 1, button1.Location.Y - 1);
				animationStep++;
			}
			else
			{
				timer.Stop();
			}
		}

		private void Button1_MouseEnter(object sender, EventArgs e)
		{
			animationStep = 0;
			timer.Start();
		}

		private void Button1_MouseLeave(object sender, EventArgs e)
		{
			button1.Size = new Size(460, 102);
			button1.Location = new Point(245, 289);
			timer.Stop();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			// Handle label click event if needed
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			// Handle text changed event if needed
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string connectionstring = "Data Source=INF3CTED\\MSSQLSERVERS;Initial Catalog=MyDB;Integrated Security=True;TrustServerCertificate=True";
			using (SqlConnection con = new SqlConnection(connectionstring))
			{
				try
				{
					con.Open();
					MessageBox.Show("Connection Open!");

					// Retrieve values from textboxes
					string Fname = textBox1.Text;
					string Sname = textBox2.Text;

					// Define your INSERT query with parameters
					string insertQuery = "INSERT INTO dbo.Names (FirstName, SecondName) VALUES (@Fname, @Sname)";

					using (SqlCommand cmd = new SqlCommand(insertQuery, con))
					{
						// Add parameters with values to the command
						cmd.Parameters.AddWithValue("@Fname", Fname);
						cmd.Parameters.AddWithValue("@Sname", Sname);

						// Execute the command
						int rowsAffected = cmd.ExecuteNonQuery();
						MessageBox.Show($"{rowsAffected} row(s) inserted.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Cannot open connection! " + ex.Message);
				}
			}
		}
	}
}
