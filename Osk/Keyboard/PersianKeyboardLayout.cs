namespace Osk.Keyboard
{
  public class PersianKeyboardLayout : KeyboardLayout
  {
    public override string Name { get { return "Persian"; } }

    public override string Text { get { return "فارسی"; } }

    public override Language Language { get { return Language.Persian; } }

    #region Keys

    #region 13: VkQ: DAD ض + Fathatan ً

    /// <summary> 
    /// 13  Arabic letter DAD
    /// </summary>
    public override KeyLayout VkQ
    {
      get { return _vkQ ?? (_vkQ = base.VkQ.Change(0x0636, "U+0636 Arabic letter DAD", 0x064B, "U+064B Arabic Fathatan")); }
    }

    #endregion

    #region 14: VkW: SAD ص + Dammatan ٌ

    /// <summary>
    /// 14  Arabic letter SAD
    /// </summary>
    public override KeyLayout VkW
    {
      get { return _vkW ?? (_vkW = base.VkW.Change(0x0635, "U+0635 Arabic letter SAD", 0x064C, "U+064C Arabic Dammatan")); }
    }

    #endregion

    #region 15: VkE: THEH ث + Kasratan ٍ

    /// <summary>
    /// 15  Arabic letter THA, or THEH, DAMMA
    /// </summary>
    public override KeyLayout VkE
    {
      get { return _vkE ?? (_vkE = base.VkE.Change(0x062B, "U+062B Arabic letter THEH", 0x064D, "U+064D Arabic Kasratan")); }
    }

    #endregion

    #region 16: VkR: QAF ق + RIAL ريال

    /// <summary>
    /// 16  Arabic letter QAF
    /// </summary>
    public override KeyLayout VkR
    {
      get { return _vkR ?? (_vkR = base.VkR.Change(0x0642, "U+0642 Arabic letter QAF", null, 0x0642, "U+0642 Arabic letter QAF", "ريال")); }
      //_vkR = new KeyLayout("VkR", 0x0642, 0x0631 + 0x064A + 0x0627 + 0x0644, "U+062B0642 Arabic letter QAF", "U+0631 Arabic letter REH + U+064A Arabic letter YEH + U+0627 Arabic letter ALEF + U+0644 Arabic letter LAM  ريال", true);
    }

    #endregion

    #region 17: VkT: FEH ف + Arabic Comma ،

    /// <summary>
    /// 17  Arabic letter FA, or FEH
    /// </summary>
    public override KeyLayout VkT
    {
      get { return _vkT ?? (_vkT = base.VkT.Change(0x0641, "U+0641 Arabic letter FEH", 0x060C, "U+060C Arabic Comma")); }
    }

    #endregion

    #region 18: VkY: GHAYN ق + Arabic Semicolon ؛

    /// <summary>
    /// 18  Arabic letter GHAYN, or GHAIN
    /// </summary>
    public override KeyLayout VkY
    {
      get { return _vkY ?? (_vkY = base.VkY.Change(0x063A, "U+063A Arabic letter GHAYN", 0x061B, "U+061B Arabic Semicolon")); }
    }

    #endregion

    #region 19: VkU: AYN ع + Comma ,

    /// <summary>
    /// 19  Arabic letter AYN, or AIN
    /// </summary>
    public override KeyLayout VkU
    {
      get { return _vkU ?? (_vkU = base.VkU.Change(0x0639, "U+0639 Arabic letter AYN", 0x002C, "U+002C Comma")); }
    }

    #endregion

    #region 20: VkI: HEH ه + Right Square Bracket ]

    /// <summary>
    /// 20  Arabic letter HA
    /// </summary>
    public override KeyLayout VkI
    {
      get { return _vkI ?? (_vkI = base.VkI.Change(0x0647, "U+0665 Arabic letter HEH", 0x005D, "U+005D Right Square Bracket")); }
    }

    #endregion

    #region 21: VkO: KHAH خ + Left Square Bracket [

    /// <summary>
    /// 21  Arabic letter KHA
    /// </summary>
    public override KeyLayout VkO
    {
      get { return _vkO ?? (_vkO = base.VkO.Change(0x062E, "U+0681 Arabic letter KHAH", 0x005B, "U+005B Left Square Bracket")); }
    }

    #endregion

    #region 22: VkP: HAH ح + Reverse Solidus \

    /// <summary>
    /// 22  Arabic letter KA
    /// </summary>
    public override KeyLayout VkP
    {
      get { return _vkP ?? (_vkP = base.VkP.Change(0x062D, "U+062D Arabic letter HAH", 0x005C, "U+005C Reverse Solidus")); }
    }

    #endregion


    #region 23: VK_OemOpenBrackes (VK_OEM_4): JEEM ج + Right Curly Bracket }

    /// <summary>
    /// 23  Arabic letter JEEM
    /// </summary>
    public override KeyLayout VkOemOpenBrackets
    {
      get { return _vkOemOpenBrackets ?? (_vkOemOpenBrackets = base.VkOemOpenBrackets.Change(0x062C, "U+062C Arabic letter JEEM", 0x007D, "Right Curly Bracket")); }
    }

    #endregion

    #region 24: VkOemCloseBrackets: TCHEH چ + Left Curly Bracket {

    /// <summary>
    /// 24  Arabic letter TCHEH
    /// </summary>
    public override KeyLayout VkOemCloseBrackets
    {
      get { return _vkOemCloseBrackets ?? (_vkOemCloseBrackets = base.VkOemCloseBrackets.Change(0x0686, "U+0686 Arabic letter TCHEH", 0x007B, "Left Curly Bracket")); }
    }

    #endregion

    #region 25: VkOemReverseSolidus: PEH پ + Vertical Line |

    /// <summary>
    /// 25 Arabic letter PEH
    /// </summary>
    public override KeyLayout VkOemReverseSolidus
    {
      get { return _vkOemReverseSolidus ?? (_vkOemReverseSolidus = base.VkOemReverseSolidus.Change(0x067E, "U+067E Arabic letter PEH", 0x007C, "Vertical Line")); }
    }

    #endregion

    #region 26: VkA: SHEEN ش + Fatha َ

    /// <summary>
    /// 26  Arabic letter SHIN, or SHEEN
    /// </summary>
    public override KeyLayout VkA
    {
      get { return _vkA ?? (_vkA = base.VkA.Change(0x0634, "U+0634 Arabic letter SHEEN", 0x064E, "U+064E Arabic Fatha")); }
    }

    #endregion

    #region 27: VkS: SEEN س + Damma ُ

    /// <summary>
    /// 27  Arabic letter SIN, or SEEN
    /// </summary>
    public override KeyLayout VkS
    {
      get { return _vkS ?? (_vkS = base.VkS.Change(0x0633, "U+0633 Arabic letter SEEN", 0x064F, "U+064F Arabic Damma")); }
    }

    #endregion

    #region 28: VkD: Farsi YEH ی + Kasra ِ

    /// <summary>
    /// 28  Arabic letter Farsi YEH
    /// </summary>
    public override KeyLayout VkD
    {
      get { return _vkD ?? (_vkD = base.VkD.Change(0x06CC, "U+06CC Arabic letter Farsi YEH", 0x0650, "U+0650 Arabic Kasra")); }
    }

    #endregion

    #region 29: VkF: BEH ب + Shadda ّ

    /// <summary>
    /// 29  Arabic letter BA, or BEH
    /// </summary>
    public override KeyLayout VkF
    {
      get { return _vkF ?? (_vkF = base.VkF.Change(0x0628, "U+0628 Arabic letter BEH", 0x0651, "U+0651 Arabic Shadda")); }
    }

    #endregion

    #region 30: VkG: LAM ل + HEH with YEH above ۀ

    /// <summary>
    /// 30  Arabic letter LAM
    /// </summary>
    public override KeyLayout VkG
    {
      get { return _vkG ?? (_vkG = base.VkG.Change(0x0644, "U+0644 Arabic letter LAM", 0x06C0, "U+06C0 Arabic letter HEH with YEH above")); }
    }

    #endregion

    #region 31: VkH: ALEF ا + ALEF with MADDA above آ

    /// <summary>
    /// 31  Arabic letter ALIF, or ALEF 
    /// </summary>
    public override KeyLayout VkH
    {
      get { return _vkH ?? (_vkH = base.VkH.Change(0x0627, "U+0627 Arabic letter ALEF", 0x0622, "U+0622 Arabic letter ALEF with MADDA above")); }
    }

    #endregion

    #region 32: VkJ: TEH ت + Tatweel ـ

    /// <summary>
    /// 32  Arabic letter TA, or TEH
    /// </summary>
    public override KeyLayout VkJ
    {
      get { return _vkJ ?? (_vkJ = base.VkJ.Change(0x062A, "U+062A Arabic letter TEH", 0x0640, "U+0640 Arabic Tatweel")); }
    }

    #endregion

    #region 33: VkK: NOON ن + Left-pointing double angle quotation mark «

    /// <summary>
    /// 33  Arabic letter NUN, or NOON
    /// </summary>
    public override KeyLayout VkK
    {
      get { return _vkK ?? (_vkK = base.VkK.Change(0x0646, "U+0646 Arabic letter NOON", 0x00AB, "U+00AB Left-pointing double angle quotation mark")); }
    }

    #endregion

    #region 34: VkL: MEEM م + Right-pointing double angle quotation mark »

    /// <summary>
    /// 34  Arabic letter MIM, or MEEM
    /// </summary>
    public override KeyLayout VkL
    {
      get { return _vkL ?? (_vkL = base.VkL.Change(0x0645, "U+0645 Arabic letter MEEM", 0x00BB, "U+00BB Right-pointing double angle quotation mark")); }
    }

    #endregion

    #region 35: VkOemSemicolon: KEHEH ک + Colon :

    /// <summary>
    /// 35  Arabic Letter KEHEH
    /// </summary>
    public override KeyLayout VkOemSemicolon
    {
      get { return _vkOemSemicolon ?? (_vkOemSemicolon = base.VkOemSemicolon.Change(0x06A9, "U+0643 Arabic Letter KEHEH", 0x003A, "Colon")); }
    }

    #endregion

    #region 36: VkOemQuotation: GAF گ + Double-Quotation mark "

    /// <summary>
    /// 36  Arabic letter GAF
    /// </summary>
    public override KeyLayout VkOemQuotation
    {
      get { return _vkOemQuotation ?? (_vkOemQuotation = base.VkOemQuotation.Change(0x06AF, "U+06AF Arabic letter GAF", 0x0022, "Double-Quotation mark")); }
    }

    #endregion


    #region 37: VkZ: ZAH ظ + TEH Marbuta ة

    /// <summary>
    /// 37  Arabic letter ZAH
    /// </summary>
    public override KeyLayout VkZ
    {
      get { return _vkZ ?? (_vkZ = base.VkZ.Change(0x0638, "U+0638 Arabic letter ZAH", 0x0629, "U+0629 Arabic letter TEH Marbuta")); }
    }

    #endregion

    #region 38: VkX: TAH ط + YEH ي

    /// <summary>
    /// 38  Arabic letter TAH 
    /// </summary>
    public override KeyLayout VkX
    {
      get { return _vkX ?? (_vkX = base.VkX.Change(0x0637, "U+0637 Arabic letter TAH", 0x064A, "U+064A Arabic letter YEH")); }
    }

    #endregion

    #region 39: VkC: ZAIN ز + JEH ژ

    /// <summary>
    /// 39  Arabic letter ZAIN
    /// </summary>
    public override KeyLayout VkC
    {
      get { return _vkC ?? (_vkC = base.VkC.Change(0x0632, "U+0632 Arabic letter ZAIN", 0x0698, "U+0698 Arabic letter JEH")); }
    }

    #endregion

    #region 40: VkV: REH ر + WAW with hamza above ؤ

    /// <summary>
    /// 40  Arabic letter RA, or REH
    /// </summary>
    public override KeyLayout VkV
    {
      get { return _vkV ?? (_vkV = base.VkV.Change(0x0631, "U+0631 Arabic letter REH", 0x0624, "U+0624 Arabic letter WAW with hamza above")); }
    }

    #endregion

    #region 41: VkB: Thal ذ + ALEF with hamza below إ

    /// <summary>
    /// 41  Arabic letter Thal
    /// </summary>
    public override KeyLayout VkB
    {
      get { return _vkB ?? (_vkB = base.VkB.Change(0x0630, "U+0438 Arabic letter Thal", 0x0625, "U+0625 Arabic letter ALEF with hamza below")); }
    }

    #endregion

    #region 42: VkN: DAL د + ALEF with hamza above أ

    /// <summary>
    /// 42  Arabic letter DAL
    /// </summary>
    public override KeyLayout VkN
    {
      get { return _vkN ?? (_vkN = base.VkN.Change(0x062F, "U+062F Arabic letter DAL", 0x0623, "U+0623 Arabic letter ALEF with hamza above")); }
    }

    #endregion

    #region 43: VkM: YEH with hamza above ئ + HAMZA ء

    /// <summary>
    /// 43  Arabic letter YEH with hamza above
    /// </summary>
    public override KeyLayout VkM
    {
      get { return _vkM ?? (_vkM = base.VkM.Change(0x0626, "U+0626 Arabic letter YEH with hamza above", 0x0621, "U+0621 Arabic letter HAMZA")); }
    }

    #endregion

    #region 44: VkOemComma: WAW و + Less-than sign + <

    /// <summary>
    /// 44  Arabic letter WAW
    /// </summary>
    public override KeyLayout VkOemComma
    {
      get { return _vkOemComma ?? (_vkOemComma = base.VkOemComma.Change(0x0648, "U+0648 Arabic letter WAW", 0x003C, "U+003C Less-than sign")); }
    }

    #endregion

    #region 46: VkOemSolidus / + Arabic Question Mark ؟

    /// <summary>
    /// 46  Solidus
    /// </summary>
    public override KeyLayout VkOemSolidus
    {
      get { return _vkOemSolidus ?? (_vkOemSolidus = base.VkOemSolidus.Change(0x002F, "U+002F Solidus", 0x061F, "U+061F Arabic Question Mark")); }
    }

    #endregion

    #endregion
  }
}
