using System.Runtime.InteropServices;

namespace Osk.Win32
{
  [StructLayout(LayoutKind.Explicit, Size = 28)]
  public struct INPUT
  {
    [FieldOffset(0)]
    public uint type;
    [FieldOffset(4)]
    public KEYBDINPUT ki;
  };
}