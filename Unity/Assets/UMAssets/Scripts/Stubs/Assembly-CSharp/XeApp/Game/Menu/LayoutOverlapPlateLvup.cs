using XeSys.Gfx;
using UnityEngine;

namespace XeApp.Game.Menu
{
	public class LayoutOverlapPlateLvup : LayoutUGUIScriptBase
	{
    public void Awake() { TodoLogger.LogError(0, "Implement LayoutUGUIScriptBase"); }
		[SerializeField]
		private RawImageEx m_before;
		[SerializeField]
		private RawImageEx m_beforeEf;
		[SerializeField]
		private RawImageEx m_after;
		[SerializeField]
		private RawImageEx m_frameBefore;
		[SerializeField]
		private RawImageEx m_frameBeforeEf;
		[SerializeField]
		private RawImageEx m_frameAfter;
	}
}
