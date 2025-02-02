using XeApp.Game.Common;
using UnityEngine;
using XeSys.Gfx;
using UnityEngine.UI;
using System.Collections.Generic;

namespace XeApp.Game.Menu
{
	public class OfferSelectContent : SwapScrollListContent
	{
		private void Awake()
		{
			TodoLogger.LogError(0, "Implement monobehaviour");
		}
		public enum OrderButtonState
		{
			ORDER = 0,
			PROGRESS = 1,
			DONE = 2,
			COMPLETE = 3,
		}

		[SerializeField]
		private ActionButton[] ExecuBtn;
		[SerializeField]
		private RawImageEx SeriesIcon;
		[SerializeField]
		private RawImageEx SeriesLogo;
		[SerializeField]
		private RawImageEx[] ItemIconList;
		[SerializeField]
		private NumberBase[] ItemIconNumList;
		[SerializeField]
		private ActionButton[] ItemIconButtonList;
		[SerializeField]
		private RawImageEx ItemIconSp;
		[SerializeField]
		private ActionButton ItemIconSpButton;
		[SerializeField]
		private Text ClearTime;
		[SerializeField]
		private Text AfterClearTime;
		[SerializeField]
		private Text OfferName;
		[SerializeField]
		private Text OfferDeadLine;
		[SerializeField]
		private Text DivaName;
		[SerializeField]
		private List<NumberBase> GetItemNum;
		[SerializeField]
		private RawImageEx EventIcon;
		public OrderButtonState buttonState;
	}
}
