
using System.Collections.Generic;
using XeSys;

public class MNDAMOGGJBJ
{
	public struct JFJJNPJNBPI
	{
		public int PPFNGGCBJKC_Id; // 0x0
		public int HMFFHLPNMPH; // 0x4

		//// RVA: 0x7FD6EC Offset: 0x7FD6EC VA: 0x7FD6EC
		public void MBFFGGFGPEN(int BBPHAPFBFHK, int HFJLPAOGLEH)
		{
			PPFNGGCBJKC_Id = BBPHAPFBFHK;
			HMFFHLPNMPH = HFJLPAOGLEH;
		}
	}

	public enum MNDGNJLBANB
	{
		HJNNKCMLGFL_None = 0,
		EDBCFDJBFID_LackUC = 1,
		LNMPDFICAOM_LackItem = 2,
	}

	private EGOLBAPFHHD_Common KCCLEHLLOFG; // 0x8
	public int FBGGEFFJJHB; // 0xC
	private int NEGMNPCHENF; // 0x1C

	public List<JFJJNPJNBPI> MHGAOHAHFDN { get; set; } // 0x10 DJBDDFLFPLE PGKLOONAKPD GLBMFLPHJLB
	public int PGGKBIIJOND { get; set; } // 0x14 PKFNBLMOBCL MKBBJIKHFJD KMOMHPMBMNL
	public List<JFJJNPJNBPI> INLBMFMOHCI { get; set; } // 0x18 PIDPINOOAPN KLLCKKLHEHH EBBKKLLCDMB
	public int CMBGGPOFBOO { get { return NEGMNPCHENF ^ FBGGEFFJJHB; } set { NEGMNPCHENF = value ^ FBGGEFFJJHB; } } //0x17B00B0 PPKIKKIKGMK 0x17B00C0 HOGAFMDJKPK

	//// RVA: 0x17B00D0 Offset: 0x17B00D0 VA: 0x17B00D0
	public void KHEKNNFCAOI(BBHNACPENDM_ServerSaveData AHEFHIMGIBI)
	{
		FBGGEFFJJHB = (int)(Utility.GetCurrentUnixTime() * 0x15573);
		if(AHEFHIMGIBI == null)
		{
			AHEFHIMGIBI = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave;
		}
		KCCLEHLLOFG = AHEFHIMGIBI.KCCLEHLLOFG_Common;
		PGGKBIIJOND = 0;
		CMBGGPOFBOO = 0;
		INLBMFMOHCI = new List<JFJJNPJNBPI>();
		MHGAOHAHFDN = new List<JFJJNPJNBPI>();
		MDHKGJJBLNL();
	}

	//// RVA: 0x17B024C Offset: 0x17B024C VA: 0x17B024C
	public void MDHKGJJBLNL()
	{
		FBGGEFFJJHB = (int)(Utility.GetCurrentUnixTime() * 0x15573);
		INLBMFMOHCI.Clear();
		CMBGGPOFBOO = 0;
	}

	//// RVA: 0x17B0310 Offset: 0x17B0310 VA: 0x17B0310
	//public void JGAAANGEIFK() { }

	//// RVA: 0x17B03CC Offset: 0x17B03CC VA: 0x17B03CC
	public int JPLMJPGDPAN(int PPFNGGCBJKC)
	{
		if (PPFNGGCBJKC != 0)
		if(CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave != null && IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database != null)
		{
				return EKLNMHFCAOI.DLNFNHMPGLI_GetNumClamped(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database, CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave, EKLNMHFCAOI.BKHFLDMOGBD_GetItemCategory(INLBMFMOHCI[PPFNGGCBJKC - 1].PPFNGGCBJKC_Id), EKLNMHFCAOI.DEACAHNLMNI_getItemId(INLBMFMOHCI[PPFNGGCBJKC - 1].PPFNGGCBJKC_Id), null);
		}
		return 0;
	}

	//// RVA: 0x17B059C Offset: 0x17B059C VA: 0x17B059C
	private int JBMLCIPKFDF(int PPFNGGCBJKC)
	{
		if (PPFNGGCBJKC == 0)
			return 0;
		if(CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave != null && IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database != null)
		{
			return EKLNMHFCAOI.ALHCGDMEMID_GetNumItems(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database,
				CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave, EKLNMHFCAOI.BKHFLDMOGBD_GetItemCategory(INLBMFMOHCI[PPFNGGCBJKC - 1].PPFNGGCBJKC_Id), EKLNMHFCAOI.DEACAHNLMNI_getItemId(INLBMFMOHCI[PPFNGGCBJKC - 1].PPFNGGCBJKC_Id), null);
		}
		return 0;
	}

	//// RVA: 0x17B076C Offset: 0x17B076C VA: 0x17B076C
	private int CPBDJHKHEFN(int PPFNGGCBJKC)
	{
		return JBMLCIPKFDF(PPFNGGCBJKC) - INLBMFMOHCI[PPFNGGCBJKC - 1].HMFFHLPNMPH;
	}

	//// RVA: 0x17B0810 Offset: 0x17B0810 VA: 0x17B0810
	//public void IDKIMNBOBLA(int PPFNGGCBJKC, int JBGEEPFKIGG) { }

	//// RVA: 0x17B08EC Offset: 0x17B08EC VA: 0x17B08EC
	//public void MBBGCIFMOHC(int JBGJDEELLOP, int JBGEEPFKIGG) { }

	//// RVA: 0x17B09CC Offset: 0x17B09CC VA: 0x17B09CC
	public int ANFHCKKFIEA()
	{
		if(KCCLEHLLOFG != null)
		{
			return KCCLEHLLOFG.NFHLDFJIBKI_HaveUc;
		}
		return 0;
	}

	//// RVA: 0x17B09E4 Offset: 0x17B09E4 VA: 0x17B09E4
	//public int DNCBAOLBJON() { }

	//// RVA: 0x17B0A20 Offset: 0x17B0A20 VA: 0x17B0A20
	public int EFFBJDMGIGO()
	{
		int idx = -1;
		for(int i = 0; i < INLBMFMOHCI.Count; i++)
		{
			if(INLBMFMOHCI[i].HMFFHLPNMPH < 1)
			{
				if (INLBMFMOHCI[i].HMFFHLPNMPH < 0)
					return -2;
			}
			idx = 1;
			if (CPBDJHKHEFN(i + 1) < 0)
				return 0;
		}
		if (CMBGGPOFBOO < 1)
		{
			if (CMBGGPOFBOO < 0)
				return -2;
			return idx;
		}
		if(KCCLEHLLOFG != null)
		{
			if (KCCLEHLLOFG.NFHLDFJIBKI_HaveUc - CMBGGPOFBOO < 0)
				return 0;
		}
		if (0 - CMBGGPOFBOO < 0)
			return 0;
		return idx;
	}

	//// RVA: 0x17B0BCC Offset: 0x17B0BCC VA: 0x17B0BCC
	public MNDGNJLBANB HDHNAIIAJCP()
	{
		int haveUC = 0;
		if (KCCLEHLLOFG != null)
			haveUC = KCCLEHLLOFG.NFHLDFJIBKI_HaveUc;
		MNDGNJLBANB res = haveUC < CMBGGPOFBOO ? MNDGNJLBANB.EDBCFDJBFID_LackUC/*1*/ : MNDGNJLBANB.HJNNKCMLGFL_None/*0*/;
		for(int i = 0; i < INLBMFMOHCI.Count; i++)
		{
			if(INLBMFMOHCI[i].HMFFHLPNMPH > 0)
			{
				if(INLBMFMOHCI[i].HMFFHLPNMPH > JBMLCIPKFDF(i + 1))
				{
					return (MNDGNJLBANB)((int)res | 2);
				}
			}
		}
		return res;
	}

	//// RVA: 0x17B0D40 Offset: 0x17B0D40 VA: 0x17B0D40
	//public int KMIFDLLCBEL() { }

	//// RVA: 0x17B1084 Offset: 0x17B1084 VA: 0x17B1084
	//public string MNNKOKNBJNC() { }
}
