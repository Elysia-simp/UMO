using XeSys.Gfx;
using XeApp.Game.Common;
using UnityEngine;

namespace XeApp.Game.Menu
{
	public class EventStoryList : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.Log(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private SwapScrollList m_swapScrollList;
	}
}
