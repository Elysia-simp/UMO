
using System.Collections.Generic;

public class AIFIANALLPB
{
	// public const int NIDDEFCBKMO = 50;
	// private const long IEHMEHBPIIB = 30;
	// private const int LDJKMJNAGIA = 30;
	// private const int FMHAOAHOKFP = 2592000;
	// private const int PLJKHEPBIPE = 100;
	// private const int BPLONMOMCMC = 200;
	// public BOPPPCKONML LCMDEIAFNEP = new BOPPPCKONML(); // 0x8
	private SakashoInventoryCriteria JCHEPJKLGCF = new SakashoInventoryCriteria(); // 0xC
	// private SakashoInventoryCriteria KEOGDFJLIMF = new SakashoInventoryCriteria(); // 0x10
	private List<GJDFHLBONOL> GNDBGCIECCN = new List<GJDFHLBONOL>(100); // 0x14
	// private List<GJDFHLBONOL> DBMLAGIIJNI = new List<GJDFHLBONOL>(100); // 0x18
	private List<GJDFHLBONOL> AACJKHBODGM = new List<GJDFHLBONOL>(100); // 0x1C
	// public List<GJDFHLBONOL> PGFCIDHBMNB = new List<GJDFHLBONOL>(100); // 0x20
	private IMCBBOAFION BHFHGFKBOHH; // 0x24
	private CACGCMBKHDI_Request.HDHIKGLMOGF MOBEEPPKFLG; // 0x28
	// public long ECFNAOCFKKN; // 0x30
	// public static bool HELFIJPHKJM; // 0x0

	// public List<GJDFHLBONOL> GIPGAICOGGL { get; } 0xCCBFB0 LNLOKDIGNEL
	// public List<GJDFHLBONOL> LPCFCLLLAMI { get; } 0xCCBFB8 CPDLFJBFDBK
	public bool PLOOEECNHFB { get; private set; }  // 0x38 MGFBAEDOIDD JFOKBBLFMLD EDBGNGILAKA

	// // RVA: 0xCCBFD0 Offset: 0xCCBFD0 VA: 0xCCBFD0
	// public void MHMOFLCJDPH(IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG) { }

	// [IteratorStateMachineAttribute] // RVA: 0x6B7048 Offset: 0x6B7048 VA: 0x6B7048
	// // RVA: 0xCCC098 Offset: 0xCCC098 VA: 0xCCC098
	// private IEnumerator IKPIELFIIMI_FirstPresent(IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG) { }

	// // RVA: 0xCCC178 Offset: 0xCCC178 VA: 0xCCC178
	public void BDPMNDGIEGI(IMCBBOAFION BHFHGFKBOHH, CACGCMBKHDI_Request.HDHIKGLMOGF MOBEEPPKFLG, bool FBBNPFFEJBN)
	{
		PLOOEECNHFB = false;
		if(!FBBNPFFEJBN)
		{
			TodoLogger.Log(0, "TODO");
		}
		GNDBGCIECCN.Clear();
		AACJKHBODGM.Clear();
		JCHEPJKLGCF.OnlyUnreceived = true;
		this.BHFHGFKBOHH = BHFHGFKBOHH;
		this.MOBEEPPKFLG = MOBEEPPKFLG;

		LGJOOFGOGCD_RequestInventories request = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF.IFFNCAFNEAG_AddRequest<LGJOOFGOGCD_RequestInventories>(new LGJOOFGOGCD_RequestInventories());
		request.IPKCADIAAPG = JCHEPJKLGCF;
		request.IGNIIEBMFIN = 1;
		request.MLPLGFLKKLI = 30;
		request.BHFHGFKBOHH_OnSuccess = this.OOGDPKGCMED;
		request.MOBEEPPKFLG_OnFail = this.JHHKCOCJIKH;
	}

	// // RVA: 0xCCC498 Offset: 0xCCC498 VA: 0xCCC498
	private void OOGDPKGCMED(CACGCMBKHDI_Request KFBCOGJKEJP)
	{
		TodoLogger.Log(0, "TODO");
		PLOOEECNHFB = true;
	}

	// [IteratorStateMachineAttribute] // RVA: 0x6B70C0 Offset: 0x6B70C0 VA: 0x6B70C0
	// // RVA: 0xCCD134 Offset: 0xCCD134 VA: 0xCCD134
	// private IEnumerator LLONPPGBFFN(List<GJDFHLBONOL> NCHOFJOBAOE, List<GJDFHLBONOL> CLDOJOHGBJA) { }

	// // RVA: 0xCCD214 Offset: 0xCCD214 VA: 0xCCD214
	private void JHHKCOCJIKH(CACGCMBKHDI_Request KFBCOGJKEJP)
	{
		TodoLogger.Log(0, "TODO");
	}

	// // RVA: 0xCCD234 Offset: 0xCCD234 VA: 0xCCD234
	// public void POMPFPJOMNN(List<long> LDMMMFJCGCF) { }

	// // RVA: 0xCCD444 Offset: 0xCCD444 VA: 0xCCD444
	// public void PBBEPILMAHO(List<long> LDMMMFJCGCF, AIFIANALLPB.FCGCBNAGFKH GPFOMPOEFLM) { }

	// // RVA: 0xCCDE44 Offset: 0xCCDE44 VA: 0xCCDE44
	// public void ICEKFOCHJPI(IMCBBOAFION BHFHGFKBOHH, CACGCMBKHDI.HDHIKGLMOGF MOBEEPPKFLG) { }

	// // RVA: 0xCCDFA0 Offset: 0xCCDFA0 VA: 0xCCDFA0
	// public void EAOGDGAEJPH(IMCBBOAFION BHFHGFKBOHH, CACGCMBKHDI.HDHIKGLMOGF MOBEEPPKFLG) { }

	// // RVA: 0xCCE128 Offset: 0xCCE128 VA: 0xCCE128
	// private void KMDPGNCKNKP(CACGCMBKHDI KFBCOGJKEJP) { }

	// // RVA: 0xCCE758 Offset: 0xCCE758 VA: 0xCCE758
	// private void CBBJHOHHFEM(CACGCMBKHDI KFBCOGJKEJP) { }

	// // RVA: 0xCCE790 Offset: 0xCCE790 VA: 0xCCE790
	// public void OEJMJDNIGJD() { }

	// // RVA: 0xCCCC5C Offset: 0xCCCC5C VA: 0xCCCC5C
	// private bool GAKDCMLCAFC(GJDFHLBONOL AIMLPJOGPID) { }
}
