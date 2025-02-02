using XeSys.Gfx;
using XeApp.Game.Common;
using UnityEngine;
using UnityEngine.UI;

namespace XeApp.Game.Menu
{
	public class LayoutPopupQuestRewardList : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.LogError(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private SwapScrollList m_scrollList;
		[SerializeField]
		private Text m_textHeader;
		[SerializeField]
		private Text m_textCaution;
		[SerializeField]
		private Text m_textDesc;
	}
}
