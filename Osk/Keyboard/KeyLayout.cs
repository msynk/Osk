namespace Osk.Keyboard
{
  public class KeyLayout
  {
    public KeyLayout() { }

    public KeyLayout(string name, ushort code, KeyboardKey defaultKey, KeyboardKey shiftedKey = null, KeyboardKey capsLockedKey = null)
    {
      Name = name;
      Code = code;
      Default = defaultKey;
      Shifted = shiftedKey ?? defaultKey;
      CapsLocked = capsLockedKey ?? defaultKey;
    }

    public KeyLayout(string name, ushort code, string title) : this(name, code, title, title) { }

    public KeyLayout(string name, ushort code, string title, string character) : this(name, code, new KeyboardKey(code, title, character)) { }

    public KeyLayout(string name, ushort code, ushort defaultCode, string defaultTitle) : this(name, code, new KeyboardKey(defaultCode, defaultTitle)) { }

    public KeyLayout(string name, ushort code, ushort defaultCode, string defaultTitle, ushort shiftedCode, string shiftedTitle)
      : this(name, code, new KeyboardKey(code, defaultCode, defaultTitle), new KeyboardKey(code, shiftedCode, shiftedTitle)) { }

    public KeyLayout(string name, ushort code, ushort defaultCode, string defaultTitle, ushort shiftedCode, string shiftedTitle, bool isCapLetter = false)
      : this(name, code, new KeyboardKey(code, defaultCode, defaultTitle), new KeyboardKey(code, shiftedCode, shiftedTitle), isCapLetter ? new KeyboardKey(code, shiftedCode, shiftedTitle) : null) { }

    public string Name { get; set; }
    public ushort Code { get; set; }
    public KeyboardKey Default { get; set; }
    public KeyboardKey Shifted { get; set; }
    public KeyboardKey CapsLocked { get; set; }

    public KeyLayout Change(ushort defaultCode, string defaultTitle, ushort shiftedCode, string shiftedTitle, bool isCapLetter = false)
    {
      Default.Unicode = defaultCode;
      Default.Title = defaultTitle;

      Shifted.Unicode = shiftedCode;
      Shifted.Title = shiftedTitle;

      CapsLocked = isCapLetter ? Shifted : Default;

      return this;
    }

    public KeyLayout Change(ushort defaultCode, string defaultTitle, string defaultChar, ushort shiftedCode, string shiftedTitle, string shiftedChar, bool isCapLetter = false)
    {
      Default.Unicode = defaultCode;
      Default.Title = defaultTitle;
      Default.Char = defaultChar;

      Shifted.Unicode = shiftedCode;
      Shifted.Title = shiftedTitle;
      Shifted.Char = shiftedChar;

      CapsLocked = isCapLetter ? Shifted : Default;

      return this;
    }
  }
}
