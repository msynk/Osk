namespace Osk.Win32
{
  public struct KEYBDINPUT
  {
    public ushort wVk;
    public ushort wScan;
    public uint dwFlags;
    public long time;
    public uint dwExtraInfo;
  };
}