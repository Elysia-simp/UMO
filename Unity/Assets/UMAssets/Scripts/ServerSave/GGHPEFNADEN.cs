
[System.Obsolete("Use GGHPEFNADEN_Ticket", true)]
public class GGHPEFNADEN { }
public class GGHPEFNADEN_Ticket : KLFDBFMNLBL_ServerSaveBlock
{
	private const int ECFEMKGFDCE = 2;
	public const int ECDKBNNCHJB = 7;
	public string LJNAKDMILMC = ""; // 0x24
	public int INLNJOGHLJE; // 0x28
	public int CDMGDFLPPHN; // 0x2C
	public int LNACKEBEMOB; // 0x30
	public string AJFDNKLNKDP; // 0x34
	public string OGMOHJIEDEA; // 0x38
	public string KKJKOGHFGLB; // 0x3C
	public int CBPJHNHBLNN; // 0x40
	public int BKIIKBEACDN; // 0x44
	public int OKKAFCJGCJL; // 0x48

	public string EBAMGNMELPO { get { return AJFDNKLNKDP; } set { AJFDNKLNKDP = value; OKKAFCJGCJL = value.GetHashCode(); } } //NLLPAPKGDJM 0xAA1300 GDOPHGNBAGO 0xAA1308
	public string HBODCMLFDOB { get { return OGMOHJIEDEA; } set { OGMOHJIEDEA = value; BKIIKBEACDN = value.GetHashCode(); } } //MDOIHMLLDEC 0xAA1348 DNGOCLOHDPE 0xAA1350
	public string OEDIICBDNKG { get { return KKJKOGHFGLB; } set { KKJKOGHFGLB = value; CBPJHNHBLNN = value.GetHashCode(); } } //GNOMCGBDNDA 0xAA1390 MFIEGCGDLFH 0xAA1398
	public override bool DMICHEJIAJL { get { return false; } } // 0xAA2A6C NFKFOODCJJB

	// // RVA: 0xAA13D8 Offset: 0xAA13D8 VA: 0xAA13D8
	// public List<string> HOFACDIBDLM() { }

	// // RVA: 0xAA1544 Offset: 0xAA1544 VA: 0xAA1544
	public GGHPEFNADEN_Ticket()
	{
		LHPDDGIJKNB_Reset();
	}

	// // RVA: 0xAA15BC Offset: 0xAA15BC VA: 0xAA15BC Slot: 4
	public override void KMBPACJNEOF()
	{
		EBAMGNMELPO = "";
		LJNAKDMILMC = "";
		INLNJOGHLJE = 0;
		CDMGDFLPPHN = 0;
		LNACKEBEMOB = 0;
		HBODCMLFDOB = "";
		OEDIICBDNKG = "";
	}

	// // RVA: 0xAA16D0 Offset: 0xAA16D0 VA: 0xAA16D0 Slot: 5
	public override void OKJPIBHMKMJ(EDOHBJAPLPF_JsonData OILEIIEIBHP, long MCKEOKFMLAH)
	{
		TodoLogger.LogError(TodoLogger.Event2, "OKJPIBHMKMJ");
	}

	// // RVA: 0xAA1A4C Offset: 0xAA1A4C VA: 0xAA1A4C Slot: 6
	public override bool IIEMACPEEBJ_Deserialize(EDOHBJAPLPF_JsonData OILEIIEIBHP)
	{
		TodoLogger.LogError(0, "TODO");
		return true;
	}

	// // RVA: 0xAA1E44 Offset: 0xAA1E44 VA: 0xAA1E44 Slot: 7
	public override void BMGGKONLFIC(KLFDBFMNLBL_ServerSaveBlock GPBJHKLFCEP)
	{
		TodoLogger.LogError(0, "GGHPEFNADEN_Ticket.BMGGKONLFIC");
	}

	// // RVA: 0xAA2020 Offset: 0xAA2020 VA: 0xAA2020 Slot: 8
	public override bool AGBOGBEOFME(KLFDBFMNLBL_ServerSaveBlock GPBJHKLFCEP)
	{
		TodoLogger.LogError(0, "AGBOGBEOFME");
		return true;
	}

	// // RVA: 0xAA21DC Offset: 0xAA21DC VA: 0xAA21DC Slot: 10
	public override void AGHKODFKOJI(BHBONAHFKHD JBBHNIACMFJ, KLFDBFMNLBL_ServerSaveBlock GJLFANGDGCL, long MCKEOKFMLAH)
	{
		TodoLogger.LogError(0, "AGHKODFKOJI");
	}

	// // RVA: 0xAA2900 Offset: 0xAA2900 VA: 0xAA2900 Slot: 11
	public override FENCAJJBLBH PFAKPFKJJKA()
	{
		TodoLogger.LogError(0, "TODO");
		return null;
	}
}
