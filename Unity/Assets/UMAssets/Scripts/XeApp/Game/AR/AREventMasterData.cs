using System.Collections.Generic;

namespace XeApp.Game.AR
{
	public class AREventMasterData : ARMasterData
	{
		public class Chenge_bg
		{
			public long startTime; // 0x8
			public long endTime; // 0x10
			public int enable; // 0x18
			public int bgId; // 0x1C

			// RVA: 0xBB7C5C Offset: 0xBB7C5C VA: 0xBB7C5C
			// public void .ctor() { }
		}

		private static AREventMasterData sm_instance; // 0x0
		// private List<AREventMasterData.Data> m_eventList; // 0x18
		private List<AREventMasterData.Chenge_bg> m_chengeBg; // 0x1C
		// private List<AREventMasterData.EventTime> m_eventTime; // 0x20
		private long m_arStartTime; // 0x28
		private long m_arEndTime; // 0x30
		// [CompilerGeneratedAttribute] // RVA: 0x68D88C Offset: 0x68D88C VA: 0x68D88C
		// private Dictionary<string, NNJFKLBPBNK> <m_stringParam>k__BackingField; // 0x38
		// [CompilerGeneratedAttribute] // RVA: 0x68D89C Offset: 0x68D89C VA: 0x68D89C
		// private Dictionary<string, CEBFFLDKAEC> <m_intParam>k__BackingField; // 0x3C

		public static AREventMasterData Instance { get; }
		// public Dictionary<string, NNJFKLBPBNK> m_stringParam { get; set; }
		// public Dictionary<string, CEBFFLDKAEC> m_intParam { get; set; }

		// // RVA: 0xBB6C40 Offset: 0xBB6C40 VA: 0xBB6C40
		// public static AREventMasterData get_Instance() { }

		// RVA: 0xBB6DA4 Offset: 0xBB6DA4 VA: 0xBB6DA4
		private AREventMasterData()
		{
		}

		// [CompilerGeneratedAttribute] // RVA: 0x741A84 Offset: 0x741A84 VA: 0x741A84
		// // RVA: 0xBB6F14 Offset: 0xBB6F14 VA: 0xBB6F14
		// public Dictionary<string, NNJFKLBPBNK> get_m_stringParam() { }

		// [CompilerGeneratedAttribute] // RVA: 0x741A94 Offset: 0x741A94 VA: 0x741A94
		// // RVA: 0xBB6F1C Offset: 0xBB6F1C VA: 0xBB6F1C
		// private void set_m_stringParam(Dictionary<string, NNJFKLBPBNK> value) { }

		// [CompilerGeneratedAttribute] // RVA: 0x741AA4 Offset: 0x741AA4 VA: 0x741AA4
		// // RVA: 0xBB6F24 Offset: 0xBB6F24 VA: 0xBB6F24
		// public Dictionary<string, CEBFFLDKAEC> get_m_intParam() { }

		// [CompilerGeneratedAttribute] // RVA: 0x741AB4 Offset: 0x741AB4 VA: 0x741AB4
		// // RVA: 0xBB6F2C Offset: 0xBB6F2C VA: 0xBB6F2C
		// private void set_m_intParam(Dictionary<string, CEBFFLDKAEC> value) { }

		// // RVA: 0xBB6F34 Offset: 0xBB6F34 VA: 0xBB6F34
		// public static void Release() { }

		// // RVA: 0xBB6FC4 Offset: 0xBB6FC4 VA: 0xBB6FC4 Slot: 4
		// protected override void Initialize(byte[] bytes) { }

		// // RVA: 0xBB7C6C Offset: 0xBB7C6C VA: 0xBB7C6C
		// public string GetStringParam(string key, string noval) { }

		// // RVA: 0xBB7D50 Offset: 0xBB7D50 VA: 0xBB7D50
		// public int GetIntParam(string key, int noval) { }

		// // RVA: 0xBB7E34 Offset: 0xBB7E34 VA: 0xBB7E34
		// public bool IsEnableARMode() { }

		// // RVA: 0xBB80BC Offset: 0xBB80BC VA: 0xBB80BC
		// public List<AREventMasterData.Data> GetEventList(bool isAll = False) { }

		// // RVA: 0xBB820C Offset: 0xBB820C VA: 0xBB820C
		// public List<AREventMasterData.Campaign> GetEnableCampaigns() { }

		// // RVA: 0xBB8448 Offset: 0xBB8448 VA: 0xBB8448
		public AREventMasterData.Chenge_bg FindChangeBG()
		{
			UnityEngine.Debug.LogError("TODO");
			return null;
		}

		// // RVA: 0xBB7E4C Offset: 0xBB7E4C VA: 0xBB7E4C
		// public AREventMasterData.EventTime FindEventTime() { }

		// // RVA: 0xBB86B8 Offset: 0xBB86B8 VA: 0xBB86B8
		// private static void .cctor() { }

	}
}