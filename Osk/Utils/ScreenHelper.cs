using System.Drawing;
using System.Windows.Forms;

namespace Osk.Utils
{
  public static class ScreenHelper
  {
    public static void SetFormLocation(Form form)
    {
      var x = Screen.PrimaryScreen.WorkingArea.Width - form.Width;
      var y = Screen.PrimaryScreen.WorkingArea.Height - form.Height;
      form.Location = new Point(form.Location.X, y);
    }
  }
}
