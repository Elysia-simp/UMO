
using System.Collections;
using System.Collections.Generic;

public class IKIIAFKHDFP
{
	private enum APMNNDGAGCD
	{
		LAIEABIEBED = 0,
		DPFCOLKJMAH = 1,
		FELILKPMLNO = 2,
		JONPKLHMOBL = 3,
	}

	private const int MBIMMJDDOFM = 14;
	private const int EBPPBLJEKGO = 7;
	private const int OFHCCJMMPHN = 4;
	private const int DJBMOPHFJOI = 28;
	public bool PLOOEECNHFB_Done; // 0x8
	private long CDEDDEECBBF_LastRequestTime; // 0x18

	public List<EPLAAEHPCDM> FMAMKPJMFHJ { get; private set; } // 0xC PFENJOKJKLO EJAEHOAJPJL HGBEMHGJEFJ
	public List<GMHKBJLIILI> GAOEDFGMHFD { get; private set; } // 0x10 EDFBPEPJMGL PIOPNDADBPF MIGJCHCPNHL

	//// RVA: 0x8E47D4 Offset: 0x8E47D4 VA: 0x8E47D4
	//public EPLAAEHPCDM BPNKOBFHOFI(int PPFNGGCBJKC) { }

	//// RVA: 0x8E48E4 Offset: 0x8E48E4 VA: 0x8E48E4
	//private void NFHGIBLJMNH(IKIIAFKHDFP.APMNNDGAGCD PPFNGGCBJKC, string JEHFDJPOEFF) { }

	//// RVA: 0x8E48E8 Offset: 0x8E48E8 VA: 0x8E48E8
	public void HBOKJNECOPA_GetMaster(IMCBBOAFION MKECMMAJBBH, IMCBBOAFION NDLCLMAFABH, DJBHIFLHJLK MOBEEPPKFLG, bool DDGFCOPPBBN)
	{
		FMAMKPJMFHJ = null;
		GAOEDFGMHFD = null;
		long time = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.FJDBNGEPKHL.KMEFBNBFJHI_GetServerTime();
		CDEDDEECBBF_LastRequestTime = time;
		N.a.StartCoroutineWatched(GILKBAKOKLH_Coroutine_01_GetMaster(MKECMMAJBBH, NDLCLMAFABH, MOBEEPPKFLG));
	}

	//[IteratorStateMachineAttribute] // RVA: 0x6B7218 Offset: 0x6B7218 VA: 0x6B7218
	//// RVA: 0x8E4A44 Offset: 0x8E4A44 VA: 0x8E4A44
	private IEnumerator GILKBAKOKLH_Coroutine_01_GetMaster(IMCBBOAFION MKECMMAJBBH, IMCBBOAFION NDLCLMAFABH, DJBHIFLHJLK MOBEEPPKFLG)
	{
		PJKLMCGEJMK OKDOIAEGADK_Server;
		IDLAIOHLFDI_GetLoginBonuses DLOIHKKKNBB;

		//0x8E68D8
		OKDOIAEGADK_Server = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester;
		DLOIHKKKNBB = OKDOIAEGADK_Server.IFFNCAFNEAG_AddRequest(new IDLAIOHLFDI_GetLoginBonuses());
		yield return DLOIHKKKNBB.GDPDELLNOBO_WaitDone(N.a);
		if(DLOIHKKKNBB.NPNNPNAIONN_IsError)
		{
			MOBEEPPKFLG();
			PLOOEECNHFB_Done = true;
		}
		else
		{
			List<int> l = new List<int>(DLOIHKKKNBB.NFEAMMJIMPG.CEBOHGGJBMN.Count);
			for(int i = 0; i < DLOIHKKKNBB.NFEAMMJIMPG.CEBOHGGJBMN.Count; i++)
			{
				MKCJNKIEADB d = DLOIHKKKNBB.NFEAMMJIMPG.CEBOHGGJBMN[i];
				if(d.ILOKENBBBAE(CDEDDEECBBF_LastRequestTime))
				{
					l.Add(d.PPFNGGCBJKC);
				}
			}
			long time = OKDOIAEGADK_Server.FJDBNGEPKHL.KMEFBNBFJHI_GetServerTime();
			OKDOIAEGADK_Server.LOMEEJGIAHO.JOJFKIIHMOJ(time);
			if(l.Count == 0)
			{
				NDLCLMAFABH();
				PLOOEECNHFB_Done = true;
			}
			else
			{
				yield return N.a.StartCoroutineWatched(GNECDBAHDBP_GetStatus(l, MKECMMAJBBH, NDLCLMAFABH, MOBEEPPKFLG));
			}
		}
	}

	//[IteratorStateMachineAttribute] // RVA: 0x6B7290 Offset: 0x6B7290 VA: 0x6B7290
	//// RVA: 0x8E4B3C Offset: 0x8E4B3C VA: 0x8E4B3C
	private IEnumerator GNECDBAHDBP_GetStatus(List<int> EAFEGCPEKDC, IMCBBOAFION MKECMMAJBBH, IMCBBOAFION NDLCLMAFABH, DJBHIFLHJLK MOBEEPPKFLG)
	{
		TodoLogger.LogError(0, "GNECDBAHDBP_GetStatus");
		yield return null;
		MKECMMAJBBH();
	}

	//[IteratorStateMachineAttribute] // RVA: 0x6B7308 Offset: 0x6B7308 VA: 0x6B7308
	//// RVA: 0x8E4C50 Offset: 0x8E4C50 VA: 0x8E4C50
	//private IEnumerator PBAHIIPCGKO_GetDetail(List<int> EAFEGCPEKDC, List<KJKDAGGGJCO> LJMDGBEDJCI, IMCBBOAFION MKECMMAJBBH, IMCBBOAFION NDLCLMAFABH, DJBHIFLHJLK MOBEEPPKFLG) { }

	//[IteratorStateMachineAttribute] // RVA: 0x6B7380 Offset: 0x6B7380 VA: 0x6B7380
	//// RVA: 0x8E4D80 Offset: 0x8E4D80 VA: 0x8E4D80
	//private IEnumerator EBKAAOEFIDI_Increment(List<int> EAFEGCPEKDC, IMCBBOAFION MKECMMAJBBH, IMCBBOAFION NDLCLMAFABH, DJBHIFLHJLK MOBEEPPKFLG) { }

	//// RVA: 0x8E4E98 Offset: 0x8E4E98 VA: 0x8E4E98
	//private void FBKCFKPLMAL() { }

	//// RVA: 0x8E59B0 Offset: 0x8E59B0 VA: 0x8E59B0
	//private void CLOEPIEINPM() { }

	//// RVA: 0x8E5ED0 Offset: 0x8E5ED0 VA: 0x8E5ED0
	//private void FBHGHFANDEJ() { }
}