
using System.Collections.Generic;

[System.Obsolete("Use HHPEMHHCKBE_Compo", true)]
public class HHPEMHHCKBE { }
public class HHPEMHHCKBE_Compo : DIHHCBACKGG_DbSection
{
	public class MLMDKHBFOJM
	{
		public int FBGGEFFJJHB = 0x3fb377; // 0x8
		private int EHOIENNDEDH; // 0xC
		public int[] OGEBLOHMGAM; // 0x10
		public int[] AHGCGHAAHOO; // 0x14
		public int EAJCFBCHIFB; // 0x18

		//public int PPFNGGCBJKC { get; set; } 0x18337DC DEMEPMAEJOO 0x1833654 HIGKAIDMOKN
		//public int EKLIPGELKCL { get; set; } 0x18337EC OEEHBGECGKL 0x1833664 GHLMHLJJBIG

		//// RVA: 0x18337FC Offset: 0x18337FC VA: 0x18337FC
		//public int JCJGGHGIKIJ() { }

		//// RVA: 0x1833810 Offset: 0x1833810 VA: 0x1833810
		//public int CBLLFCGEJAI(int OIPCCBHIKIA) { }

		//// RVA: 0x1833864 Offset: 0x1833864 VA: 0x1833864
		//public int HBJMCLGKLBA(int OIPCCBHIKIA) { }

		//// RVA: 0x1833760 Offset: 0x1833760 VA: 0x1833760
		//public uint CAOGDCBPBAN() { }
	}

	public List<MLMDKHBFOJM> CDENCMNHNGA = new List<MLMDKHBFOJM>(); // 0x20

	// RVA: 0x18330C0 Offset: 0x18330C0 VA: 0x18330C0
	public HHPEMHHCKBE_Compo()
	{
		JIKKNHIAEKG_BlockName = "compo";
		LNIMEIMBCMF = false;
		LMHMIIKCGPE = 10;
	}

	// RVA: 0x18331B8 Offset: 0x18331B8 VA: 0x18331B8 Slot: 8
	protected override void KMBPACJNEOF()
	{
		CDENCMNHNGA.Clear();
	}

	// RVA: 0x1833230 Offset: 0x1833230 VA: 0x1833230 Slot: 9
	public override bool IIEMACPEEBJ(byte[] DBBGALAPFGC)
	{
		TodoLogger.Log(TodoLogger.Database, "HHPEMHHCKBE_Compo.IIEMACPEEBJ");
		return true;
	}

	// RVA: 0x1833674 Offset: 0x1833674 VA: 0x1833674 Slot: 10
	public override bool IIEMACPEEBJ(EDOHBJAPLPF_JsonData OILEIIEIBHP, int KAPMOPMDHJE)
	{
		TodoLogger.Log(TodoLogger.Database, "HHPEMHHCKBE_Compo.IIEMACPEEBJ");
		return true;
	}

	// RVA: 0x183367C Offset: 0x183367C VA: 0x183367C Slot: 11
	public override uint CAOGDCBPBAN()
	{
		TodoLogger.Log(TodoLogger.DbIntegrityCheck, "HHPEMHHCKBE_Compo.IIEMACPEEBJ");
		return 0;
	}
}
