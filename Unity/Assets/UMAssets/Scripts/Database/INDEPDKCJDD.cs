
using System.Collections.Generic;

[System.Obsolete("Use INDEPDKCJDD_ValItem", true)]
public class INDEPDKCJDD { }
public class INDEPDKCJDD_ValItem : DIHHCBACKGG_DbSection
{
	public class NHJLDENJKBE
	{
		public int EHOIENNDEDH; // 0x8
		public int EAJCFBCHIFB; // 0xC
		public int MKENMKMJFKP; // 0x10

		//public int PPFNGGCBJKC { get; set; } 0xA0161C DEMEPMAEJOO 0xA012C4 HIGKAIDMOKN
		//public int EKLIPGELKCL { get; set; } 0xA016B4 OEEHBGECGKL 0xA01360 GHLMHLJJBIG
		//public int INDDJNMPONH { get; set; } 0xA0174C GHAILOLPHPF 0xA013FC BACGOKIGMBC

		//// RVA: 0xA01584 Offset: 0xA01584 VA: 0xA01584
		//public uint CAOGDCBPBAN() { }
	}

	public const int IEEFAIKAKPG = 5;
	public static int FBGGEFFJJHB = 0x3039; // 0x0
	public List<NHJLDENJKBE> CDENCMNHNGA = new List<NHJLDENJKBE>(); // 0x20

	// RVA: 0xA00F00 Offset: 0xA00F00 VA: 0xA00F00
	public INDEPDKCJDD_ValItem()
	{
		JIKKNHIAEKG_BlockName = "";
		LNIMEIMBCMF = false;
		LMHMIIKCGPE = 86;
	}

	// RVA: 0xA00FF8 Offset: 0xA00FF8 VA: 0xA00FF8 Slot: 8
	protected override void KMBPACJNEOF()
	{
		if(CDENCMNHNGA != null)
			CDENCMNHNGA.Clear();
	}

	// RVA: 0xA01064 Offset: 0xA01064 VA: 0xA01064 Slot: 9
	public override bool IIEMACPEEBJ(byte[] DBBGALAPFGC)
	{
		TodoLogger.Log(TodoLogger.Database, "INDEPDKCJDD_ValItem.IIEMACPEEBJ");
		return true;
	}

	// RVA: 0xA01498 Offset: 0xA01498 VA: 0xA01498 Slot: 10
	public override bool IIEMACPEEBJ(EDOHBJAPLPF_JsonData OILEIIEIBHP, int KAPMOPMDHJE)
	{
		TodoLogger.Log(TodoLogger.Database, "INDEPDKCJDD_ValItem.IIEMACPEEBJ");
		return true;
	}

	// RVA: 0xA014A0 Offset: 0xA014A0 VA: 0xA014A0 Slot: 11
	public override uint CAOGDCBPBAN()
	{
		TodoLogger.Log(TodoLogger.DbIntegrityCheck, "INDEPDKCJDD_ValItem.CAOGDCBPBAN");
		return 0;
	}
}
