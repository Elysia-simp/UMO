
public abstract class DIHHCBACKGG
{
	public static int IEFOPDOOLOK = 1; // 0x0
	public int LMHMIIKCGPE; // 0xC

	public virtual string JIKKNHIAEKG { get; set; } // 0x8 HIPHMHKCJOI  // KLGJBKFAOGN // FEENLLLIMHM
	// public virtual int GLOLECOPKDM { get; set; } // 0x10 FKLFBFJJHPF // FPNGGOKOJHF // PMJJHGPMLBN
	public bool LNIMEIMBCMF { get; set; } // 0x14 FELOLNHPBOI  // // JCGFCHCLKAH // HNHIPLGADIF
	public string HDIDJNCGICK { get; set; } // 0x18 AEDHAENECGN // BILFANLLKPJ // CELPMALCAHG
	public uint HHPOFCILDGN { get; set; } // 0x1C LGLBKNBFCIO // ACELOLOGDLM // MNDHNBBFJIB

	// // RVA: 0x1984404 Offset: 0x1984404 VA: 0x1984404
	public DIHHCBACKGG()
    {
        JIKKNHIAEKG = "";
        LNIMEIMBCMF = false;
    }

	// // RVA: 0x198AB70 Offset: 0x198AB70 VA: 0x198AB70
	public void LHPDDGIJKNB_Reset()
	{
		KMBPACJNEOF();
	}

	// // RVA: -1 Offset: -1 Slot: 8
	protected abstract void KMBPACJNEOF();

	// // RVA: 0x198ABEC Offset: 0x198ABEC VA: 0x198ABEC Slot: 9
	public virtual bool IIEMACPEEBJ(byte[] DBBGALAPFGC) 
    { 
        return true;
    }

	// // RVA: 0x198ABF4 Offset: 0x198ABF4 VA: 0x198ABF4 Slot: 10
	public virtual bool IIEMACPEEBJ(EDOHBJAPLPF_JsonData OILEIIEIBHP, int KAPMOPMDHJE)
	{
		UnityEngine.Debug.LogError("TODO");
		return false;
	}

	// // RVA: 0x1984BC4 Offset: 0x1984BC4 VA: 0x1984BC4
	// protected int CJAENOMGPDA(EDOHBJAPLPF_JsonData LFFNOHMOKJA, string LJNAKDMILMC, int HDDJJLKAFIF, ref bool NGJDHLGMHMH) { }

	// // RVA: 0x198ABFC Offset: 0x198ABFC VA: 0x198ABFC
	// protected string FGCNMLBACGO(EDOHBJAPLPF_JsonData LFFNOHMOKJA, string LJNAKDMILMC, string HDDJJLKAFIF, ref bool NGJDHLGMHMH) { }

	// // RVA: 0x198AEC8 Offset: 0x198AEC8 VA: 0x198AEC8
	// protected void IBCGPBOGOGP(EDOHBJAPLPF_JsonData NICPPBGFMBI, string LJNAKDMILMC, int HCGFLHLODKD, int GLBEAENLHKC, DIHHCBACKGG.NPLKKHGGCOM OCMLFNJCIDN, ref bool NGJDHLGMHMH) { }

	// // RVA: 0x198B55C Offset: 0x198B55C VA: 0x198B55C
	// protected void IBCGPBOGOGP(EDOHBJAPLPF_JsonData NICPPBGFMBI, string LJNAKDMILMC, int HCGFLHLODKD, DIHHCBACKGG.NPLKKHGGCOM BLOEDBAPDHJ, ref bool NGJDHLGMHMH) { }

	// // RVA: 0x198B6F0 Offset: 0x198B6F0 VA: 0x198B6F0 Slot: 11
	public virtual uint CAOGDCBPBAN()
	{
		UnityEngine.Debug.LogError("TODO");
		return 0;
	}

	// // RVA: 0x1989E1C Offset: 0x1989E1C VA: 0x1989E1C
	public int JKAECBCNHAN(int IJEKNCDIIAE, int PLALNIIBLOF, int DBHPPMPNCKF = 0)
	{
		if(DBHPPMPNCKF != 0)
		{
			if (DBHPPMPNCKF <= IEFOPDOOLOK)
				return 0;
		}
		if(IJEKNCDIIAE != 0)
		{
			if (IJEKNCDIIAE <= IEFOPDOOLOK)
				return PLALNIIBLOF;
		}
		if (PLALNIIBLOF == 2)
			PLALNIIBLOF = 1;
		return PLALNIIBLOF;
	}
}
