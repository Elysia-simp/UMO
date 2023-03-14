using XeSys.Gfx;
using UnityEngine.UI;
using UnityEngine;

namespace XeApp.Game.Menu
{
	public class LayoutPopupAchieveRewardItem : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.Log(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private Text m_itemDesc;
		[SerializeField]
		private Text m_conditionsDesc;
		[SerializeField]
		private RawImageEx m_icon;
	}
}
