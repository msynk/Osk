using System;
using System.Windows.Forms;
using Osk.App;
using Osk.Utils;

namespace Osk.Forms
{
  public partial class NumpadForm : BaseForm
  {
    public NumpadForm()
    {
      InitializeComponent();
    }

    protected override void SetFormLayout()
    {
      ScreenHelper.SetFormLocation(this);
    }

    protected override void OnKeyboardStateChanged(KeyboardStateChangedEventArgs e)
    {

    }


    private void btnShowKeyboard_Click(object sender, EventArgs e)
    {
      AppContext.ShowOskForm();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btn_Click(object sender, EventArgs e)
    {
      var btn = (Button)sender;
      var keyName = btn.Tag.ToString();
      KeyboardManager.HandleKeyPressed(keyName);
    }
  }
}
