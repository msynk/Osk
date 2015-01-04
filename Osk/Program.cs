using System;
using System.Threading;
using System.Windows.Forms;
using Osk.App;

namespace Osk
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      bool createdNew;
      var mutex = new Mutex(true, "MSYNK:Osk", out createdNew);
      if (!createdNew) return;

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(AppContext.Current);

      mutex.ReleaseMutex();
    }
  }
}
