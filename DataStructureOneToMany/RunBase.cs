using System;
using System.Text;

namespace DataStructureOneToMany
{

	public abstract class RunBase
	{
		protected abstract int DemoNumber { get; }
		protected abstract void Implementation();

		public void Run()
		{
			//System.Console.OutputEncoding = Encoding.Unicode; --ruins debug stream in VS Code online/codespace
			Console.WriteLine($"Demo {this.DemoNumber:00} demo");
			this.Implementation();
			Console.WriteLine(new string('-', 20));
		}
	}
}