using System;
using System.Windows.Forms;
using Osk.Utils;
using Osk.Win32;

namespace Osk.Forms
{
  public class BaseForm : Form
  {
    protected override CreateParams CreateParams
    {
      get
      {
        const int wsExTopmost = 8; // WS_EX_TOPMOST
        const int wsExNoActivate = 0x08000000; // WS_EX_NOACTIVATE
        var par = base.CreateParams;
        if (DesignMode) return par;
        par.ExStyle |= wsExTopmost;
        par.ExStyle |= wsExNoActivate;
        return par;
      }
    }

    protected readonly KeyboardManager KeyboardManager;

    protected BaseForm()
    {
      InitializeComponent();

      KeyboardManager = KeyboardManager.Current;
      KeyboardManager.KeyboardStateChanged += StateManager_KeyboardStateChanged;
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      SetFormLayout();
    }
    protected virtual void SetFormLayout() { }

    private void InitializeComponent()
    {
      this.SuspendLayout();
      // 
      // BaseForm
      // 
      this.ClientSize = new System.Drawing.Size(292, 273);
      this.Name = "BaseForm";
      //this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseDown);
      this.ResumeLayout(false);
    }


    private void StateManager_KeyboardStateChanged(object sender, KeyboardStateChangedEventArgs e)
    {
      OnKeyboardStateChanged(e);
    }

    protected virtual void OnKeyboardStateChanged(KeyboardStateChangedEventArgs e) { }


    #region Move Form

    private void BaseForm_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left) return;

      NativeMethods.ReleaseCapture();
      NativeMethods.SendMessage(Handle, NativeMethods.WmNclbuttondown, NativeMethods.HtCaption, 0);
    }


    protected override void OnMouseDown(MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left) return;
      NativeMethods.ReleaseCapture();
      NativeMethods.SendMessage(Handle, NativeMethods.WmNclbuttondown, NativeMethods.HtCaption, 0);

      base.OnMouseDown(e);
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
      base.OnMouseMove(e);
    }

    //private const int WM_NCHITTEST = 0x84;
    //private const int HTCLIENT = 0x1;
    //private const int HTCAPTION = 0x2;

    //protected override void WndProc(ref Message message)
    //{
    //  base.WndProc(ref message);

    //  if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
    //    message.Result = (IntPtr)HTCAPTION;
    //}

    #endregion
  }
}
