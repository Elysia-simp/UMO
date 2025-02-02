using XeSys.Gfx;
using UnityEngine;
using UnityEngine.UI;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class LayoutGetBingoReward : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.LogError(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private RawImageEx ItemIcon;
		[SerializeField]
		private RawImageEx SceneIcon;
		[SerializeField]
		private Text ItemName;
		[SerializeField]
		private ActionButton ItemIconButton;
		[SerializeField]
		private ActionButton SceneIconButton;
	}
}
