
using System.Collections.Generic;

[System.Obsolete("Use FBIOJHECAHB_EventStory", true)]
public class FBIOJHECAHB { }
public class FBIOJHECAHB_EventStory : DIHHCBACKGG_DbSection
{
	public class GIEHECAKIFC
	{
		public int PPFNGGCBJKC; // 0x8
		public int PPEGAKEIEGM; // 0xC
		public int OAFJONPIFGM; // 0x10
		public byte MGBDCFIKBPM; // 0x14
		public long PDBPFJJCADD; // 0x18
		public long FDBNFFNFOND; // 0x20
	}

	public class ENDMMNNOAIL
	{
		public int PPFNGGCBJKC; // 0x8
		public int PPEGAKEIEGM; // 0xC
		public int OAFJONPIFGM; // 0x10
		public NMIGMCJHAIE JDJNNJEJDAJ; // 0x14
		public int LOHMKCPKBON; // 0x18
		public int CHOFDPDFPDC; // 0x1C
		public int PFGAKEDKOPD; // 0x20
	}

	public class CHCCGPMJFEL
	{
		public int PPFNGGCBJKC; // 0x8
		public int PPEGAKEIEGM; // 0xC
		public int BCCHOBPJJKE; // 0x10
		public int BPNKGDGBBFG; // 0x14
	}

	public enum NMIGMCJHAIE
	{
		JFEDIMKFDNH = 1,
		GBECNPANBEA = 2,
		OEDCONLFLHD = 3,
		DCDEBCIMEMM = 4,
		MOPAEGFEGCB = 5,
	}

	public enum CHMHPDHPDCD
	{
		FCPAKJFNKPG = 0,
		MOKIALDCAGP = 1,
		JJCGGAFJLGM = 2,
		FDBFJFDIKPE = 3,
		GCLFEJGEIPL = 4,
		MKNOPGIJNID = 5,
	}

	public List<GIEHECAKIFC> ILEJEJKNOBN = new List<GIEHECAKIFC>(); // 0x20
	public List<ENDMMNNOAIL> JPIGOBGOMON = new List<ENDMMNNOAIL>(); // 0x24

	// RVA: 0xFC6448 Offset: 0xFC6448 VA: 0xFC6448
	public FBIOJHECAHB_EventStory()
	{
		JIKKNHIAEKG_BlockName = "";
		LNIMEIMBCMF = false;
		LMHMIIKCGPE = 43;
	}

	// RVA: 0xFC6570 Offset: 0xFC6570 VA: 0xFC6570 Slot: 8
	protected override void KMBPACJNEOF()
	{
		TodoLogger.Log(TodoLogger.Database, "FBIOJHECAHB_EventStory.KMBPACJNEOF");
	}

	// RVA: 0xFC6614 Offset: 0xFC6614 VA: 0xFC6614 Slot: 9
	public override bool IIEMACPEEBJ(byte[] DBBGALAPFGC)
	{
		TodoLogger.Log(TodoLogger.Database, "FBIOJHECAHB_EventStory.IIEMACPEEBJ");
		return true;
	}

	// RVA: 0xFC6B30 Offset: 0xFC6B30 VA: 0xFC6B30 Slot: 10
	public override bool IIEMACPEEBJ(EDOHBJAPLPF_JsonData OILEIIEIBHP, int KAPMOPMDHJE)
	{
		TodoLogger.Log(TodoLogger.Database, "FBIOJHECAHB_EventStory.IIEMACPEEBJ");
		return true;
	}

	// RVA: 0xFC6B38 Offset: 0xFC6B38 VA: 0xFC6B38 Slot: 11
	public override uint CAOGDCBPBAN()
	{
		TodoLogger.Log(TodoLogger.DbIntegrityCheck, "FBIOJHECAHB_EventStory.CAOGDCBPBAN");
		return 0;
	}

	//// RVA: 0xFC7070 Offset: 0xFC7070 VA: 0xFC7070
	//public FBIOJHECAHB.ENDMMNNOAIL GIBIMCOLLNN(int AIPLIEMLHGC) { }
}
