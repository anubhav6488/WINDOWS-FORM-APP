using System.Drawing;
using System.Windows.Forms;

namespace RetailwareAssign
{
	partial class Form1
	{
		private Label label1;
		private TextBox textBox1;
		private Button button1;
		private Label label2;
		private TextBox textBox2;
		private Button button2;

		private void InitializeComponent()
		{
			label1 = new Label();
			textBox1 = new TextBox();
			button1 = new Button();
			label2 = new Label();
			textBox2 = new TextBox();
			button2 = new Button();
			SuspendLayout();

			// label1
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 10F, FontStyle.Bold);
			label1.ForeColor = Color.DarkSlateGray;
			label1.Location = new Point(92, 70);
			label1.Size = new Size(94, 19);
			label1.Text = "First Name";

			// textBox1
			textBox1.Font = new Font("Arial", 10F);
			textBox1.Location = new Point(245, 70);
			textBox1.Size = new Size(460, 27);
			textBox1.TextChanged += textBox1_TextChanged;

			// button1 (Save)
			button1.BackColor = Color.DarkSlateGray;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Arial", 12F, FontStyle.Bold);
			button1.ForeColor = Color.White;
			button1.Location = new Point(344, 120); // Position adjusted
			button1.Size = new Size(325, 40); // Adjusted width to accommodate both buttons
			button1.Text = "Save";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;

			// label2
			label2.AutoSize = true;
			label2.Font = new Font("Arial", 10F, FontStyle.Bold);
			label2.ForeColor = Color.DarkSlateGray;
			label2.Location = new Point(70, 180);
			label2.Size = new Size(117, 19);
			label2.Text = "Second Name";

			// textBox2
			textBox2.Font = new Font("Arial", 10F);
			textBox2.Location = new Point(245, 175);
			textBox2.Size = new Size(460, 27);

			// button2 (Fetch)
			button2.BackColor = Color.DarkSlateGray; // Same color as button1
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Arial", 12F, FontStyle.Bold);
			button2.ForeColor = Color.White;
			button2.Location = new Point(ClientSize.Width - button2.Width - 20, ClientSize.Height - button2.Height - 20); // Positioned at bottom right corner
			button2.Size = new Size(125, 40); // Adjusted width
			button2.Text = "Fetch";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;

			// Form1
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightGray;
			ClientSize = new Size(800, 450);
			Controls.Add(button2);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "Form1";
			Text = "User Information";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
