
using System.Collections.Generic;
using System.Text;
using UnityEngine;

[System.Obsolete("Use JJOELIOGMKK_DivaIntimacyInfo", true)]
public class JJOELIOGMKK { }
public class JJOELIOGMKK_DivaIntimacyInfo
{
	public enum LPBGKOJDNJK
	{
		HJNNKCMLGFL = 0,
		POBNHLKGMPF = 1,
		EHJDMAOKHHP = 2,
		JFEKIMDCKIH = 3,
		GBINCMPKLOF = 4,
	}

	public enum OAIBOODMLME
	{
		DBPDLIPKFAL = 1,
		NLELBHEHKHF = 2,
		CKPGGPDJCAL = 3,
	}

	public enum FAGMPBPFDLD
	{
		DBPDLIPKFAL = 1,
		NLELBHEHKHF = 2,
		CKPGGPDJCAL = 3,
	}

	public enum OPOEENHEJOC
	{
		FNGFADPFKOD = 0,
		EMIFDDHCOFB = 1,
	}

	public class POJEFNEMGNN
	{
		public int CIEOBFIIPLD; // 0x8
		public LPBGKOJDNJK GBJFNGCDKPM; // 0xC
		public int KDCMPJNGLBL; // 0x10
		public int KIJAPOFAGPN; // 0x14
	}

	public class MKGIDHAHAIK
	{
		public int JHOBMMMEJHH_SkillLevel; // 0x8
		public int IGNABALECPK; // 0xC
		public int ODHAIDDEFJL; // 0x10
		public int HOMOKJEKKNK; // 0x14
		public int NLFMNHGEADA; // 0x18
		public int BJHAMEJPGAJ; // 0x1C
		public int FGHMGNAMAND; // 0x20
		public int CPDEMMFGKED; // 0x24
		public bool EDPNAEOKGNM; // 0x28
		public int EOIJEGJDLAN; // 0x2C
		public int GGAEHEIPGND; // 0x30
		public int KBHJOBKOOGC; // 0x34
		public bool PFIILLOIDIL; // 0x38
		public bool LDHOOPGDBJC; // 0x39
		public List<LPBGKOJDNJK> CKDNPHLDIEM; // 0x3C
		public List<int> EEIBCALKFFF; // 0x40
		public List<int> IELPCAEACLL; // 0x44
		public List<string> HBCBADBPNCJ; // 0x48
		public int IOCFPAAEFHM; // 0x4C
		public int LEAKFAFGEKK; // 0x50
		public string CCJDPKBGJPH; // 0x54
		public string JLKIADFKPFL; // 0x58

		//// RVA: 0x1351720 Offset: 0x1351720 VA: 0x1351720
		public void LHPDDGIJKNB_Reset()
		{
			KBHJOBKOOGC = 0;
			PFIILLOIDIL = false;
			LDHOOPGDBJC = false;
			EOIJEGJDLAN = 0;
			GGAEHEIPGND = 0;
			NLFMNHGEADA = 0;
			BJHAMEJPGAJ = 0;
			FGHMGNAMAND = 0;
			CPDEMMFGKED = 0;
			EDPNAEOKGNM = false;
			JHOBMMMEJHH_SkillLevel = 0;
			IGNABALECPK = 0;
			ODHAIDDEFJL = 0;
			HOMOKJEKKNK = 0;
			CKDNPHLDIEM = new List<LPBGKOJDNJK>();
			EEIBCALKFFF = new List<int>();
			IELPCAEACLL = new List<int>();
			HBCBADBPNCJ = new List<string>();
			CKDNPHLDIEM.Clear();
			EEIBCALKFFF.Clear();
			IELPCAEACLL.Clear();
			HBCBADBPNCJ.Clear();
		}
	}

	public int AHHJLDLAPAN_DivaId; // 0x8
	public int HEKJGCMNJAB_CurrentLevel = 1; // 0xC
	public int KPEAGFJHNDP_CurrentLevelExp; // 0x10
	public int KOKCFJDMJLI  = 65000; // 0x14
	public int NHCCINMHEAB; // 0x18
	public int MIKFKJKDOBI_TouchPoint = 100; // 0x1C
	public int JGLMDLKHFGG_FavBonus = 50; // 0x20
	public int MFFJEALABOG_TensionBonus = 50; // 0x24
	public int OMAEOHMDCLI_FirstPresentId; // 0x28
	private StringBuilder BAHOPFGBAHN = new StringBuilder(64); // 0x2C
	public int IOCFPAAEFHM; // 0x30
	public int LEAKFAFGEKK; // 0x34
	public List<int> GLLNLNDNIHM; // 0x38
	public List<int> DLNOIGEGLEA; // 0x3C
	public List<POJEFNEMGNN> LGPDCPDDECG; // 0x40
	public MKGIDHAHAIK HBODCMLFDOB = new MKGIDHAHAIK(); // 0x44

	//// RVA: 0x1351064 Offset: 0x1351064 VA: 0x1351064
	public void KHEKNNFCAOI(int AHHJLDLAPAN_DivaId)
	{
		if(AHHJLDLAPAN_DivaId > 0)
		{
			if (IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database != null && IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.KDIALKDKBGE_Intimacy != null)
			{
				this.AHHJLDLAPAN_DivaId = AHHJLDLAPAN_DivaId;
				HBODCMLFDOB.LHPDDGIJKNB_Reset();
				LGPDCPDDECG = new List<POJEFNEMGNN>();
				LGPDCPDDECG.Clear();
				for(int i = 0; i < IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.KDIALKDKBGE_Intimacy.OOCKOCAACMD_DataByLevel.Count; i++)
				{
					GJALOMELEHD_Intimacy.MFMLEAMJJCH_LevelInfo m = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.KDIALKDKBGE_Intimacy.OOCKOCAACMD_DataByLevel[i];
					if(m.DMEDKJPOLCH > 0)
					{
						POJEFNEMGNN data = new POJEFNEMGNN();
						data.CIEOBFIIPLD = m.ANAJIAENLNB;
						data.GBJFNGCDKPM = (LPBGKOJDNJK)m.DMEDKJPOLCH;
						data.KDCMPJNGLBL = m.EIIDPKCBKEK_SkillLevel;
						data.KIJAPOFAGPN = m.ECEKNKIDING(AHHJLDLAPAN_DivaId - 1);
						LGPDCPDDECG.Add(data);
					}
				}
				CEBFFLDKAEC_SecureInt v = new CEBFFLDKAEC_SecureInt();
				MIKFKJKDOBI_TouchPoint = 100;
				if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.KDIALKDKBGE_Intimacy.OHJFBLFELNK_IntArray.TryGetValue("touch_point", out v))
				{
					MIKFKJKDOBI_TouchPoint = v.DNJEJEANJGL_Value;
				}
				JGLMDLKHFGG_FavBonus = 50;
				if (IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.KDIALKDKBGE_Intimacy.OHJFBLFELNK_IntArray.TryGetValue("favorite_bonus", out v))
				{
					JGLMDLKHFGG_FavBonus = v.DNJEJEANJGL_Value;
				}
				MFFJEALABOG_TensionBonus = 50;
				if (IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.KDIALKDKBGE_Intimacy.OHJFBLFELNK_IntArray.TryGetValue("tension_bonus", out v))
				{
					MFFJEALABOG_TensionBonus = v.DNJEJEANJGL_Value;
				}
				OMAEOHMDCLI_FirstPresentId = 0;
				if (IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.KDIALKDKBGE_Intimacy.OHJFBLFELNK_IntArray.TryGetValue("first_present_id", out v))
				{
					OMAEOHMDCLI_FirstPresentId = v.DNJEJEANJGL_Value;
				}
				HCDGELDHFHB(false);
			}
		}
	}

	//// RVA: 0x1352560 Offset: 0x1352560 VA: 0x1352560
	//private bool MOACIBEKLEN(int DNBFMLBNAEE) { }

	//// RVA: 0x1352ACC Offset: 0x1352ACC VA: 0x1352ACC
	//public bool HNMJKLEJLPC(int ADJBIEOILPJ, int HMFFHLPNMPH) { }

	//// RVA: 0x1353614 Offset: 0x1353614 VA: 0x1353614
	//public bool FNGFADPFKOD() { }

	//// RVA: 0x1353B44 Offset: 0x1353B44 VA: 0x1353B44
	//public int GMIEFBELJJH() { }

	//// RVA: 0x1353C04 Offset: 0x1353C04 VA: 0x1353C04
	//public long BPBIHCAMNBJ() { }

	//// RVA: 0x1353CC0 Offset: 0x1353CC0 VA: 0x1353CC0
	//public bool NJAKNMGEKFB(JJOELIOGMKK.LPBGKOJDNJK GBJFNGCDKPM, int KDCMPJNGLBL) { }

	//// RVA: 0x1353E74 Offset: 0x1353E74 VA: 0x1353E74
	public bool DOMNLGKLGEH_SetMaxSkillLevel(BBHNACPENDM_ServerSaveData LDEGEHAEALK_ServerSave, LPBGKOJDNJK GBJFNGCDKPM, int KDCMPJNGLBL_SkillLevel, bool FBBNPFFEJBN_SetValue)
	{
		if(GBJFNGCDKPM == LPBGKOJDNJK.JFEKIMDCKIH /*3*/)
		{
			if(!FBBNPFFEJBN_SetValue)
			{
				if (KDCMPJNGLBL_SkillLevel <= LDEGEHAEALK_ServerSave.DGCJCAHIAPP_Diva.LGKFMLIOPKL_GetDivaInfo(AHHJLDLAPAN_DivaId).JLEPLIHFPKD_IntimacySkillLevel)
					return false;
			}
			LDEGEHAEALK_ServerSave.DGCJCAHIAPP_Diva.LGKFMLIOPKL_GetDivaInfo(AHHJLDLAPAN_DivaId).JLEPLIHFPKD_IntimacySkillLevel = KDCMPJNGLBL_SkillLevel;
			return true;
		}
		return false;
	}

	//// RVA: 0x1353F40 Offset: 0x1353F40 VA: 0x1353F40
	public bool COOGHGBNEMB(BBHNACPENDM_ServerSaveData LDEGEHAEALK_ServerSave, int KIJAPOFAGPN, int HMFFHLPNMPH, int CIEOBFIIPLD)
	{
		JKNGJFOBADP data = new JKNGJFOBADP();
		data.JCHLONCMPAJ();
		data.FEGDNPIEKJC(OAGBCBBHMPF.COIIJOEKBDH.ACNGACBALGM/*20*/, AHHJLDLAPAN_DivaId.ToString() + ":" + 0); //?? unused r11 register instead of 0
		data.CPIICACGNBH(LDEGEHAEALK_ServerSave, KIJAPOFAGPN, HMFFHLPNMPH, null, 0);
		return false;
	}

	//// RVA: 0x1354088 Offset: 0x1354088 VA: 0x1354088
	//public bool AMHBDAMIAJM(BBHNACPENDM LDEGEHAEALK, int KIJAPOFAGPN, int HMFFHLPNMPH) { }

	//// RVA: 0x1351904 Offset: 0x1351904 VA: 0x1351904
	public void HCDGELDHFHB(bool FBBNPFFEJBN = false)
	{
		if (AHHJLDLAPAN_DivaId < 0)
			return;
		DEKKMGAFJCG_Diva saveDiva = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.DGCJCAHIAPP_Diva;
		GJALOMELEHD_Intimacy intimacyDb = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.KDIALKDKBGE_Intimacy;

		DEKKMGAFJCG_Diva.MNNLOBDPCCH_DivaInfo divaInfo = saveDiva.LGKFMLIOPKL_GetDivaInfo(AHHJLDLAPAN_DivaId);
		int lvl = HBODCMLFDOB.CPDEMMFGKED < 1 ? 1 : HBODCMLFDOB.CPDEMMFGKED;
		GJALOMELEHD_Intimacy.MFMLEAMJJCH_LevelInfo info1 = intimacyDb.OOCKOCAACMD_DataByLevel[lvl - 1];
		int exp1 = info1.BDLNMOIOMHK_StartExp;

		HEKJGCMNJAB_CurrentLevel = divaInfo.KCCONFODCPN_IntimacyLevel;
		if (HEKJGCMNJAB_CurrentLevel < 1)
			HEKJGCMNJAB_CurrentLevel = 1;
		GJALOMELEHD_Intimacy.MFMLEAMJJCH_LevelInfo curLevelInfo = intimacyDb.OOCKOCAACMD_DataByLevel[HEKJGCMNJAB_CurrentLevel - 1];
		KPEAGFJHNDP_CurrentLevelExp = divaInfo.BNDNNCHJGBB_IntimacyExp - curLevelInfo.BDLNMOIOMHK_StartExp;

		int nextLevel = HEKJGCMNJAB_CurrentLevel;
		int maxLevel = intimacyDb.GLHEHGGKILG_GetMaxLevel();
		if (maxLevel < nextLevel + 1)
			nextLevel = 0;
		GJALOMELEHD_Intimacy.MFMLEAMJJCH_LevelInfo nextLevelInfo = intimacyDb.OOCKOCAACMD_DataByLevel[nextLevel];
		KOKCFJDMJLI = nextLevelInfo.IHGDLBBPKFI;
		HBODCMLFDOB.EDPNAEOKGNM = maxLevel <= lvl;
		HBODCMLFDOB.PFIILLOIDIL = maxLevel <= HEKJGCMNJAB_CurrentLevel;
		CIOECGOMILE.HHCJCDFCLOB.AMCJPIIFHCA();
		if (CIOECGOMILE.HHCJCDFCLOB.MAEKFHENDAA())
		{
			for(int i = 0; i < saveDiva.NBIGLBMHEDC_DivaList.Count; i++)
			{
				saveDiva.EGDJODNNKDE_SetIntimacyTension(i, UnityEngine.Random.Range(1, 4));
			}
		}
		if(saveDiva.BOOKOGDDJGM_GetIntimacyTension(AHHJLDLAPAN_DivaId) == 0)
		{
			saveDiva.EGDJODNNKDE_SetIntimacyTension(AHHJLDLAPAN_DivaId, UnityEngine.Random.Range(1, 4));
		}
		NHCCINMHEAB = saveDiva.BOOKOGDDJGM_GetIntimacyTension(AHHJLDLAPAN_DivaId);
		HBODCMLFDOB.BJHAMEJPGAJ -= exp1;
		HBODCMLFDOB.EOIJEGJDLAN -= curLevelInfo.BDLNMOIOMHK_StartExp;
		HBODCMLFDOB.CKDNPHLDIEM.Clear();
		HBODCMLFDOB.EEIBCALKFFF.Clear();
		HBODCMLFDOB.IELPCAEACLL.Clear();
		HBODCMLFDOB.HBCBADBPNCJ.Clear();
		for(int i = HBODCMLFDOB.CPDEMMFGKED; i <= HBODCMLFDOB.KBHJOBKOOGC; i++)
		{
			GJALOMELEHD_Intimacy.MFMLEAMJJCH_LevelInfo levelInfo = intimacyDb.OOCKOCAACMD_DataByLevel[i];
			if (levelInfo.DMEDKJPOLCH >= 1)
			{
				DOMNLGKLGEH_SetMaxSkillLevel(CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave, (LPBGKOJDNJK)levelInfo.DMEDKJPOLCH, levelInfo.EIIDPKCBKEK_SkillLevel, FBBNPFFEJBN);
				HBODCMLFDOB.CKDNPHLDIEM.Add((LPBGKOJDNJK)levelInfo.DMEDKJPOLCH);
				int c = levelInfo.EIIDPKCBKEK_SkillLevel;
				if (levelInfo.DMEDKJPOLCH == 3 && levelInfo.EIIDPKCBKEK_SkillLevel > 0)
				{
					if (levelInfo.EIIDPKCBKEK_SkillLevel < intimacyDb.COHLJLNLBKM.Count)
					{
						c = intimacyDb.COHLJLNLBKM[levelInfo.EIIDPKCBKEK_SkillLevel - 1].JBGEEPFKIGG / 100;
					}
				}
				HBODCMLFDOB.EEIBCALKFFF.Add(c);
				int a = levelInfo.ECEKNKIDING(AHHJLDLAPAN_DivaId - 1);
				if (a > 0)
				{
					COOGHGBNEMB(CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave, a, 1, levelInfo.ANAJIAENLNB);
				}
				HBODCMLFDOB.IELPCAEACLL.Add(levelInfo.ECEKNKIDING(AHHJLDLAPAN_DivaId - 1));
				HBODCMLFDOB.HBCBADBPNCJ.Add("");
			}
		}
		HBODCMLFDOB.JHOBMMMEJHH_SkillLevel = divaInfo.JLEPLIHFPKD_IntimacySkillLevel;
		HBODCMLFDOB.IGNABALECPK = HBODCMLFDOB.JHOBMMMEJHH_SkillLevel < 1 ? 0 : intimacyDb.COHLJLNLBKM[HBODCMLFDOB.JHOBMMMEJHH_SkillLevel - 1].JBGEEPFKIGG / 100;
		CIOECGOMILE.HHCJCDFCLOB.MJNHMCABCGH();
	}

	//// RVA: 0x135338C Offset: 0x135338C VA: 0x135338C
	//public bool GACANKEBLEE(int ADJBIEOILPJ) { }

	//// RVA: 0x1353460 Offset: 0x1353460 VA: 0x1353460
	//public bool ANJLEBDBEGF(int ADJBIEOILPJ) { }

	//// RVA: 0x13541A8 Offset: 0x13541A8 VA: 0x13541A8
	//public bool NCNAPMHEINJ() { }

	//// RVA: 0x1354490 Offset: 0x1354490 VA: 0x1354490
	//public bool MLEPCANKIIE(int HMFFHLPNMPH) { }

	//// RVA: 0x1354534 Offset: 0x1354534 VA: 0x1354534
	//public int LLFDOKOMJAN() { }

	//// RVA: 0x1354620 Offset: 0x1354620 VA: 0x1354620
	//public string IGLBKDDCKEJ() { }

	//// RVA: 0x135472C Offset: 0x135472C VA: 0x135472C
	//public bool HFFOJIBDNOG() { }

	//// RVA: 0x13548B4 Offset: 0x13548B4 VA: 0x13548B4
	//public int JCFAPAOLDOI(int CIEOBFIIPLD) { }

	//// RVA: 0x13549E4 Offset: 0x13549E4 VA: 0x13549E4
	//public bool KCJCJLNHMKI() { }

	//// RVA: 0x1354D70 Offset: 0x1354D70 VA: 0x1354D70
	//public bool DNJEMPANDNN() { }

	//// RVA: 0x1354ED0 Offset: 0x1354ED0 VA: 0x1354ED0
	//public int HHLEJPBEHNE() { }
}