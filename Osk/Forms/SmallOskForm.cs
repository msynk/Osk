using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Osk.App;
using Osk.Utils;

namespace Osk.Forms
{
  public partial class SmallOskForm : BaseForm
  {
    #region Colors

    private static readonly Color _defaultForeColor = Color.White;
    private static readonly Color _defaultBackColor = Color.FromArgb(25, 25, 40);

    private static readonly Color _activeForeColor = Color.FromArgb(0, 0, 64);
    private static readonly Color _aciveBackColor = Color.FromArgb(70, 25, 180);

    #endregion

    public SmallOskForm()
    {
      InitializeComponent();
    }

    protected override void OnKeyboardStateChanged(KeyboardStateChangedEventArgs e)
    {
      btnLanguage.Text = e.NewLayout.Text;
      SetFormLayout();
    }

    protected override void SetFormLayout()
    {
      ScreenHelper.SetFormLocation(this);
      switch (KeyboardManager.ShiftState)
      {
        case KeyState.None:
          btnRightShift.ForeColor = _defaultForeColor;
          btnRightShift.BackColor = _defaultBackColor;
          btnLeftShift.ForeColor = _defaultForeColor;
          btnLeftShift.BackColor = _defaultBackColor;
          break;
        case KeyState.Temporary:
          btnRightShift.ForeColor = _defaultForeColor;
          btnRightShift.BackColor = _aciveBackColor;
          btnLeftShift.ForeColor = _defaultForeColor;
          btnLeftShift.BackColor = _aciveBackColor;
          break;
        case KeyState.Permanant:
          btnRightShift.ForeColor = _activeForeColor;
          btnRightShift.BackColor = _aciveBackColor;
          btnLeftShift.ForeColor = _activeForeColor;
          btnLeftShift.BackColor = _aciveBackColor;
          break;
      }

      if (KeyboardManager.IsCapsLocked)
      {
        btnCapsLock.ForeColor = _activeForeColor;
        btnCapsLock.BackColor = _aciveBackColor;
      }
      else
      {
        btnCapsLock.ForeColor = _defaultForeColor;
        btnCapsLock.BackColor = _defaultBackColor;
      }

      Controls.Cast<Control>().Where(control => control is Button).Cast<Button>().ToList().ForEach(btn =>
      {
        var keyboardKey = KeyboardManager.Layout[btn.Tag.ToString(), KeyboardManager.ShiftState != KeyState.None, KeyboardManager.IsCapsLocked];
        if (keyboardKey != null)
        {
          btn.Text = keyboardKey.Char;
        }
      });
    }


    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnLanguage_Click(object sender, EventArgs e)
    {
      KeyboardManager.ToggleLanguage();
    }

    private void btn_Click(object sender, EventArgs e)
    {
      var btn = (Button)sender;
      var keyName = btn.Tag.ToString();
      KeyboardManager.HandleKeyPressed(keyName);
    }

    private void btnShowNumpad_Click(object sender, EventArgs e)
    {
      KeyboardManager.Reset();
      AppContext.ShowSmallNumpadForm();
    }
  }
}
