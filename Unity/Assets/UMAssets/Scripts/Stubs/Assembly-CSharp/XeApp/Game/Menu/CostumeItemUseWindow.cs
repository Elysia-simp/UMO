using XeSys.Gfx;
using UnityEngine;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class CostumeItemUseWindow : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.LogError(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private AnimeCurveScriptableObject m_animeCurve;
		public int xor;
		[SerializeField]
		private ActionButton m_ItemButton;
	}
}
