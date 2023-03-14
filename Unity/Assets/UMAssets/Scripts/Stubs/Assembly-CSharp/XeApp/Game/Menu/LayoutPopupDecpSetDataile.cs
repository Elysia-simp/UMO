using XeSys.Gfx;
using UnityEngine.UI;
using UnityEngine;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class LayoutPopupDecpSetDataile : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.Log(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private Text m_textDescription;
		[SerializeField]
		private Text m_textCaution;
		[SerializeField]
		private SwapScrollList m_swapScrollList;
	}
}
