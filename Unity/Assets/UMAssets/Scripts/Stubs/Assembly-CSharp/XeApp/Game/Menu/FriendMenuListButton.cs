using XeApp.Game.Common;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using XeSys.Gfx;

namespace XeApp.Game.Menu
{
	public class FriendMenuListButton : ActionButton
	{
		private void Awake()
		{
			TodoLogger.LogError(0, "Implement monobehaviour");
		}
		[SerializeField]
		private List<Text> m_listCountValues;
		[SerializeField]
		private Text m_listMaxValue;
		[SerializeField]
		private Text m_newCountValue;
		[SerializeField]
		private RawImageEx m_newMarkImage;
	}
}
