using System;
using System.Drawing;
using System.Windows.Forms;

class MainForm : Form
{
	public MainForm()
	{
		Text = "Hello World!";
		Size = new Size(400, 400);
		BackColor = Color.FromArgb(255, 250, 245);
	}

	protected override void OnPaint(PaintEventArgs e)	
	{
		using(var br = new SolidBrush(Color.Red))
			e.Graphics.FillEllipse(br, 150, 150, 100, 100);

		using(var pn = new Pen(Color.Blue, 5))
			e.Graphics.DrawEllipse(pn, 150, 150, 100, 100);
	}
}

static class Program
{
	[STAThread]
	public static void Main()
	{
		Application.Run(new MainForm());
	}
}