using System;
using System.Windows.Forms;

class MainForm : Form
{
	public MainForm()
	{
		Text = "Hello World!";
	}

	protected override void OnClosed(EventArgs e)
	{
		MessageBox.Show("Goodbye User", "Closing");
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