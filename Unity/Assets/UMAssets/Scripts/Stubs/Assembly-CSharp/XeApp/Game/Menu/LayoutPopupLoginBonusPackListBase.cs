using XeSys.Gfx;
using UnityEngine.UI;
using UnityEngine;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class LayoutPopupLoginBonusPackListBase : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.LogError(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private ScrollRect m_scrollRect;
		[SerializeField]
		private Scrollbar m_scrollbarV;
		[SerializeField]
		private Scrollbar m_scrollbarH;
		[SerializeField]
		private SwapScrollList m_scrollList;
	}
}
