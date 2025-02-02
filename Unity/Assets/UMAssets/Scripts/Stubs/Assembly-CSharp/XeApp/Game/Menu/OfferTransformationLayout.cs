using XeSys.Gfx;
using XeApp.Game.Common;
using UnityEngine;
using UnityEngine.UI;

namespace XeApp.Game.Menu
{
	public class OfferTransformationLayout : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.LogError(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private ActionButton Sortie;
		[SerializeField]
		private RawImageEx[] FighterItemIcon;
		[SerializeField]
		private RawImageEx[] GarwalkItemIcon;
		[SerializeField]
		private RawImageEx[] BatroidItemIcon;
		[SerializeField]
		private Text AttackText;
		[SerializeField]
		private Text HitText;
	}
}
