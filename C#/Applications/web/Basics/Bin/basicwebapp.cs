using System;
using System.IO;
using System.Web;

namespace BasicWebApp
{
	public class PageModule : IHttpModule
	{
		public void Init(HttpApplication app)
		{
			app.BeginRequest += delegate(object sender, EventArgs e)
			{
				string path = app.Context.Request.Path;
				if(path.EndsWith(".page"))
					app.Context.RewritePath(path.Replace(".page", ".html"));
			};
		}

		public void Dispose()
		{
			
		}
	}

	public class GreetingHandler : IHttpHandler
	{
		private int count = 0;		

		public void ProcessRequest(HttpContext context)
		{
			TextWriter output = context.Response.Output;
			output.WriteLine("<html>");
			output.WriteLine("<head><title>BasicWebApp</title></head>");
			output.WriteLine("<body>");
			output.WriteLine($"<h1>Welcome Visitor Number {++count}</h1>");
			output.WriteLine($"<b>Time on server: </b>{DateTime.Now}");
			output.WriteLine("</body>");
			output.WriteLine("</html>");
		}

		public bool IsReusable => true;
	}
}