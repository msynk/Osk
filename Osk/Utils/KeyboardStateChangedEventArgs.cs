using System;
using Osk.Keyboard;

namespace Osk.Utils
{
  public class KeyboardStateChangedEventArgs: EventArgs
  {
    public KeyboardLayout NewLayout { get; set; }

    public KeyboardStateChangedEventArgs(KeyboardLayout newLayout)
    {
      NewLayout = newLayout;
    }
  }
}
