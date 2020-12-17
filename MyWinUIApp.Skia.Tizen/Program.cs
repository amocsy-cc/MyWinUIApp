using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace MyWinUIApp.Skia.Tizen
{
	class Program
	{
		static void Main(string[] args)
		{
			var host = new TizenHost(() => new MyWinUIApp.App(), args);
			host.Run();
		}
	}
}
