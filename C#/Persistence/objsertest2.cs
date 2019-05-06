using HR;
using System;
using System.IO;

static class Program
{
	public static void Main(string[] args)
	{
		var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Department));
		if(args.Length > 0)
		{
			Department dept = new Department{Title = args[0]};
			dept.AddEmployee(4, 43000);
			dept.AddEmployee(6, 65000);
			dept.AddEmployee(7, 67000);
			dept.AddEmployee(5, 45000);
			dept.AddEmployee(3, 23000);
			dept.AddEmployee(2, 13000);
			var target = new FileStream("dept.xml", FileMode.Create);
			serializer.Serialize(target, dept);
			target.Close();
		}
		else
		{
			var source = new FileStream("dept.xml", FileMode.Open);
			Department dept = (Department)serializer.Deserialize(source);
			source.Close();
			Console.WriteLine($"Employees of {dept.Title} department");
			foreach(var emp in dept.Employees)
				Console.WriteLine(emp);
		}
	}
}