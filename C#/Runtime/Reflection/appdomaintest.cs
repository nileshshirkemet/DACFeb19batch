using System;
using System.Reflection;
using System.Security;
using System.Security.Permissions;

static class Program
{
	public static void Main()
	{
		var setup = new AppDomainSetup();
		setup.ApplicationBase = "commands";
		var policy = new PermissionSet(PermissionState.None);
		policy.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
		policy.AddPermission(new UIPermission(PermissionState.Unrestricted));
		
		Console.WriteLine("Welcome to our shell");
		for(;;)
		{
			Console.Write("COMMAND: ");
			string cmd = Console.ReadLine();
			if(cmd.Length == 0) continue;
			if(cmd == "quit") break;
			AppDomain sandbox = AppDomain.CreateDomain(cmd, null, setup, policy);
			try
			{
				sandbox.ExecuteAssemblyByName(cmd);
			}
			catch(Exception ex)
			{
				Console.WriteLine($"ERROR: {ex.Message}");
			}
			AppDomain.Unload(sandbox);			
		}
		Console.WriteLine("Goodbye from our shell");
	}
}