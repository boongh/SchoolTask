using SchoolTask;
using System.Collections;
using System.Diagnostics;
using System.IO;

namespace app
{
	internal class appRun
	{
		private static void Main(string[] args)
		{
			Stopwatch sw = Stopwatch.StartNew();
			SchoolTask.Tasks.Task20b();
			sw.Stop();
			Console.WriteLine(sw.ElapsedMilliseconds);
		}
	}
}