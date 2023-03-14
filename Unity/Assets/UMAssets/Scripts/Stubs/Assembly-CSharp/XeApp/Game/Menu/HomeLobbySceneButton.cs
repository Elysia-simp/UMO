using XeSys.Gfx;
using XeApp.Game.Common;
using UnityEngine;
using UnityEngine.UI;

namespace XeApp.Game.Menu
{
	public class HomeLobbySceneButton : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.Log(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private ActionButton m_sceneBtn;
		[SerializeField]
		private Text m_raidText;
		[SerializeField]
		private Button m_btnHide;
	}
}
