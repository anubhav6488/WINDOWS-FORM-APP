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

		private void InitializeComponent()
		{
			label1 = new Label();
			textBox1 = new TextBox();
			button1 = new Button();
			label2 = new Label();
			textBox2 = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 10F, FontStyle.Bold);
			label1.ForeColor = Color.DarkSlateGray;
			label1.Location = new Point(92, 70);
			label1.Name = "label1";
			label1.Size = new Size(94, 19);
			label1.TabIndex = 0;
			label1.Text = "First Name";
			label1.Click += label1_Click;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Arial", 10F);
			textBox1.Location = new Point(245, 70);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(460, 27);
			textBox1.TabIndex = 1;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// button1
			// 
			button1.BackColor = Color.DarkSlateGray;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Arial", 12F, FontStyle.Bold);
			button1.ForeColor = Color.White;
			button1.Location = new Point(245, 289);
			button1.Name = "button1";
			button1.Size = new Size(460, 102);
			button1.TabIndex = 2;
			button1.Text = "Save";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Arial", 10F, FontStyle.Bold);
			label2.ForeColor = Color.DarkSlateGray;
			label2.Location = new Point(70, 180);
			label2.Name = "label2";
			label2.Size = new Size(117, 19);
			label2.TabIndex = 3;
			label2.Text = "Second Name";
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Arial", 10F);
			textBox2.Location = new Point(245, 175);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(460, 27);
			textBox2.TabIndex = 4;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightGray;
			ClientSize = new Size(800, 450);
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
