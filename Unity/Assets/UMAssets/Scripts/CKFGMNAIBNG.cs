
using System.Text;
using XeSys;

public class CKFGMNAIBNG
{
	public int ECNEBGLPECK; // 0x8
	public int FBGGEFFJJHB; // 0xC
	public string OPFGFINHFCE; // 0x10
	public string GMOBAMGOLHB; // 0x14
	public string FCEGELPJAMH; // 0x18
	private short[] EOGIFMAPOPA; // 0x1C
	public bool[] EJODLFBKFDK; // 0x20
	public bool FJODMPGPDDD; // 0x24
	public int HCFNIMFOOPF; // 0x28
	public int NNAPJKPBBKI; // 0x2C
	public int HNJNKCPDKAL_PrismCostumeId; // 0x30
	public int CGIGOFKGCII; // 0x34
	public int HFJLOKDMJHI; // 0x38
	public int LMMCLBNCBIO; // 0x3C
	public int NPCEOIJLNGB; // 0x40

	// public int ENMAEBJGEKL { get; set; } 0x107DE8C FHIMMFAEDIP 0x107DE9C CPEAMPGOMCB
	// public int DEOBDFOPLHG { get; set; } 0x107DEAC LHFCGJBCDEE 0x107DEBC OAGOCCBEFPD
	public int DAJGPBLEEOB { get { return FBGGEFFJJHB ^ HNJNKCPDKAL_PrismCostumeId; } set { HNJNKCPDKAL_PrismCostumeId = FBGGEFFJJHB ^ value; } } //0x107DECC LHPKEPPBKPF 0x107DEDC OIOEEEDODJA
	public int AHHJLDLAPAN_DivaId { get { return CGIGOFKGCII ^ FBGGEFFJJHB; } set { CGIGOFKGCII = FBGGEFFJJHB ^ value; } } //0x107DEEC IPKDLMIDMHH 0x107DEFC IENNENMKEFO
	public int JPIDIENBGKH_CostumeId { get { return HFJLOKDMJHI ^ FBGGEFFJJHB; } set { HFJLOKDMJHI = FBGGEFFJJHB ^ value; } } //0x107DF0C PHLLMIGCPCB 0x107DF1C BLBNMENMCIF
	// public int GKIKAABHAAD { get; set; } 0x107DF2C JNDLKKLLAMO 0x107DF3C PBOBJNPNBHG
	// public int EGLDFPILJLG { get; set; } 0x107DF4C JACADMEJOAH 0x107DF5C MMDBFGAFINM
	// public bool LFLNFHKOIIM { get; }

	// // RVA: 0x107DF6C Offset: 0x107DF6C VA: 0x107DF6C
	// public short LLJPMOIPBAG(int BMBBDIAEOMP) { }

	// // RVA: 0x107DFC4 Offset: 0x107DFC4 VA: 0x107DFC4
	// public int NLKGAAFBDFK() { }

	// // RVA: 0x107DFE8 Offset: 0x107DFE8 VA: 0x107DFE8
	public CKFGMNAIBNG()
    {
        FBGGEFFJJHB = LPDNKHAIOLH.CEIBAFOCNCA();
        ECNEBGLPECK = LPDNKHAIOLH.CEIBAFOCNCA() & 0x7fff;
        HCFNIMFOOPF = FBGGEFFJJHB;
        NNAPJKPBBKI = FBGGEFFJJHB;
        HNJNKCPDKAL_PrismCostumeId = FBGGEFFJJHB;
        HFJLOKDMJHI = FBGGEFFJJHB;
        LMMCLBNCBIO = FBGGEFFJJHB;
        NPCEOIJLNGB = FBGGEFFJJHB;
    }

	// // RVA: 0x107E0A4 Offset: 0x107E0A4 VA: 0x107E0A4
	public void KHEKNNFCAOI(int AHHJLDLAPAN_DivaId, int JPIDIENBGKH_CostumeId, int GKIKAABHAAD, bool OJEBNBLHPNP = false)
    {
        TodoLogger.Log(0, "CKFGMNAIBNG KHEKNNFCAOI");
        LCLCCHLDNHJ_Costume.ILODJKFJJDO cosInfo = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.MFPNGNMFEAL_Costume.LBDOLHGDIEB(AHHJLDLAPAN_DivaId, JPIDIENBGKH_CostumeId);
		this.AHHJLDLAPAN_DivaId = AHHJLDLAPAN_DivaId;
		this.JPIDIENBGKH_CostumeId = JPIDIENBGKH_CostumeId;
		HNJNKCPDKAL_PrismCostumeId = FBGGEFFJJHB ^ cosInfo.DAJGPBLEEOB_PrismCostumeModelId;
	}

	// // RVA: 0x107EB24 Offset: 0x107EB24 VA: 0x107EB24
	public void KHEKNNFCAOI(int AHHJLDLAPAN_DivaId, int JPIDIENBGKH_CostumeId, BBHNACPENDM_ServerSaveData AHEFHIMGIBI, bool OJEBNBLHPNP = false)
    {
        TodoLogger.Log(0, "CKFGMNAIBNG KHEKNNFCAOI");
		KHEKNNFCAOI(AHHJLDLAPAN_DivaId, JPIDIENBGKH_CostumeId, 0, OJEBNBLHPNP);
	}

	// // RVA: 0x107E604 Offset: 0x107E604 VA: 0x107E604
	// private static void OHGOPFEOJOG(LCLCCHLDNHJ.ILODJKFJJDO NDFIEMPPMLF, MessageBank GDMBMJBMNME, StringBuilder JEHFDJPOEFF, int HDHANIEDJPA, int DEOBDFOPLHG, ref string OPFGFINHFCE, ref string HCAHCFGPJIF) { }

	// // RVA: 0x107EDDC Offset: 0x107EDDC VA: 0x107EDDC
	// public void OHGOPFEOJOG(int GHDGALFNGFJ, ref string OPFGFINHFCE, ref string HCAHCFGPJIF) { }

	// // RVA: 0x107EFA0 Offset: 0x107EFA0 VA: 0x107EFA0
	// public bool LMHEGNBODJG() { }

	// // RVA: 0x107EFCC Offset: 0x107EFCC VA: 0x107EFCC
	public string HCPCHEPCFEA(int LEHGKNOCLBG)
	{
		if (LEHGKNOCLBG == 0)
			return OPFGFINHFCE;
		MessageBank bank = MessageManager.Instance.GetBank("master");
		StringBuilder str = new StringBuilder(16);
		str.SetFormat("cos_{0:D4}_{1:D2}", (FBGGEFFJJHB ^ HFJLOKDMJHI), LEHGKNOCLBG);
		return bank.GetMessageByLabel(str.ToString());
	}

	// // RVA: 0x107ECCC Offset: 0x107ECCC VA: 0x107ECCC
	// public void CEHICAFELBI(BBHNACPENDM AHEFHIMGIBI) { }

	// // RVA: 0x107F14C Offset: 0x107F14C VA: 0x107F14C
	// public void PDADHMIODCA(BBHNACPENDM AHEFHIMGIBI, int HEHKNMCDBJJ, bool JKDJCFEBDHC) { }

	// // RVA: 0x107F26C Offset: 0x107F26C VA: 0x107F26C
	// public void PDADHMIODCA(int HEHKNMCDBJJ, bool JKDJCFEBDHC) { }

	// // RVA: 0x107F330 Offset: 0x107F330 VA: 0x107F330
	// public static List<CKFGMNAIBNG> NEOMKKIEMJJ(BBHNACPENDM KPMOBPNENCD, bool OJEBNBLHPNP = False, bool NHMPDLNPBJD = False) { }

	// // RVA: 0x107F7B4 Offset: 0x107F7B4 VA: 0x107F7B4
	// public static string EJOJNFDHDHN(int AHHJLDLAPAN, int JPIDIENBGKH) { }

	// // RVA: 0x107F958 Offset: 0x107F958 VA: 0x107F958 Slot: 3
	// public override string ToString() { }

	// // RVA: 0x107FA20 Offset: 0x107FA20 VA: 0x107FA20
	// public static int LLJPMOIPBAG(int AHHJLDLAPAN, int JPIDIENBGKH, int ANAJIAENLNB) { }

	// // RVA: 0x107FB34 Offset: 0x107FB34 VA: 0x107FB34
	// public static int MHIKGGMOPOJ(int AHHJLDLAPAN, int JPIDIENBGKH, int HEHKNMCDBJJ) { }
}
