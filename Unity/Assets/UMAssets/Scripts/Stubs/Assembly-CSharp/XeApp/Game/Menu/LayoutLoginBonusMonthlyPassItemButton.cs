using XeApp.Game.Common;
using XeSys.Gfx;
using UnityEngine;

namespace XeApp.Game.Menu
{
	public class LayoutLoginBonusMonthlyPassItemButton : ActionButton
	{
		private void Awake()
		{
			TodoLogger.LogError(0, "Implement monobehaviour");
		}
		[SerializeField]
		private RawImageEx m_imageItem;
		[SerializeField]
		private RawImageEx m_imageStamp;
		[SerializeField]
		private NumberBase m_numberCount;
	}
}
