
using System.Collections.Generic;

public class ANPBHCNJIDI
{
	public enum NOJONDLAMOC
	{
		HJNNKCMLGFL = 0,
		CCAPCGPIIPF_1 = 1,
		DDPLFFAOAEB_2 = 2,
		CGEPNIOPFHF_3 = 3,
		JDGLJOFPHLK_4 = 4,
		JPOGBMJKPIJ_5 = 5,
	}

	public class NNPGLGHDBKN
	{
		public NOJONDLAMOC INDDJNMPONH; // 0x8
		public string OPFGFINHFCE_PlayerName; // 0xC
		public int OIPCCBHIKIA; // 0x10
		public int MLPEHNBNOGD; // 0x14
		public long EKEGHNPNCEH; // 0x18
		public int AHHJLDLAPAN_DivaId; // 0x20
		public int NNOHKLNKGAD_CostumeId; // 0x24
		public int DJHMGDKKKFO_ColorId; // 0x28
		public int MDPKLNFFDBO_EmblemId; // 0x2C
		public int KDHCKDHIHIP_EmblemCount; // 0x30
		public int AILEOFKIELL; // 0x34
		public int KIFEGLJLEDC_TotalUtaRate; // 0x38

		//public bool JOIOJMONLFL { get; } 0xD57020 OBJPIBFEIFM

		// RVA: 0xD553C8 Offset: 0xD553C8 VA: 0xD553C8
		public NNPGLGHDBKN()
		{
			KDHCKDHIHIP_EmblemCount = 0;
			AILEOFKIELL = 0;
			KIFEGLJLEDC_TotalUtaRate = 0;
			AHHJLDLAPAN_DivaId = 1;
			NNOHKLNKGAD_CostumeId = 1;
			DJHMGDKKKFO_ColorId = 0;
			MDPKLNFFDBO_EmblemId = 1;
		}

		//// RVA: 0xD554CC Offset: 0xD554CC VA: 0xD554CC Slot: 4
		//internal virtual bool KLAOLMDCLHO(BNAAJMBJFPG LBJACBOOLEL, EDOHBJAPLPF DLENPPIJNPA) { }

		//// RVA: 0xD55A40 Offset: 0xD55A40 VA: 0xD55A40 Slot: 5
		internal virtual void EFOOHDOMCAI(SakashoBbsCommentInfo KOGBMDOONFA, EDOHBJAPLPF_JsonData DLENPPIJNPA)
		{
			KOGBMDOONFA.Nickname = OPFGFINHFCE_PlayerName;
			KOGBMDOONFA.Content = "dummy";
			DLENPPIJNPA["dv"] = AHHJLDLAPAN_DivaId;
			DLENPPIJNPA["dvc"] = NNOHKLNKGAD_CostumeId;
			DLENPPIJNPA["dvcc"] = DJHMGDKKKFO_ColorId;
			DLENPPIJNPA["em"] = MDPKLNFFDBO_EmblemId;
			DLENPPIJNPA["emc"] = KDHCKDHIHIP_EmblemCount;
			DLENPPIJNPA["utarr"] = AILEOFKIELL;
			DLENPPIJNPA["utar"] = KIFEGLJLEDC_TotalUtaRate;
		}

		//// RVA: 0xD570D4 Offset: 0xD570D4 VA: 0xD570D4
		public void PCEHLFNFIDA(BBHNACPENDM_ServerSaveData AHEFHIMGIBI)
		{
			AHHJLDLAPAN_DivaId = AHEFHIMGIBI.MHEAEGMIKIE_PublicStatus.DIPKCALNIII_DivaId;
			NNOHKLNKGAD_CostumeId = AHEFHIMGIBI.MHEAEGMIKIE_PublicStatus.BEEAIAAJOHD_CostumeId;
			DJHMGDKKKFO_ColorId = AHEFHIMGIBI.MHEAEGMIKIE_PublicStatus.AFNIOJHODAG_CostumeColorId;
			MDPKLNFFDBO_EmblemId = AHEFHIMGIBI.MHEAEGMIKIE_PublicStatus.ABLOIBMGLFD_EmId;
			KDHCKDHIHIP_EmblemCount = AHEFHIMGIBI.MHEAEGMIKIE_PublicStatus.FHCAFLCLGAA_EmCnt;
			AILEOFKIELL = OEGIPPCADNA.BFKAHKBKBJE(AHEFHIMGIBI.MHEAEGMIKIE_PublicStatus.AILEOFKIELL_UtaRateRank, 0);
			KIFEGLJLEDC_TotalUtaRate = AHEFHIMGIBI.KCCLEHLLOFG_Common.EAHPKPADCPL_TotalUtaRate;
			if(NNOHKLNKGAD_CostumeId == 0)
			{
				NNOHKLNKGAD_CostumeId = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.MFPNGNMFEAL_Costume.LBDOLHGDIEB_GetUnlockedCostumeOrDefault(AHHJLDLAPAN_DivaId, 0).JPIDIENBGKH_CostumeId;
			}
		}
	}
 
	public class AIFBLOAGFOP : NNPGLGHDBKN
	{
		public string EBBJPBGHJOL; // 0x3C
		public bool LBODBHCBAMD; // 0x40

		// RVA: 0xD547F8 Offset: 0xD547F8 VA: 0xD547F8
		public AIFBLOAGFOP()
		{
			INDDJNMPONH = NOJONDLAMOC.CCAPCGPIIPF_1;
		}

		//// RVA: 0xD55410 Offset: 0xD55410 VA: 0xD55410 Slot: 4
		//internal override bool KLAOLMDCLHO(BNAAJMBJFPG LBJACBOOLEL, EDOHBJAPLPF DLENPPIJNPA) { }

		//// RVA: 0xD55940 Offset: 0xD55940 VA: 0xD55940 Slot: 5
		internal override void EFOOHDOMCAI(SakashoBbsCommentInfo KOGBMDOONFA, EDOHBJAPLPF_JsonData DLENPPIJNPA)
		{
			base.EFOOHDOMCAI(KOGBMDOONFA, DLENPPIJNPA);
			KOGBMDOONFA.Content = EBBJPBGHJOL;
			if (!LBODBHCBAMD)
				return;
			DLENPPIJNPA["vwt"] = 1;
		}
	}
 
	public class BNEIDPGIAFM : NNPGLGHDBKN
	{
		public int LIBPMIHHEJD; // 0x3C
		public int HEKIEDEBAEO_StampId; // 0x40
		public int EKAMPLIAENM_SerifId; // 0x44
		public int GKEKNMJMMPK; // 0x48

		// RVA: 0xD54848 Offset: 0xD54848 VA: 0xD54848
		public BNEIDPGIAFM()
		{
			INDDJNMPONH = NOJONDLAMOC.DDPLFFAOAEB_2;
		}

		//// RVA: 0xD55CE0 Offset: 0xD55CE0 VA: 0xD55CE0 Slot: 4
		//internal override bool KLAOLMDCLHO(BNAAJMBJFPG LBJACBOOLEL, EDOHBJAPLPF DLENPPIJNPA) { }

		//// RVA: 0xD55FB8 Offset: 0xD55FB8 VA: 0xD55FB8 Slot: 5
		internal override void EFOOHDOMCAI(SakashoBbsCommentInfo KOGBMDOONFA, EDOHBJAPLPF_JsonData DLENPPIJNPA)
		{
			base.EFOOHDOMCAI(KOGBMDOONFA, DLENPPIJNPA);
			DLENPPIJNPA["sdv"] = LIBPMIHHEJD;
			DLENPPIJNPA["smn"] = HEKIEDEBAEO_StampId;
			DLENPPIJNPA["scm"] = EKAMPLIAENM_SerifId;
			if (GKEKNMJMMPK == 0)
				return;
			DLENPPIJNPA["mcid"] = GKEKNMJMMPK;
		}
	}

	public class PHICILDLHJP : NNPGLGHDBKN
	{
		public string EBBJPBGHJOL; // 0x3C
		public int ICFCJOEMIIJ; // 0x40
		public string PHGNPFJIBLF; // 0x44
		public bool CKIIGKKHDMP; // 0x48

		//public bool MCINBHIPLML { get; } 0xD573D0 EGCEBDCDLDM

		// RVA: 0xD566B0 Offset: 0xD566B0 VA: 0xD566B0
		public PHICILDLHJP()
		{
			//
		}

		//// RVA: 0xD566F8 Offset: 0xD566F8 VA: 0xD566F8 Slot: 4
		//internal override bool KLAOLMDCLHO(BNAAJMBJFPG LBJACBOOLEL, EDOHBJAPLPF DLENPPIJNPA) { }

		//// RVA: 0xD5681C Offset: 0xD5681C VA: 0xD5681C Slot: 5
		internal override void EFOOHDOMCAI(SakashoBbsCommentInfo KOGBMDOONFA, EDOHBJAPLPF_JsonData DLENPPIJNPA)
		{
			base.EFOOHDOMCAI(KOGBMDOONFA, DLENPPIJNPA);
			if(!string.IsNullOrEmpty(PHGNPFJIBLF))
			{
				DLENPPIJNPA["orid"] = ICFCJOEMIIJ;
				DLENPPIJNPA["ornm"] = PHGNPFJIBLF;
				DLENPPIJNPA["auto"] = CKIIGKKHDMP ? 1 : 0;
			}
			KOGBMDOONFA.Content = EBBJPBGHJOL;
		}
	}

	public class KNGOGLLMKDL : PHICILDLHJP
	{
		public int HALIDDHLNEG; // 0x4C
		public int MFMPCHIJINJ; // 0x50

		// RVA: 0xD54898 Offset: 0xD54898 VA: 0xD54898
		public KNGOGLLMKDL()
		{
			INDDJNMPONH = NOJONDLAMOC.CGEPNIOPFHF_3;
		}

		//// RVA: 0xD56350 Offset: 0xD56350 VA: 0xD56350 Slot: 4
		//internal override bool KLAOLMDCLHO(BNAAJMBJFPG LBJACBOOLEL, EDOHBJAPLPF DLENPPIJNPA) { }

		//// RVA: 0xD56598 Offset: 0xD56598 VA: 0xD56598 Slot: 5
		internal override void EFOOHDOMCAI(SakashoBbsCommentInfo KOGBMDOONFA, EDOHBJAPLPF_JsonData DLENPPIJNPA)
		{
			base.EFOOHDOMCAI(KOGBMDOONFA, DLENPPIJNPA);
			DLENPPIJNPA["dme"] = HALIDDHLNEG;
			DLENPPIJNPA["btp"] = MFMPCHIJINJ;
		}
	}

	public class NBHIMCACDHM : PHICILDLHJP
	{
		public string GJAOLNLFEBD; // 0x4C
		public int EJGDHAENIDC; // 0x50
		public int PCPODOMOFDH; // 0x54
		public int JNBDLNBKDCO; // 0x58
		public int HALIDDHLNEG; // 0x5C
		public int KKPAHLMJKIH; // 0x60
		public bool IGNJCGMLBDA; // 0x64
		public bool IKICLMGFFPB; // 0x65
		public int CNOHJPEHHCH; // 0x68

		// RVA: 0xD548E8 Offset: 0xD548E8 VA: 0xD548E8
		public NBHIMCACDHM()
		{
			INDDJNMPONH = NOJONDLAMOC.JDGLJOFPHLK_4;
		}

		//// RVA: 0xD569DC Offset: 0xD569DC VA: 0xD569DC Slot: 4
		//internal override bool KLAOLMDCLHO(BNAAJMBJFPG LBJACBOOLEL, EDOHBJAPLPF DLENPPIJNPA) { }

		//// RVA: 0xD56CE4 Offset: 0xD56CE4 VA: 0xD56CE4 Slot: 5
		internal override void EFOOHDOMCAI(SakashoBbsCommentInfo KOGBMDOONFA, EDOHBJAPLPF_JsonData DLENPPIJNPA)
		{
			base.EFOOHDOMCAI(KOGBMDOONFA, DLENPPIJNPA);
			DLENPPIJNPA["bnm"] = GJAOLNLFEBD;
			DLENPPIJNPA["brk"] = EJGDHAENIDC;
			DLENPPIJNPA["bsr"] = PCPODOMOFDH;
			DLENPPIJNPA["bim"] = JNBDLNBKDCO;
			DLENPPIJNPA["dme"] = HALIDDHLNEG;
			DLENPPIJNPA["wav"] = KKPAHLMJKIH;
			DLENPPIJNPA["def"] = IGNJCGMLBDA ? 1 : 0;
			DLENPPIJNPA["bsp"] = IKICLMGFFPB ? 1 : 0;
			DLENPPIJNPA["sid"] = CNOHJPEHHCH;
		}
	}

	public class JLHGKKIEALB : KNGOGLLMKDL
	{
		public int ADHMMMEOJMK; // 0x54
		public int AKNELONELJK; // 0x58
		public bool GIKLNODJKFK; // 0x5C

		//public bool IGNJCGMLBDA { get; } 0xD56184

		// RVA: 0xD54938 Offset: 0xD54938 VA: 0xD54938
		public JLHGKKIEALB()
		{
			INDDJNMPONH = NOJONDLAMOC.JPOGBMJKPIJ_5;
		}

		//// RVA: 0xD56198 Offset: 0xD56198 VA: 0xD56198 Slot: 4
		//internal override bool KLAOLMDCLHO(BNAAJMBJFPG LBJACBOOLEL, EDOHBJAPLPF DLENPPIJNPA) { }

		//// RVA: 0xD56410 Offset: 0xD56410 VA: 0xD56410 Slot: 5
		internal override void EFOOHDOMCAI(SakashoBbsCommentInfo KOGBMDOONFA, EDOHBJAPLPF_JsonData DLENPPIJNPA)
		{
			base.EFOOHDOMCAI(KOGBMDOONFA, DLENPPIJNPA);
			DLENPPIJNPA["fid"] = ADHMMMEOJMK;
			DLENPPIJNPA["dif"] = AKNELONELJK;
			DLENPPIJNPA["ln6"] = GIKLNODJKFK ? 1 : 0;
		}
	}

	private KEPNMGHABPI AMDPJLBPLIG; // 0x8
	private SakashoBbsCommentCriteria OLOHJCBNIFI = new SakashoBbsCommentCriteria() { ExcludeDeleted = true }; // 0xC
	public List<NNPGLGHDBKN> HDMKAIKOMCB = new List<NNPGLGHDBKN>(); // 0x10

	//// RVA: 0xD54160 Offset: 0xD54160 VA: 0xD54160
	//public static bool JCGBEAHDNEI(ANPBHCNJIDI.NOJONDLAMOC INDDJNMPONH) { }

	//// RVA: 0xD54174 Offset: 0xD54174 VA: 0xD54174
	public void OBKGEDCKHHE(string JIHGLOIIGON, int EMGJJFKONHK, bool LAGDKBMDHLD = false)
	{
		BNJJHPEGNAI.HCAJEKFFNBM data = new BNJJHPEGNAI.HCAJEKFFNBM();
		data.KGICDMIJGDF = JIHGLOIIGON;
		data.EMGJJFKONHK_ExpireDays = EMGJJFKONHK;
		data.BDNDHFBNBLL_ExcludeBlockedThread = LAGDKBMDHLD;
		AMDPJLBPLIG = KEPNMGHABPI.OGIFFNLIDIO.GOAMILGNJIE(data);
	}

	//// RVA: 0xD54290 Offset: 0xD54290 VA: 0xD54290
	public void HGBINHBILCP()
	{
		AMDPJLBPLIG.IPBDPLOKLLP();
		HDMKAIKOMCB.Clear();
	}

	//// RVA: 0xD54328 Offset: 0xD54328 VA: 0xD54328
	//public void HDGIBKFJDOG(int KPNKPGLPDHI, int MKLHCKJEKKC, IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG) { }

	//// RVA: 0xD5436C Offset: 0xD5436C VA: 0xD5436C
	public void GBLHONFLPPD(int KPNKPGLPDHI, int MKLHCKJEKKC, IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG)
	{
		AMDPJLBPLIG.EMHMAJDNEJB(KPNKPGLPDHI, (List<KEPNMGHABPI.CAIPMAMHNJP> CEGPFLLDBGM) =>
		{
			//0xD550F8
			for(int i = 0; i < CEGPFLLDBGM.Count; i++)
			{
				GCONPMCMEGA(CEGPFLLDBGM[i].CCBEKGNDDBE);
			}
			BHFHGFKBOHH();
		}, MOBEEPPKFLG, MKLHCKJEKKC, OLOHJCBNIFI);
	}

	//// RVA: 0xD544A8 Offset: 0xD544A8 VA: 0xD544A8
	private void GCONPMCMEGA(BNAAJMBJFPG LBJACBOOLEL)
	{
		TodoLogger.LogError(0, "GCONPMCMEGA");
	}

	//// RVA: 0xD54988 Offset: 0xD54988 VA: 0xD54988
	public bool GMNAECEEHHJ()
	{
		return AMDPJLBPLIG.JGGFDPHHKJD();
	}

	//// RVA: 0xD549B4 Offset: 0xD549B4 VA: 0xD549B4
	private SakashoBbsCommentInfo EEGECGEGPHM(NNPGLGHDBKN HCAHCFGPJIF)
	{
		SakashoBbsCommentInfo res = new SakashoBbsCommentInfo();
		EDOHBJAPLPF_JsonData json = new EDOHBJAPLPF_JsonData();
		json["type"] = (int)HCAHCFGPJIF.INDDJNMPONH;
		HCAHCFGPJIF.OPFGFINHFCE_PlayerName = CIOECGOMILE.HHCJCDFCLOB.AHEFHIMGIBI_ServerSave.JHFIPCIHJNL_Base.OPFGFINHFCE_PlayerName;
		HCAHCFGPJIF.EFOOHDOMCAI(res, json);
		res.Extra = json.EJCOJCGIBNG_ToJson(); //IKPIMINCOPI_JsonMapper.EJCOJCGIBNG_ToJson(json);
		return res;
	}

	//// RVA: 0xD54BD4 Offset: 0xD54BD4 VA: 0xD54BD4
	public void NPIBJOGODKG(int KPNKPGLPDHI, NNPGLGHDBKN HCAHCFGPJIF, IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG, DJBHIFLHJLK NKGHADCBGJO)
	{
		AMDPJLBPLIG.IFFGEIMIKHH(KPNKPGLPDHI, EEGECGEGPHM(HCAHCFGPJIF), () =>
		{
			//0xD5521C
			BHFHGFKBOHH();
		}, MOBEEPPKFLG, NKGHADCBGJO);
	}

	//// RVA: 0xD54CF0 Offset: 0xD54CF0 VA: 0xD54CF0
	//public void HCMMMCFFGCA(int KPNKPGLPDHI, ANPBHCNJIDI.NNPGLGHDBKN HCAHCFGPJIF, IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG) { }

	//// RVA: 0xD54E88 Offset: 0xD54E88 VA: 0xD54E88
	//public void NCLDLJLAEBK(int KPNKPGLPDHI, ANPBHCNJIDI.NNPGLGHDBKN HCAHCFGPJIF, IMCBBOAFION BHFHGFKBOHH, DJBHIFLHJLK MOBEEPPKFLG) { }
}
