using System.Linq;

namespace Osk.Keyboard
{
  public abstract class KeyboardLayout
  {
    public abstract string Name { get; }
    public abstract string Text { get; }
    public abstract Language Language { get; }

    public KeyLayout this[string name]
    {
      get { return All.SingleOrDefault(k => k.Name == name); }
    }
    public KeyboardKey this[string name, bool isShifted, bool isCapsLocked]
    {
      get
      {
        var keyLayout = All.SingleOrDefault(k => k.Name == name);
        if (keyLayout == null)
        {
          return null;
        }
        return isShifted ? keyLayout.Shifted : isCapsLocked ? keyLayout.CapsLocked : keyLayout.Default;
      }
    }

    private KeyLayout[] _keyLayouts;
    public KeyLayout[] All
    {
      get
      {

        return _keyLayouts ?? (_keyLayouts = new[]
        {
          VkOemBackquote, VkD1, VkD2, VkD3, VkD4, VkD5, VkD6, VkD7, VkD8, VkD9, VkD0, VkOemMinus, VkOemEquals, VkBackspace,
          VkTab, VkQ, VkW, VkE, VkR, VkT, VkY, VkU, VkI, VkO, VkP, VkOemOpenBrackets, VkOemCloseBrackets, VkOemReverseSolidus,
          VkCapsLock, VkA, VkS, VkD, VkF, VkG, VkH, VkJ, VkK, VkL, VkOemSemicolon, VkOemQuotation, VkEnter,
          VkLeftShift, VkZ, VkX, VkC, VkV, VkB, VkN, VkM, VkOemComma, VkOemPeriod, VkOemSolidus, VkRightShift, VkSpace
        });
      }
    }

    #region Keys

    #region 0:  VkOemBackquote ` + ~

    public virtual KeyLayout VkOemBackquote
    {
      get { return _vkOemBackquote ?? (_vkOemBackquote = new KeyLayout("VkOemBackquote", 0x00C0, 0x0060, "Backquote", 0x007E, "Tilde")); }
    }
    protected KeyLayout _vkOemBackquote;

    #endregion

    #region 1:  VkD1 + !

    protected KeyLayout _vkD1;
    public virtual KeyLayout VkD1
    {
      get { return _vkD1 ?? (_vkD1 = new KeyLayout("VkD1", 0x0031, 0x0031, "digit ONE", 0x0021, "Exclamation Mark")); }
    }

    #endregion

    #region 2:  VkD2 + @

    protected KeyLayout _vkD2;
    public virtual KeyLayout VkD2
    {
      get { return _vkD2 ?? (_vkD2 = new KeyLayout("VkD2", 0x0032, 0x0032, "digit TWO", 0x0040, "Amphora, also called the At sign")); }
    }

    #endregion

    #region 3:  VkD3 + #

    protected KeyLayout _vkD3;
    public virtual KeyLayout VkD3
    {
      get { return _vkD3 ?? (_vkD3 = new KeyLayout("VkD3", 0x0033, 0x0033, "digit THREE", 0x0023, "Number sign")); }
    }

    #endregion

    #region 4:  VkD4 + $

    protected KeyLayout _vkD4;
    public virtual KeyLayout VkD4
    {
      get { return _vkD4 ?? (_vkD4 = new KeyLayout("VkD4", 0x0034, 0x0034, "digit FOUR", 0x0024, "Dollar sign")); }
    }

    #endregion

    #region 5:  VkD5 + %

    protected KeyLayout _vkD5;
    public virtual KeyLayout VkD5
    {
      get { return _vkD5 ?? (_vkD5 = new KeyLayout("VkD5", 0x0035, 0x0035, "digit FIVE", 0x0025, "Percent sign")); }
    }

    #endregion

    #region 6:  VkD6 + ^

    protected KeyLayout _vkD6;
    public virtual KeyLayout VkD6
    {
      get { return _vkD6 ?? (_vkD6 = new KeyLayout("VkD6", 0x0036, 0x0036, "digit SIX", 0x005E, "Circumflex accent")); }
    }

    #endregion

    #region 7:  VkD7 + &

    protected KeyLayout _vkD7;
    public virtual KeyLayout VkD7
    {
      get { return _vkD7 ?? (_vkD7 = new KeyLayout("VkD7", 0x0037, 0x0037, "digit SEVEN", 0x0026, "Ampersand")); }
    }

    #endregion

    #region 8:  VkD8 + *

    protected KeyLayout _vkD8;
    public virtual KeyLayout VkD8
    {
      get { return _vkD8 ?? (_vkD8 = new KeyLayout("VkD8", 0x0038, 0x0038, "digit EIGHT", 0x002A, "Asterisk")); }
    }

    #endregion

    #region 9:  VkD9 + (

    protected KeyLayout _vkD9;
    public virtual KeyLayout VkD9
    {
      get { return _vkD9 ?? (_vkD9 = new KeyLayout("VkD9", 0x0039, 0x0039, "digit NINE", 0x0028, "Left Parenthesis")); }
    }

    #endregion

    #region 10: VkD0 + )

    protected KeyLayout _vkD0;
    public virtual KeyLayout VkD0
    {
      get { return _vkD0 ?? (_vkD0 = new KeyLayout("VkD0", 0x0030, 0x0030, "digit ZERO", 0x0029, "Right Parenthesis")); }
    }

    #endregion

    #region 11: VkOemMinus - + _

    protected KeyLayout _vkOemMinus;
    public virtual KeyLayout VkOemMinus
    {
      get { return _vkOemMinus ?? (_vkOemMinus = new KeyLayout("VkOemMinus", 0x00BD, 0x002D, "Hyphen, Minus", 0x005F, "Underscore")); }
    }

    #endregion

    #region 12: VkOemEquals = , +

    protected KeyLayout _vkOemEquals;
    public virtual KeyLayout VkOemEquals
    {
      get { return _vkOemEquals ?? (_vkOemEquals = new KeyLayout("VkOemEquals", 0x0BB, 0x03D, "Equals sign", 0x002B, "Plus sign")); }
    }

    #endregion

    #region ??: VkBackspace

    protected KeyLayout _vkBackspace;
    public virtual KeyLayout VkBackspace
    {
      get { return _vkBackspace ?? (_vkBackspace = new KeyLayout("VkBackspace", 0x0008, "<" /*"Backspace"*/)); }
    }

    #endregion



    #region ??: VkTab

    protected KeyLayout _vkTab;
    public virtual KeyLayout VkTab
    {
      get { return _vkTab ?? (_vkTab = new KeyLayout("VkTab", 0x0009, "Tab")); }
    }

    #endregion

    #region 13: VkQ

    protected KeyLayout _vkQ;
    public virtual KeyLayout VkQ
    {
      get { return _vkQ ?? (_vkQ = new KeyLayout("VkQ", 0x0051, 0x0071, "q", 0x0051, "Q", true)); }
    }

    #endregion

    #region 14: VkW

    protected KeyLayout _vkW;
    public virtual KeyLayout VkW
    {
      get { return _vkW ?? (_vkW = new KeyLayout("VkW", 0x0057, 0x0077, "w", 0x0057, "W", true)); }
    }

    #endregion

    #region 15: VkE

    protected KeyLayout _vkE;
    public virtual KeyLayout VkE
    {
      get { return _vkE ?? (_vkE = new KeyLayout("VkE", 0x0045, 0x0065, "e", 0x0045, "E", true)); }
    }

    #endregion

    #region 16: VkR

    protected KeyLayout _vkR;
    public virtual KeyLayout VkR
    {
      get { return _vkR ?? (_vkR = new KeyLayout("VkR", 0x0052, 0x0072, "r", 0x0052, "R", true)); }
    }

    #endregion

    #region 17: VkT

    protected KeyLayout _vkT;
    public virtual KeyLayout VkT
    {
      get { return _vkT ?? (_vkT = new KeyLayout("VkT", 0x0054, 0x0074, "t", 0x0054, "T", true)); }
    }

    #endregion

    #region 18: VkY

    protected KeyLayout _vkY;
    public virtual KeyLayout VkY
    {
      get { return _vkY ?? (_vkY = new KeyLayout("VkY", 0x0059, 0x0079, "y", 0x0059, "Y", true)); }
    }

    #endregion

    #region 19: VkU

    protected KeyLayout _vkU;
    public virtual KeyLayout VkU
    {
      get { return _vkU ?? (_vkU = new KeyLayout("VkU", 0x0055, 0x0075, "u", 0x0055, "U", true)); }
    }

    #endregion

    #region 20: VkI

    protected KeyLayout _vkI;
    public virtual KeyLayout VkI
    {
      get { return _vkI ?? (_vkI = new KeyLayout("VkI", 0x0049, 0x0069, "i", 0x0049, "I", true)); }
    }

    #endregion

    #region 21: VkO

    protected KeyLayout _vkO;
    public virtual KeyLayout VkO
    {
      get { return _vkO ?? (_vkO = new KeyLayout("VkO", 0x004F, 0x006F, "o", 0x004F, "O", true)); }
    }

    #endregion

    #region 22: VkP

    protected KeyLayout _vkP;
    public virtual KeyLayout VkP
    {
      get { return _vkP ?? (_vkP = new KeyLayout("VkP", 0x0050, 0x0070, "p", 0x0050, "P", true)); }
    }

    #endregion

    #region 23: VkOemOpenBrackets [ + {

    protected KeyLayout _vkOemOpenBrackets;
    public virtual KeyLayout VkOemOpenBrackets
    {
      get { return _vkOemOpenBrackets ?? (_vkOemOpenBrackets = new KeyLayout("VkOemOpenBracket", 0x00DB, 0x005B, "Left Square Bracket", 0x007B, "Left Curly Bracket")); }
    }

    #endregion

    #region 24: VkOemCloseBrackets ] + }

    protected KeyLayout _vkOemCloseBrackets;
    public virtual KeyLayout VkOemCloseBrackets
    {
      get { return _vkOemCloseBrackets ?? (_vkOemCloseBrackets = new KeyLayout("VkOemCloseBrackets", 0x00DD, 0x005D, "Right Square Bracket", 0x007D, "Right Curly Bracket")); }
    }

    #endregion

    #region 25: VkOemReverseSolidus \ + |

    protected KeyLayout _vkOemReverseSolidus;
    public virtual KeyLayout VkOemReverseSolidus
    {
      get { return _vkOemReverseSolidus ?? (_vkOemReverseSolidus = new KeyLayout("VkOemReverseSolidus", 0x00DC, 0x005C, "Reverse Solidus", 0x007C, "Vertical Line")); }
    }

    #endregion



    #region ??: VkCapsLock

    protected KeyLayout _vkCapsLock;
    public virtual KeyLayout VkCapsLock
    {
      get { return _vkCapsLock ?? (_vkCapsLock = new KeyLayout("VkCapsLock", 0x0014, "CapsLock")); }
    }

    #endregion

    #region 26: VkA

    protected KeyLayout _vkA;
    public virtual KeyLayout VkA
    {
      get { return _vkA ?? (_vkA = new KeyLayout("VkA", 0x0041, 0x0061, "a", 0x0041, "A", true)); }
    }

    #endregion

    #region 27: VkS

    protected KeyLayout _vkS;
    public virtual KeyLayout VkS
    {
      get { return _vkS ?? (_vkS = new KeyLayout("VkS", 0x0053, 0x0073, "s", 0x0053, "A", true)); }
    }

    #endregion

    #region 28: VkD

    protected KeyLayout _vkD;
    public virtual KeyLayout VkD
    {
      get { return _vkD ?? (_vkD = new KeyLayout("VkD", 0x0044, 0x0064, "d", 0x0044, "D", true)); }
    }

    #endregion

    #region 29: VkF

    protected KeyLayout _vkF;
    public virtual KeyLayout VkF
    {
      get { return _vkF ?? (_vkF = new KeyLayout("VkF", 0x0046, 0x0066, "f", 0x0046, "F", true)); }
    }

    #endregion

    #region 30: VkG

    protected KeyLayout _vkG;
    public virtual KeyLayout VkG
    {
      get { return _vkG ?? (_vkG = new KeyLayout("VkG", 0x0047, 0x0067, "g", 0x0047, "G", true)); }
    }

    #endregion

    #region 31: VkH

    protected KeyLayout _vkH;
    public virtual KeyLayout VkH
    {
      get { return _vkH ?? (_vkH = new KeyLayout("VkH", 0x0048, 0x0068, "h", 0x0048, "H", true)); }
    }

    #endregion

    #region 32: VkJ

    protected KeyLayout _vkJ;
    public virtual KeyLayout VkJ
    {
      get { return _vkJ ?? (_vkJ = new KeyLayout("VkJ", 0x004A, 0x006A, "j", 0x004A, "J", true)); }
    }

    #endregion

    #region 33: VkK

    protected KeyLayout _vkK;
    public virtual KeyLayout VkK
    {
      get { return _vkK ?? (_vkK = new KeyLayout("VkK", 0x004B, 0x006B, "k", 0x004B, "K", true)); }
    }

    #endregion

    #region 34: VkL

    protected KeyLayout _vkL;
    public virtual KeyLayout VkL
    {
      get { return _vkL ?? (_vkL = new KeyLayout("VkL", 0x004C, 0x006C, "l", 0x004C, "L", true)); }
    }

    #endregion

    #region 35: VkOemSemicolon ; + :

    protected KeyLayout _vkOemSemicolon;
    public virtual KeyLayout VkOemSemicolon
    {
      get { return _vkOemSemicolon ?? (_vkOemSemicolon = new KeyLayout("VkOemSemicolon", 0x00BA, 0x003B, "Semicolon", 0x003A, "Colon")); }
    }

    #endregion

    #region 36: VkOemQuotation ' + "

    protected KeyLayout _vkOemQuotation;
    public virtual KeyLayout VkOemQuotation
    {
      get { return _vkOemQuotation ?? (_vkOemQuotation = new KeyLayout("VkOemQuotation", 0x00DE, 0x0027, "Quotation", 0x0022, "Double-Quotation mark")); }
    }

    #endregion

    #region ??: VkEnter

    protected KeyLayout _vkEnter;
    public virtual KeyLayout VkEnter
    {
      get { return _vkEnter ?? (_vkEnter = new KeyLayout("VkEnter", 0x000D, "Enter")); }
    }

    #endregion


    #region ??: VkLeftShift

    protected KeyLayout _vkLeftShift;
    public virtual KeyLayout VkLeftShift
    {
      get { return _vkLeftShift ?? (_vkLeftShift = new KeyLayout("VkLeftShift", 0x00A0, "LeftShift", "Shift")); }
    }

    #endregion

    #region 37: VkZ

    protected KeyLayout _vkZ;
    public virtual KeyLayout VkZ
    {
      get { return _vkZ ?? (_vkZ = new KeyLayout("VkZ", 0x005A, 0x007A, "z", 0x005A, "Z", true)); }
    }

    #endregion

    #region 38: VkX

    protected KeyLayout _vkX;
    public virtual KeyLayout VkX
    {
      get { return _vkX ?? (_vkX = new KeyLayout("VkX", 0x0058, 0x0078, "x", 0x0058, "X", true)); }
    }

    #endregion

    #region 39: VkC

    protected KeyLayout _vkC;
    public virtual KeyLayout VkC
    {
      get { return _vkC ?? (_vkC = new KeyLayout("VkC", 0x0043, 0x0063, "c", 0x0043, "C", true)); }
    }

    #endregion

    #region 40: VkV

    protected KeyLayout _vkV;
    public virtual KeyLayout VkV
    {
      get { return _vkV ?? (_vkV = new KeyLayout("VkV", 0x0056, 0x0076, "v", 0x0056, "V", true)); }
    }

    #endregion

    #region 41: VkB

    protected KeyLayout _vkB;
    public virtual KeyLayout VkB
    {
      get { return _vkB ?? (_vkB = new KeyLayout("VkB", 0x0042, 0x0062, "b", 0x0042, "B", true)); }
    }

    #endregion

    #region 42: VkN

    protected KeyLayout _vkN;
    public virtual KeyLayout VkN
    {
      get { return _vkN ?? (_vkN = new KeyLayout("VkN", 0x004E, 0x006E, "n", 0x004E, "N", true)); }
    }

    #endregion

    #region 43: VkM

    protected KeyLayout _vkM;
    public virtual KeyLayout VkM
    {
      get { return _vkM ?? (_vkM = new KeyLayout("VkM", 0x004D, 0x006D, "m", 0x004D, "M", true)); }
    }

    #endregion

    #region 44: VkOemComma , + <

    protected KeyLayout _vkOemComma;
    public virtual KeyLayout VkOemComma
    {
      get { return _vkOemComma ?? (_vkOemComma = new KeyLayout("VkOemComma", 0x00BC, 0x002C, "Comma", 0x003C, "Less-than sign")); }
    }

    #endregion

    #region 45: VkOemPeriod . + >

    protected KeyLayout _vkOemPeriod;
    public virtual KeyLayout VkOemPeriod
    {
      get { return _vkOemPeriod ?? (_vkOemPeriod = new KeyLayout("VkOemPeriod", 0x00BE, 0x002E, "Period", 0x003E, "Greater-than sign")); }
    }

    #endregion

    #region 46: VkOemSolidus / + ?

    protected KeyLayout _vkOemSolidus;
    public virtual KeyLayout VkOemSolidus
    {
      get { return _vkOemSolidus ?? (_vkOemSolidus = new KeyLayout("VkOemSolidus", 0x00BF, 0x002F, "Solidus", 0x003F, "Question mark")); }
    }

    #endregion

    #region ??: VkRightShift

    protected KeyLayout _vkRightShift;
    public virtual KeyLayout VkRightShift
    {
      get { return _vkRightShift ?? (_vkRightShift = new KeyLayout("VkRightShift", 0x00A1, "RightShift", "Shift")); }
    }

    #endregion

    #region ??: VkSpace

    protected KeyLayout _vkSpace;
    public virtual KeyLayout VkSpace
    {
      get { return _vkSpace ?? (_vkSpace = new KeyLayout("VkSpace", 0x0020, "Space")); }
    }

    #endregion

    #endregion
  }
}
