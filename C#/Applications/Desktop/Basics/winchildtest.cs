using System;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

class MainForm : Form
{
	Label outputLabel;
	Button computeButton;

	public MainForm()
	{
		Text = "Hello World!";

		outputLabel = new Label();
		outputLabel.Location = new Point(20, 20);
		outputLabel.Size = new Size(150, 20);
		outputLabel.Text = "Ready";
		Controls.Add(outputLabel);
	
		computeButton = new Button();
		computeButton.Location = new Point(20, 60);
		computeButton.Size = new Size(80, 20);
		computeButton.Text = "Compute";
		computeButton.Click += computeButton_Click;
		Controls.Add(computeButton);
	}

	private async void computeButton_Click(object sender, EventArgs e)
	{
		computeButton.Enabled = false;
		
		Computation c = new Computation();
		int m = Environment.TickCount % 10 + 20;
		long r = await c.ComputeAsync(1, m);

		outputLabel.Text = $"Result = {r}";
		computeButton.Enabled = true;
	}
}

class Computation
{
	public long Compute(int low, int high)
	{
		long total = 0;

		for(int value = low; value <= high; ++value)
		{
			Worker.DoWork(value);
			total += value * value;
		}

		return total;
	}

	public Task<long> ComputeAsync(int low, int high)
	{
		return Task<long>.Run(() => Compute(low, high));
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