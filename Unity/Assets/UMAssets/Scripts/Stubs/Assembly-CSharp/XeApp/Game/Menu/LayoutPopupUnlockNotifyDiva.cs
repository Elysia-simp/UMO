using XeSys.Gfx;
using UnityEngine.UI;
using UnityEngine;

namespace XeApp.Game.Menu
{
	public class LayoutPopupUnlockNotifyDiva : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.LogError(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private Text m_divaName;
		[SerializeField]
		private Text m_desc;
		[SerializeField]
		private RawImageEx m_divaImage;
	}
}
