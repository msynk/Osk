namespace Osk.Keyboard
{
  public class KeyboardKey
  {
    public KeyboardKey() { }

    public KeyboardKey(ushort code, string title) : this(code, title, null) { }

    public KeyboardKey(ushort code, string title, string character) : this(code, code, title, character) { }

    public KeyboardKey(ushort keyCode, ushort unicode, string title) : this(keyCode, unicode, title, null) { }

    public KeyboardKey(ushort keyCode, ushort unicode, string title, string character)
    {
      KeyCode = keyCode;
      Unicode = unicode;
      Title = title;
      Char = character;
    }

    public string Title { get; set; }
    public ushort KeyCode { get; set; }
    public ushort Unicode { get; set; }

    public string Char
    {
      get { return _char ?? (_char = char.ConvertFromUtf32(Unicode)); }
      set { _char = value; }
    }

    private string _char;
  }
}
