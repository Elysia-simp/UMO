
using System.Collections.Generic;

[System.Obsolete("Use PLPBJOFICEJ_CosItem", true)]
public class PLPBJOFICEJ { }
public class PLPBJOFICEJ_CosItem : DIHHCBACKGG_DbSection
{
	public enum DPNGHIDJCHA
	{
		HJNNKCMLGFL = 0,
		GLFGNEILACA = 1,
		GLHANCMGNDM = 2,
	}

	public class IBEMFIAFIKH
	{
		public int EHOIENNDEDH; // 0x8
		public int EAJCFBCHIFB; // 0xC
		public int ICKOHEDLEFP; // 0x10
		public int LLEMDLLGIAH; // 0x14
		public int MKENMKMJFKP; // 0x18

		//public int PPFNGGCBJKC { get; set; } 0xFEC414 DEMEPMAEJOO 0xFEBDC8 HIGKAIDMOKN
		//public int EKLIPGELKCL { get; set; } 0xFEC4AC OEEHBGECGKL 0xFEBE64 GHLMHLJJBIG
		//public int JBGEEPFKIGG { get; set; } 0xFEC544 OLOCMINKGON 0xFEBF00 ABAFHIBFKCE
		//public int FDBOPFEOENF { get; set; } 0xFEC2E4 MJPHCAIKKJG 0xFEBF9C GHECGDMEBFF
		//public int INDDJNMPONH { get; set; } 0xFEC37C GHAILOLPHPF 0xFEC038 BACGOKIGMBC

		//// RVA: 0xFEC1C0 Offset: 0xFEC1C0 VA: 0xFEC1C0
		//public uint CAOGDCBPBAN() { }
	}

	public const int CCAPGNIGIOI = 23;
	public static int FBGGEFFJJHB = 0x181b5; // 0x0
	private List<IBEMFIAFIKH> CDENCMNHNGA; // 0x20

	//public int DLLMLAENCPA { get; }

	//// RVA: 0xFEB730 Offset: 0xFEB730 VA: 0xFEB730
	//public IBEMFIAFIKH EEOADCECNOM(int PPFNGGCBJKC) { }

	//// RVA: 0xFEB7B0 Offset: 0xFEB7B0 VA: 0xFEB7B0
	//public IBEMFIAFIKH LOOANCFLPMP(int OIPCCBHIKIA) { }

	//// RVA: 0xFEB830 Offset: 0xFEB830 VA: 0xFEB830
	//public int MIGONIENGBF() { }

	//// RVA: 0xFEB8A8 Offset: 0xFEB8A8 VA: 0xFEB8A8
	//public IBEMFIAFIKH LBDOLHGDIEB(int MCDINKAKFGG, PLPBJOFICEJ.DPNGHIDJCHA INDDJNMPONH) { }

	// RVA: 0xFEB9C4 Offset: 0xFEB9C4 VA: 0xFEB9C4
	public PLPBJOFICEJ_CosItem()
	{
		JIKKNHIAEKG_BlockName = "";
		LNIMEIMBCMF = false;
		LMHMIIKCGPE = 12;
	}

	// RVA: 0xFEBA84 Offset: 0xFEBA84 VA: 0xFEBA84 Slot: 8
	protected override void KMBPACJNEOF()
	{
		CDENCMNHNGA.Clear();
	}

	// RVA: 0xFEBAF0 Offset: 0xFEBAF0 VA: 0xFEBAF0 Slot: 9
	public override bool IIEMACPEEBJ(byte[] DBBGALAPFGC)
	{
		TodoLogger.Log(TodoLogger.Database, "PLPBJOFICEJ_CosItem.IIEMACPEEBJ");
		return true;
	}

	// RVA: 0xFEC0D4 Offset: 0xFEC0D4 VA: 0xFEC0D4 Slot: 10
	public override bool IIEMACPEEBJ(EDOHBJAPLPF_JsonData OILEIIEIBHP, int KAPMOPMDHJE)
	{
		TodoLogger.Log(TodoLogger.Database, "PLPBJOFICEJ_CosItem.IIEMACPEEBJ");
		return true;
	}

	// RVA: 0xFEC0DC Offset: 0xFEC0DC VA: 0xFEC0DC Slot: 11
	public override uint CAOGDCBPBAN()
	{
		TodoLogger.Log(TodoLogger.DbIntegrityCheck, "PLPBJOFICEJ_CosItem.CAOGDCBPBAN");
		return 0;
	}
}
