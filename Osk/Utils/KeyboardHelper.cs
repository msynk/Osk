using System.Runtime.InteropServices;
using Osk.Win32;

namespace Osk.Utils
{
  public static class KeyboardHelper
  {
    public static void PressKey(ushort keyCode)
    {
      var input = new INPUT
      {
        type = 1,
        ki = { wScan = 0, time = 0, dwFlags = 0, dwExtraInfo = 0, wVk = keyCode }
      };
      NativeMethods.SendInput(1, ref input, Marshal.SizeOf(input));
    }

    public static void ReleaseKey(ushort keyCode)
    {
      var input = new INPUT
      {
        type = 1,
        ki = { wScan = 0, time = 0, dwExtraInfo = 0, dwFlags = NativeMethods.KeyeventfKeyup, wVk = keyCode }
      };
      NativeMethods.SendInput(1, ref input, Marshal.SizeOf(input));
    }
  }
}
