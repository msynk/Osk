using System;
using System.Configuration;

namespace Osk.App
{
  public static class AppSettings
  {
    public static KeyboardStyle KeyboardStyle
    {
      get { return (KeyboardStyle)Enum.Parse(typeof(KeyboardStyle), Get("Keyboard.Style")); }
    }

    private static string Get(string key)
    {
      return ConfigurationManager.AppSettings[key];
    }
  }
}
