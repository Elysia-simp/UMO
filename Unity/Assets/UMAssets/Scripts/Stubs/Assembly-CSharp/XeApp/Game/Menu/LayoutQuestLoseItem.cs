using UnityEngine.UI;
using UnityEngine;

namespace XeApp.Game.Menu
{
	public class LayoutQuestLoseItem : LayoutQuestRewardItem
	{
		private void Awake()
		{
			TodoLogger.LogError(0, "Implement monobehaviour");
		}
		[SerializeField]
		private Text m_textName;
		[SerializeField]
		private Text m_textRecvNum;
		[SerializeField]
		private Text m_textLoseNum;
	}
}
