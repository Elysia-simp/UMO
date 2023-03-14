using XeSys.Gfx;
using XeApp.Game.Common;
using UnityEngine;

namespace XeApp.Game.Menu
{
	public class LayoutDecorationLeftEditButton : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.Log(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private ActionButton m_leftButton;
		[SerializeField]
		private RawImageEx m_leftButtonFontImage;
		[SerializeField]
		private ActionButton m_rightButton;
		[SerializeField]
		private RawImageEx m_rightButtonFontImage;
	}
}
