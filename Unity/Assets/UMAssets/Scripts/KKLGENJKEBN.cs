
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void LIOLBKLMMIK(int NEFEFHBHFFF, List<IBIGBMDANNM> EHIENOACCIL);

public class KKLGENJKEBN
{
	public List<EECOJKDJIFG> JPDPFGFMKHK = new List<EECOJKDJIFG>(); // 0x8
	public long LPPCNCMEDFA; // 0x10
	public long IPNEJCOFBIB; // 0x18
	public bool DFBALJAPHMC; // 0x20
	public List<GJDFHLBONOL> PHOPJDPEHJA = new List<GJDFHLBONOL>(); // 0x24
	public bool LNHFLJBGGJB; // 0x28
	public SakashoErrorId CJMFJOMECKI_ErrorId; // 0x2C
	private int MLPLGFLKKLI = 10; // 0x30
	private int AOPELJFAMCL = 5; // 0x34
	private int NLHAJLNAEMC = 3; // 0x38
	private List<CHPIKCFKJOA> ICJOJOPKNBK = new List<CHPIKCFKJOA>(50); // 0x3C
	private long NDBHONKHCEG; // 0x40
	private int MEMPPLMGNKN; // 0x48
	private bool EBJDDBPFNPB; // 0x4C
	public bool KCIDANFAFPP; // 0x4D

	public static KKLGENJKEBN HHCJCDFCLOB { get; private set; } // 0x0 LGMPACEDIJF NKACBOEHELJ OKPMHKNCNAL

	//// RVA: 0x1A04BA4 Offset: 0x1A04BA4 VA: 0x1A04BA4
	//public void KMBMMCDPKDF(bool JKDJCFEBDHC, int FJOLNJLLJEJ) { }

	//// RVA: 0x1A04BA8 Offset: 0x1A04BA8 VA: 0x1A04BA8
	//public void PAHLEGMEKHI(int KNIFCANOHOC) { }

	//// RVA: 0x1A04BAC Offset: 0x1A04BAC VA: 0x1A04BAC
	public void IJBGPAENLJA(MonoBehaviour DANMJLOBLIE)
	{
		HHCJCDFCLOB = this;
	}

	//// RVA: 0x1A04C10 Offset: 0x1A04C10 VA: 0x1A04C10
	public void PMJOEBCEGBP_GetRankings(IMCBBOAFION KLMFJJCNBIP, DJBHIFLHJLK JGKOLBLPMPG)
	{
		KNHMEGDFNBP_GetRankings req = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.IFFNCAFNEAG_AddRequest(new KNHMEGDFNBP_GetRankings());
		req.BHFHGFKBOHH_OnSuccess = (CACGCMBKHDI_Request NHECPMNKEFK) => {
			//0x1A06844
			KNHMEGDFNBP_GetRankings r = NHECPMNKEFK as KNHMEGDFNBP_GetRankings;
			if(r.NFEAMMJIMPG.JPDPFGFMKHK.Count == 0)
			{
				LNHFLJBGGJB = false;
				KLMFJJCNBIP();
			}
			else
			{
				List<string> strs = new List<string>();
				for(int i = 0; i < r.NFEAMMJIMPG.JPDPFGFMKHK.Count; i++)
				{
					strs.Add(r.NFEAMMJIMPG.JPDPFGFMKHK[i].OCGFKMHNEOF);
				}
				FIDDMIAEFEA_GetRankingRecordsByKeys req2 = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.IFFNCAFNEAG_AddRequest(new FIDDMIAEFEA_GetRankingRecordsByKeys());
				req2.JIMKNDJMCID = strs;
				CACGCMBKHDI_Request.HDHIKGLMOGF CMJMGEFNBDK = (CACGCMBKHDI_Request DLMLKJACBPM) => {
					//0x1A06BE8
					FIDDMIAEFEA_GetRankingRecordsByKeys r2 = DLMLKJACBPM as FIDDMIAEFEA_GetRankingRecordsByKeys;
					JPDPFGFMKHK = r2.NFEAMMJIMPG.JPDPFGFMKHK;
					LNHFLJBGGJB = false;
					KLMFJJCNBIP();
				};
				req2.BHFHGFKBOHH_OnSuccess = CMJMGEFNBDK;
				CACGCMBKHDI_Request.HDHIKGLMOGF DMLJLPMBLCH = (CACGCMBKHDI_Request DLMLKJACBPM) => {
					//0x1A06D44
					CJMFJOMECKI_ErrorId = NHECPMNKEFK.CJMFJOMECKI_ErrorId;
					LNHFLJBGGJB = false;
					JGKOLBLPMPG();
				};
			}

		};
		req.MOBEEPPKFLG_OnFail = (CACGCMBKHDI_Request NHECPMNKEFK) => {
			//0x1A06DCC
			CJMFJOMECKI_ErrorId = NHECPMNKEFK.CJMFJOMECKI_ErrorId;
			LNHFLJBGGJB = false;
			JGKOLBLPMPG();
		};
	}

	//// RVA: 0x1A04E30 Offset: 0x1A04E30 VA: 0x1A04E30
	public void LDOBHAAIDEJ_UpdateRankingScore(string LJNAKDMILMC, int LHJCOPMMIGO, double HOCPLDLAIGL, IMCBBOAFION KLMFJJCNBIP, DJBHIFLHJLK NEFKBBNKNPP, DJBHIFLHJLK JGKOLBLPMPG)
	{
		if(LJNAKDMILMC == "*")
		{
			if(JPDPFGFMKHK.Count == 0)
			{
				NEFKBBNKNPP();
				return;
			}
			LJNAKDMILMC = JPDPFGFMKHK[LHJCOPMMIGO].OCGFKMHNEOF;
		}

		EECOJKDJIFG IDHFDLLDCEL = JPDPFGFMKHK.Find((EECOJKDJIFG HKICMNAACDA) =>
		{
			//0x1A06E54
			return HKICMNAACDA.OCGFKMHNEOF == LJNAKDMILMC;
		});
		if(IDHFDLLDCEL != null)
		{
			LNHFLJBGGJB = true;
			FPFPJKJNOFK_UpdateRankingScore req = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.IFFNCAFNEAG_AddRequest(new FPFPJKJNOFK_UpdateRankingScore());
			req.EMPNJPMAKBF_Id = IDHFDLLDCEL.PPFNGGCBJKC;
			req.HOCPLDLAIGL_Score = HOCPLDLAIGL;
			req.BHFHGFKBOHH_OnSuccess = (CACGCMBKHDI_Request NHECPMNKEFK) =>
			{
				//0x1A06E88
				FPFPJKJNOFK_UpdateRankingScore r = NHECPMNKEFK as FPFPJKJNOFK_UpdateRankingScore;
				TodoLogger.Log(0, "BHFHGFKBOHH_OnSuccess");
			};
			req.MOBEEPPKFLG_OnFail = (CACGCMBKHDI_Request NHECPMNKEFK) =>
			{
				//0x1A072B0
				TodoLogger.Log(0, "MOBEEPPKFLG_OnFail");
			};
			return;
		}
		NEFKBBNKNPP();
	}

	//// RVA: 0x1A0528C Offset: 0x1A0528C VA: 0x1A0528C
	//public void DNJKPPCBINA(string LJNAKDMILMC, IMCBBOAFION KLMFJJCNBIP, DJBHIFLHJLK PDPNECFNLNI, IMCBBOAFION FHKCKGJPFFO, DJBHIFLHJLK PPCMIJIFPGP, DJBHIFLHJLK BFKEGJMPELF, int BLJMMMABHDA = 0, int BBLCHHIGFAE = -1) { }

	//// RVA: 0x1A057E0 Offset: 0x1A057E0 VA: 0x1A057E0
	public void FAMFKPBPIAA_GetRankingPlayerList(string LJNAKDMILMC, bool PFFJNEFNAMI, int CJHEHIMLGGL, int LHJCOPMMIGO, LIOLBKLMMIK KLMFJJCNBIP, DJBHIFLHJLK IDAEHNGOKAE, DJBHIFLHJLK JGKOLBLPMPG, bool EEJADLBBMLH = false)
	{
		N.a.StartCoroutineWatched(BHBKPEOMNJH_Coroutine_RankingPlayerList(LJNAKDMILMC, PFFJNEFNAMI, CJHEHIMLGGL, LHJCOPMMIGO, KLMFJJCNBIP, IDAEHNGOKAE, JGKOLBLPMPG, false));
	}

	//[IteratorStateMachineAttribute] // RVA: 0x6BA354 Offset: 0x6BA354 VA: 0x6BA354
	//// RVA: 0x1A05860 Offset: 0x1A05860 VA: 0x1A05860
	private IEnumerator BHBKPEOMNJH_Coroutine_RankingPlayerList(string LJNAKDMILMC, bool PFFJNEFNAMI, int CJHEHIMLGGL, int LHJCOPMMIGO, LIOLBKLMMIK KLMFJJCNBIP, DJBHIFLHJLK IDAEHNGOKAE, DJBHIFLHJLK JGKOLBLPMPG, bool EEJADLBBMLH = false)
	{
		EECOJKDJIFG FEHKCPCAKPN; // 0x38
		PJKLMCGEJMK JFAIABBIPEO; // 0x3C
		NAOOAJGKILJ_GetFriends FPKPDCLFCJP; // 0x40

		//0x1A0A754
		bool b = false;
		if(LJNAKDMILMC == "*")
		{
			if(JPDPFGFMKHK.Count != 0)
			{
				LJNAKDMILMC = JPDPFGFMKHK[LHJCOPMMIGO].OCGFKMHNEOF;
				b = true;
			}
		}
		else
		{
			b = true;
		}
		if (b)
		{
			FEHKCPCAKPN = JPDPFGFMKHK.Find((EECOJKDJIFG HKICMNAACDA) =>
			{
				// 0x1A08134
				return HKICMNAACDA.OCGFKMHNEOF == LJNAKDMILMC;
			});
			if (FEHKCPCAKPN != null)
			{
				MEMPPLMGNKN = FEHKCPCAKPN.PPFNGGCBJKC;
				EBJDDBPFNPB = PFFJNEFNAMI;
				JFAIABBIPEO = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester;
				FPKPDCLFCJP = null;
				//CIOECGOMILE.HHCJCDFCLOB.CHNJPFCKFOI_FriendManager.JPEIBHJIHPI_FriendLimit;
				ICJOJOPKNBK.Clear();
				int a = 1;
				while (true)
				{
					//LAB_01a0acf4
					FPKPDCLFCJP = JFAIABBIPEO.IFFNCAFNEAG_AddRequest(new NAOOAJGKILJ_GetFriends());
					FPKPDCLFCJP.IGNIIEBMFIN_Page = 1;
					FPKPDCLFCJP.MLPLGFLKKLI_Ipp = 100;
					yield return FPKPDCLFCJP.GDPDELLNOBO_WaitDone(N.a);
					if (!FPKPDCLFCJP.NPNNPNAIONN_IsError)
					{
						for (int i = 0; i < FPKPDCLFCJP.NFEAMMJIMPG.HBOIBKJEIAP_Friends.Count; i++)
						{
							ICJOJOPKNBK.Add(FPKPDCLFCJP.NFEAMMJIMPG.HBOIBKJEIAP_Friends[i]);
						}
						if (FPKPDCLFCJP.NFEAMMJIMPG.MDIBIIHAAPN_NextPage < 1)
						{
							if (CJHEHIMLGGL != 0)
							{
								BJKCAKJHMPC_GetTopRanks(CJHEHIMLGGL, KLMFJJCNBIP, IDAEHNGOKAE, JGKOLBLPMPG, EEJADLBBMLH);
								yield break;
							}
							OKPEFAPPFDH_GetRanksAroundSelf req = JFAIABBIPEO.IFFNCAFNEAG_AddRequest(new OKPEFAPPFDH_GetRanksAroundSelf());
							req.EMPNJPMAKBF_Id = FEHKCPCAKPN.PPFNGGCBJKC;
							req.MJGOBEGONON_Type = PFFJNEFNAMI ? 1 : 0;
							req.NHPCKCOPKAM_From = -AOPELJFAMCL;
							req.PJFKNNNDMIA_To = AOPELJFAMCL;
							req.MOBEEPPKFLG_OnFail = (CACGCMBKHDI_Request NHECPMNKEFK) =>
							{
								//0x1A08168
								TodoLogger.Log(0, "OnFail");
							};
							req.BHFHGFKBOHH_OnSuccess = (CACGCMBKHDI_Request NHECPMNKEFK) =>
							{
								//0x1A082C0
								List<int> l = new List<int>();
								OKPEFAPPFDH_GetRanksAroundSelf r = NHECPMNKEFK as OKPEFAPPFDH_GetRanksAroundSelf;
								if(r.NFEAMMJIMPG.EJDEDOJFOOK.Count == 0)
								{
									BJKCAKJHMPC_GetTopRanks(1, KLMFJJCNBIP, IDAEHNGOKAE, JGKOLBLPMPG, EEJADLBBMLH);
								}
								else
								{
									for(int i = 0; i < r.NFEAMMJIMPG.EJDEDOJFOOK.Count; i++)
									{
										l.Add(r.NFEAMMJIMPG.EJDEDOJFOOK[i].EHGBICNIBKE_PlayerId);
									}
									FGEIGGNCGGD_GetPlayerData(l, CJHEHIMLGGL, 0, r.NFEAMMJIMPG.EJDEDOJFOOK, KLMFJJCNBIP, IDAEHNGOKAE, JGKOLBLPMPG, EEJADLBBMLH);
								}
							};
							yield break;
						}
						a = FPKPDCLFCJP.NFEAMMJIMPG.MDIBIIHAAPN_NextPage;
						continue;
					}
					else
					{
						CJMFJOMECKI_ErrorId = FPKPDCLFCJP.CJMFJOMECKI_ErrorId;
						if (JGKOLBLPMPG != null)
							JGKOLBLPMPG();
						yield break;
					}
				}
			}
		}
		if (IDAEHNGOKAE != null)
			IDAEHNGOKAE();
	}

	//// RVA: 0x1A059E4 Offset: 0x1A059E4 VA: 0x1A059E4
	private void BJKCAKJHMPC_GetTopRanks(int CJHEHIMLGGL, LIOLBKLMMIK KLMFJJCNBIP, DJBHIFLHJLK IDAEHNGOKAE, DJBHIFLHJLK JGKOLBLPMPG, bool EEJADLBBMLH = false)
	{
		PPFGOOFFNMB_GetTopRanks req = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.IFFNCAFNEAG_AddRequest(new PPFGOOFFNMB_GetTopRanks(false));
		req.EMPNJPMAKBF_Id = MEMPPLMGNKN;
		req.MJGOBEGONON_Type = EBJDDBPFNPB ? 1 : 0;
		req.IGNIIEBMFIN_Page = (CJHEHIMLGGL - 1) / MLPLGFLKKLI;
		req.MLPLGFLKKLI_Ipp = MLPLGFLKKLI;
		req.MOBEEPPKFLG_OnFail = (CACGCMBKHDI_Request NHECPMNKEFK) =>
		{
			//0x1A08614
			TodoLogger.Log(0, "On Error");
		};
		req.BHFHGFKBOHH_OnSuccess = (CACGCMBKHDI_Request NHECPMNKEFK) =>
		{
			//0x1A0871C
			PPFGOOFFNMB_GetTopRanks r = NHECPMNKEFK as PPFGOOFFNMB_GetTopRanks;
			if(r.NFEAMMJIMPG.EJDEDOJFOOK.Count == 0)
			{
				KLMFJJCNBIP(0, null);
			}
			else
			{
				List<int> res = new List<int>();
				for (int i = 0; i < r.NFEAMMJIMPG.EJDEDOJFOOK.Count; i++)
				{
					res.Add(r.NFEAMMJIMPG.EJDEDOJFOOK[i].EHGBICNIBKE_PlayerId);
				}
				FGEIGGNCGGD_GetPlayerData(res, CJHEHIMLGGL, 0, r.NFEAMMJIMPG.EJDEDOJFOOK, KLMFJJCNBIP, IDAEHNGOKAE, JGKOLBLPMPG, EEJADLBBMLH);
			}
		};
	}

	//// RVA: 0x1A05CE4 Offset: 0x1A05CE4 VA: 0x1A05CE4
	public void JPNACOLKHLB(int CJHEHIMLGGL, int NEFEFHBHFFF, LIOLBKLMMIK KLMFJJCNBIP, DJBHIFLHJLK IDAEHNGOKAE, DJBHIFLHJLK JGKOLBLPMPG, bool EEJADLBBMLH = false)
	{
		TodoLogger.Log(0, "JPNACOLKHLB");
	}

	//[IteratorStateMachineAttribute] // RVA: 0x6BA3CC Offset: 0x6BA3CC VA: 0x6BA3CC
	//// RVA: 0x1A05D58 Offset: 0x1A05D58 VA: 0x1A05D58
	//private IEnumerator ACAJCMEIJCH_AddRankingPlayerListSecond(int CJHEHIMLGGL, int NEFEFHBHFFF, LIOLBKLMMIK KLMFJJCNBIP, DJBHIFLHJLK IDAEHNGOKAE, DJBHIFLHJLK JGKOLBLPMPG, bool EEJADLBBMLH = False) { }

	//// RVA: 0x1A05EA4 Offset: 0x1A05EA4 VA: 0x1A05EA4
	private void FGEIGGNCGGD_GetPlayerData(List<int> HMDAFLDJLIK, int CJHEHIMLGGL, int NEFEFHBHFFF, List<OBGBKHKMDNF> NFMMAELFANG, LIOLBKLMMIK KLMFJJCNBIP, DJBHIFLHJLK IDAEHNGOKAE, DJBHIFLHJLK JGKOLBLPMPG, bool EEJADLBBMLH)
	{
		PJKLMCGEJMK CPHFEPHDJIB = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester;
		NJNCAHLIHNI_GetPlayerData req = CPHFEPHDJIB.IFFNCAFNEAG_AddRequest(new NJNCAHLIHNI_GetPlayerData());
		req.FAMHAPONILI = HMDAFLDJLIK;
		List<IBIGBMDANNM> IODPMHILFDI = new List<IBIGBMDANNM>();
		BBHNACPENDM_ServerSaveData b = new BBHNACPENDM_ServerSaveData();
		b.EBKCPELHDKN_InitWithBaseAndPublicStatus();
		req.HHIHCJKLJFF = b.KPIDBPEKMFD_GetBlockList();
		CACGCMBKHDI_Request.HDHIKGLMOGF PINPBOCDKLI = (CACGCMBKHDI_Request NHECPMNKEFK) =>
		{
			//0x1A09288
			IODPMHILFDI.Sort((IBIGBMDANNM HKICMNAACDA, IBIGBMDANNM BNKHBCBJBKI) =>
			{
				//0x1A06704
				return HKICMNAACDA.FJOLNJLLJEJ - BNKHBCBJBKI.FJOLNJLLJEJ;
			});
			List<IBIGBMDANNM> list = IODPMHILFDI;
			int a = 0;
			if (!EEJADLBBMLH)
			{
				if(NEFEFHBHFFF != 0)
				{
					if(NEFEFHBHFFF == 1)
					{
						IODPMHILFDI.Sort((IBIGBMDANNM HKICMNAACDA, IBIGBMDANNM BNKHBCBJBKI) =>
						{
							//0x1A06804
							return HKICMNAACDA.FJOLNJLLJEJ - BNKHBCBJBKI.FJOLNJLLJEJ;
						});
						List<IBIGBMDANNM> l = new List<IBIGBMDANNM>();
						for(int i = 0; i < IODPMHILFDI.Count; i++)
						{
							if(CJHEHIMLGGL < IODPMHILFDI[i].FJOLNJLLJEJ)
							{
								l.Add(IODPMHILFDI[i]);
							}
						}
						list = l;
						a = 1;
					}
					else
					{
						if (NEFEFHBHFFF == -1)
							return;
						IODPMHILFDI.Sort((IBIGBMDANNM HKICMNAACDA, IBIGBMDANNM BNKHBCBJBKI) =>
						{
							//0x1A067C4
							return HKICMNAACDA.FJOLNJLLJEJ - BNKHBCBJBKI.FJOLNJLLJEJ;
						});
						List<IBIGBMDANNM> l = new List<IBIGBMDANNM>();
						for (int i = 0; i < IODPMHILFDI.Count; i++)
						{
							if (IODPMHILFDI[i].FJOLNJLLJEJ < CJHEHIMLGGL)
							{
								l.Add(IODPMHILFDI[i]);
							}
						}
						list = l;
						a = -1;
					}
				}
			}
			else
			{
				if(NEFEFHBHFFF != 0)
				{
					if(NEFEFHBHFFF == 1)
					{
						IODPMHILFDI.Sort((IBIGBMDANNM HKICMNAACDA, IBIGBMDANNM BNKHBCBJBKI) =>
						{
							//0x1A06784
							return HKICMNAACDA.FJOLNJLLJEJ - BNKHBCBJBKI.FJOLNJLLJEJ;
						});
						List<IBIGBMDANNM> l = new List<IBIGBMDANNM>();
						for (int i = 0; i < IODPMHILFDI.Count; i++)
						{
							l.Add(IODPMHILFDI[i]);
						}
						list = l;
						a = 1;
					}
					else
					{
						if (NEFEFHBHFFF == -1)
							return;
						IODPMHILFDI.Sort((IBIGBMDANNM HKICMNAACDA, IBIGBMDANNM BNKHBCBJBKI) =>
						{
							//0x1A06744
							return HKICMNAACDA.FJOLNJLLJEJ - BNKHBCBJBKI.FJOLNJLLJEJ;
						});
						List<IBIGBMDANNM> l = new List<IBIGBMDANNM>();
						for (int i = 0; i < IODPMHILFDI.Count; i++)
						{
							l.Add(IODPMHILFDI[i]);
						}
						list = l;
						a = -1;
					}
				}
			}
			KLMFJJCNBIP(a, list);
		};
		req.BHFHGFKBOHH_OnSuccess = PINPBOCDKLI;
		req.MOBEEPPKFLG_OnFail = (CACGCMBKHDI_Request NHECPMNKEFK) =>
		{
			//0x1A09D08
			TodoLogger.Log(0, "On Fail");
		};
	}

	//// RVA: 0x1A061F0 Offset: 0x1A061F0 VA: 0x1A061F0
	public void HEOKADCEAGL_GetRanks(string LJNAKDMILMC, IMCBBOAFION KLMFJJCNBIP_OnSuccess, DJBHIFLHJLK IDAEHNGOKAE_OnRankingError, DJBHIFLHJLK BFKEGJMPELF_OnError, DJBHIFLHJLK OPJANCPEKAB_OnDroppedPlayerError)
	{
		LPPCNCMEDFA = 0;
		IPNEJCOFBIB = 0;
		EECOJKDJIFG data = JPDPFGFMKHK.Find((EECOJKDJIFG HKICMNAACDA) =>
		{
			//0x1A09DF8
			return HKICMNAACDA.OCGFKMHNEOF == LJNAKDMILMC;
		});
		if(data == null)
		{
			IDAEHNGOKAE_OnRankingError();
			return;
		}
		MEMPPLMGNKN = data.PPFNGGCBJKC;
		OKPEFAPPFDH_GetRanksAroundSelf req = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.IFFNCAFNEAG_AddRequest(new OKPEFAPPFDH_GetRanksAroundSelf());
		req.EMPNJPMAKBF_Id = data.PPFNGGCBJKC;
		req.MJGOBEGONON_Type = 0;
		req.NHPCKCOPKAM_From = 0;
		req.PJFKNNNDMIA_To = 0;
		req.MOBEEPPKFLG_OnFail = (CACGCMBKHDI_Request NHECPMNKEFK) =>
		{
			//0x1A09E2C
			CJMFJOMECKI_ErrorId = NHECPMNKEFK.CJMFJOMECKI_ErrorId;
			if (NHECPMNKEFK.CJMFJOMECKI_ErrorId == SakashoErrorId.RANKING_DROPPED_PLAYER)
			{
				LPPCNCMEDFA = 0;
				IPNEJCOFBIB = 0;
				OPJANCPEKAB_OnDroppedPlayerError();
			}
			else
			{
				LPPCNCMEDFA = 0;
				IPNEJCOFBIB = 0;
				if(JGJFFKPFMDB.BDGBCCGLLAJ_IsRankingError(NHECPMNKEFK.CJMFJOMECKI_ErrorId))
				{
					IDAEHNGOKAE_OnRankingError();
				}
				else
				{
					BFKEGJMPELF_OnError();
				}
			}
		};
		req.BHFHGFKBOHH_OnSuccess = (CACGCMBKHDI_Request NHECPMNKEFK) =>
		{
			//0x1A09FE4
			OKPEFAPPFDH_GetRanksAroundSelf r = NHECPMNKEFK as OKPEFAPPFDH_GetRanksAroundSelf;
			if(r.NFEAMMJIMPG.EJDEDOJFOOK.Count == 0)
			{
				LPPCNCMEDFA = 0;
				IPNEJCOFBIB = 0;
				IDAEHNGOKAE_OnRankingError();
			}
			else
			{
				IPNEJCOFBIB = r.NFEAMMJIMPG.EJDEDOJFOOK[0].KNIFCANOHOC_Score;
				LPPCNCMEDFA = r.NFEAMMJIMPG.EJDEDOJFOOK[0].FJOLNJLLJEJ_Rank;
				KLMFJJCNBIP_OnSuccess();
			}
		};
	}
}
