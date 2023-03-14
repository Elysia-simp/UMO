using XeSys.Gfx;
using UnityEngine;
using XeApp.Game.Common;
using UnityEngine.UI;

namespace XeApp.Game.Menu
{
	public class GrowthNeedItemIcon : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.Log(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private RawImageEx m_iconImage;
		[SerializeField]
		private NumberBase m_number;
		[SerializeField]
		private Text m_haveText;
		[SerializeField]
		private StayButton m_button;
		[SerializeField]
		private AnimeCurveScriptableObject m_animeCurve;
	}
}
