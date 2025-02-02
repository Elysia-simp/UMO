using XeSys.Gfx;
using UnityEngine;
using UnityEngine.UI;

namespace XeApp.Game.Common
{
	public class PopPassListAbout : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.LogError(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private ActionButton m_buttonDetail;
		[SerializeField]
		private ActionButton m_buttonPrivacy;
		[SerializeField]
		private ActionButton m_buttonContract;
		[SerializeField]
		private Text m_text;
	}
}
