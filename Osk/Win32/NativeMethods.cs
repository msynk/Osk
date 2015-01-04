using System;
using System.Runtime.InteropServices;

namespace Osk.Win32
{
  public class NativeMethods
  {
    public const uint InputKeyboard = 1; // INPUT_KEYBOARD
    public const uint KeyeventfExtendedkey = 0x0001; // KEYEVENTF_EXTENDEDKEY
    public const uint KeyeventfKeyup = 0x0002; // KEYEVENTF_KEYUP

    [DllImport("user32.dll")]
    public static extern uint SendInput(uint nInputs, ref INPUT pInputs, int cbSize);







    public const int WmNclbuttondown = 0xA1; // WM_NCLBUTTONDOWN

    public const int HtCaption = 0x2; // HT_CAPTION

    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();
  }
  
}
