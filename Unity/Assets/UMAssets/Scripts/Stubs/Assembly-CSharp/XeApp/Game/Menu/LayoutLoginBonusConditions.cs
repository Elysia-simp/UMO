using XeSys.Gfx;
using System;
using UnityEngine;
using XeApp.Game.Common;

namespace XeApp.Game.Menu
{
	public class LayoutLoginBonusConditions : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.Log(0, "Implement LayoutUGUIScriptBase"); }
		[Serializable]
		public class LoginBonusPrizeObject
		{
			[SerializeField]
			public RawImageEx iconL;
			[SerializeField]
			public RawImageEx iconS;
			[SerializeField]
			public NumberBase itemNumS;
			[SerializeField]
			public NumberBase itemNumL;
			[SerializeField]
			public NumberBase ucL;
			[SerializeField]
			public NumberBase ucS;
			[SerializeField]
			public NumberBase day;
		}

		[SerializeField]
		private LoginBonusPrizeObject[] m_prizeObject;
		[SerializeField]
		private ActionButton m_okButton;
	}
}
