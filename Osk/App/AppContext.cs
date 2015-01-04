using System;
using System.Windows.Forms;
using Osk.Forms;
using Osk.Utils;

namespace Osk.App
{
  public class AppContext : ApplicationContext
  {
    private static AppContext _current;
    public static AppContext Current { get { return _current ?? (_current = new AppContext()); } }

    public static void ShowOskForm()
    {
      Current.SwitchToOskForm();
    }
    public static void ShowNumpadForm()
    {
      Current.SwitchToNumpadForm();
    }

    public static void ShowSmallOskForm()
    {
      Current.SwitchToSmallOskForm();
    }
    public static void ShowSmallNumpadForm()
    {
      Current.SwitchToSmallNumpadForm();
    }
    
    public static void ShowAlphabetForm()
    {
      Current.SwitchToAlphabetForm();
    }
    public static void ShowSymbolForm()
    {
      Current.SwitchToSymbolForm();
    }





    private readonly KeyboardManager _keyboardManager;
    private OskForm _oskForm;
    private NumpadForm _numpadForm;

    private SmallOskForm _smallOskForm;
    private SmallNumpadForm _smallNumpadForm;

    private AlphabetForm _alphabetForm;
    private SymbolForm _symbolForm;

    private AppContext()
    {
      InitializeForms();
      SetMainForm();
      _keyboardManager = KeyboardManager.Current;
    }

    private void InitializeForms()
    {
      _oskForm = new OskForm();
      _numpadForm = new NumpadForm();

      _smallOskForm = new SmallOskForm();
      _smallNumpadForm = new SmallNumpadForm();

      _alphabetForm = new AlphabetForm();
      _symbolForm = new SymbolForm();
    }


    public void SwitchToOskForm()
    {
      var form = MainForm;
      MainForm = _oskForm;
      form.Hide();
      MainForm.Show();
    }
    public void SwitchToNumpadForm()
    {
      var form = MainForm;
      MainForm = _numpadForm;
      form.Hide();
      MainForm.Show();
    }

    public void SwitchToSmallOskForm()
    {
      var form = MainForm;
      MainForm = _smallOskForm;
      form.Hide();
      MainForm.Show();
    }
    public void SwitchToSmallNumpadForm()
    {
      var form = MainForm;
      MainForm = _smallNumpadForm;
      form.Hide();
      MainForm.Show();
    }
    
    public void SwitchToAlphabetForm()
    {
      var form = MainForm;
      MainForm = _alphabetForm;
      form.Hide();
      MainForm.Show();
    }
    public void SwitchToSymbolForm()
    {
      var form = MainForm;
      MainForm = _symbolForm;
      form.Hide();
      MainForm.Show();
    }

    protected override void OnMainFormClosed(object sender, EventArgs e)
    {
      _keyboardManager.Reset();

      base.OnMainFormClosed(sender, e);
    }

    private void SetMainForm()
    {
      switch (AppSettings.KeyboardStyle)
      {
        case KeyboardStyle.Normal:
          MainForm = new OskForm();
          break;
        case KeyboardStyle.Small:
          MainForm = new SmallOskForm();
          break;
        case KeyboardStyle.Simple:
          MainForm = new AlphabetForm();
          break;
      }
    }
  }
}
