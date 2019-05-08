using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

class Circle : UIElement
{
	protected override void OnRender(DrawingContext dc)
	{
		var da = new DoubleAnimation(100, 10, TimeSpan.FromSeconds(5));
		da.AutoReverse = true;

		var ac = da.CreateClock();
		
		dc.DrawEllipse(Brushes.Red, new Pen(Brushes.Blue, 5), new Point(200, 200), null, 100, ac, 100, ac);
	}

	protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
	{
		InvalidateVisual();
	}
}

class MainWindow : Window
{
	public MainWindow()
	{
		this.Title = "Hello World";
		this.Content = new Circle();
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