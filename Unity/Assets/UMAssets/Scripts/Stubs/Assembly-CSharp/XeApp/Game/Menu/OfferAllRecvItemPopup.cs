using XeApp.Game.Common;
using UnityEngine.UI;
using UnityEngine;

namespace XeApp.Game.Menu
{
	public class OfferAllRecvItemPopup : SwapScrollListContent
	{
		private void Awake()
		{
			TodoLogger.LogError(0, "Implement monobehaviour");
		}
		[SerializeField]
		private Text m_cautionText;
		[SerializeField]
		private Text m_itemOverText;
		[SerializeField]
		private Text m_ucText;
		[SerializeField]
		private NumberBase m_ucNumber;
		[SerializeField]
		private SwapScrollList m_scrollList;
	}
}
