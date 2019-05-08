using System;
using System.Windows;

class MainWindow : Window
{
	public MainWindow()
	{
		this.Title = "Hello World";
	}
}

static class Program
{
	[STAThread]
	public static void Main()
	{
		Application app = new Application();
		app.Run(new MainWindow());
	}
}