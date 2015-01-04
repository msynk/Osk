using System;
using Osk.Keyboard;

namespace Osk.Utils
{
  public class KeyboardManager
  {
    private static KeyboardManager _current;
    public static KeyboardManager Current { get { return _current ?? (_current = new KeyboardManager()); } }



    public event EventHandler<KeyboardStateChangedEventArgs> KeyboardStateChanged;
    private void OnKeyboardStateChanged(KeyboardStateChangedEventArgs e)
    {
      var handler = KeyboardStateChanged;
      if (handler != null) handler(null, e);
    }

    public static readonly KeyboardLayout EnglishLayout = new EnglishKeyboardLayout();
    public static readonly KeyboardLayout PersianLayout = new PersianKeyboardLayout();

    public static readonly KeyboardKey RightShift = EnglishLayout["VkRightShift"].Default;
    public static readonly KeyboardKey LeftShift = EnglishLayout["VkLeftShift"].Default;
    public static readonly KeyboardKey CapsLcok = EnglishLayout["VkCapsLock"].Default;

    private const ushort AltKey = 0x0012;
    private KeyboardManager()
    {
      Layout = EnglishLayout;
    }

    public KeyState ShiftState { get; private set; }
    public bool IsCapsLocked { get; private set; }

    private KeyboardLayout _layout;
    public KeyboardLayout Layout
    {
      get { return _layout; }
      private set
      {
        _layout = value;
        OnKeyboardStateChanged(new KeyboardStateChangedEventArgs(_layout));
      }
    }


    public void ToggleLanguage()
    {
      ChangeKeyboardLanguage();
      Layout = Layout == EnglishLayout ? PersianLayout : EnglishLayout;
    }

    private void ChangeKeyboardLanguage()
    {
      KeyboardHelper.PressKey(AltKey);
      KeyboardHelper.PressKey(RightShift.KeyCode);

      KeyboardHelper.ReleaseKey(RightShift.KeyCode);
      KeyboardHelper.ReleaseKey(AltKey);
    }


    public void ToggleShift()
    {
      var next = (int)ShiftState + 1;
      if (next > 2)
      {
        next = 0;
      }
      ShiftState = (KeyState)next;
    }


    public void HandleKeyPressed(string keyName)
    {
      var stateChanged = false;
      if (keyName.Contains("Shift"))
      {
        ToggleShift();
        stateChanged = true;
      }
      else if (ShiftState == KeyState.Temporary)
      {
        ShiftState = KeyState.None;
        stateChanged = true;
      }

      var keyCode = Layout[keyName, ShiftState != KeyState.None, IsCapsLocked].KeyCode;
      KeyboardHelper.PressKey(keyCode);

      if (ShiftState == KeyState.None)
      {
        KeyboardHelper.ReleaseKey(RightShift.KeyCode);
        KeyboardHelper.ReleaseKey(LeftShift.KeyCode);
      }

      if (keyCode != RightShift.Unicode && keyCode != LeftShift.Unicode)
      {
        KeyboardHelper.ReleaseKey(keyCode);
      }

      if (keyCode == CapsLcok.KeyCode)
      {
        IsCapsLocked = !IsCapsLocked;
        stateChanged = true;
      }

      if (stateChanged)
      {
        OnKeyboardStateChanged(new KeyboardStateChangedEventArgs(Layout));
      }
    }

    public void Reset()
    {
      var stateChanged = false;
      if (ShiftState != KeyState.None)
      {
        KeyboardHelper.ReleaseKey(RightShift.KeyCode);
        KeyboardHelper.ReleaseKey(LeftShift.KeyCode);
        ShiftState = KeyState.None;
        stateChanged = true;
      }

      if (Layout.Language != Language.English)
      {
        ToggleLanguage();
        stateChanged = true;
      }

      if (stateChanged)
      {
        OnKeyboardStateChanged(new KeyboardStateChangedEventArgs(Layout));
      }
    }
  }
}
