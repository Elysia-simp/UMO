
using System.Collections;
using System.Collections.Generic;

public class LAPFLEEAACL
{
    public enum JCHBGAEFPHA
    {
        HJNNKCMLGFL = 0,
        NCKBNMCNDLC = 1,
        EANGJBHNNHF = 2,
    }

	public bool PLOOEECNHFB_IsDone; // 0x8
	public bool NPNNPNAIONN_IsError; // 0x9
	private List<KBPDNHOKEKD_ProductId> MHKCPJDNJKI_ProductsList; // 0xC
	public JKNGJFOBADP JANMJPOKLFL = new JKNGJFOBADP(); // 0x10
	public int PPECNOCKNMC_FullItemId; // 0x14
	private HHJHIFJIKAC_BonusVc.IJFKAIHFJLF AIBKGHFBFCC = /*2*/HHJHIFJIKAC_BonusVc.IJFKAIHFJLF.JEPMLKCJCPK; // 0x18

	// // RVA: 0xD945C4 Offset: 0xD945C4 VA: 0xD945C4
	public LAPFLEEAACL(HHJHIFJIKAC_BonusVc.IJFKAIHFJLF INDDJNMPONH)
    {
        AIBKGHFBFCC = INDDJNMPONH;
    }

	// // RVA: 0xD94650 Offset: 0xD94650 VA: 0xD94650
	public void OFKONDFPMLJ_GetProduct()
    {
		MHKCPJDNJKI_ProductsList = null;
		PPECNOCKNMC_FullItemId = 0;
		PLOOEECNHFB_IsDone = false;
		NPNNPNAIONN_IsError = false;
		long time = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.FJDBNGEPKHL.KMEFBNBFJHI_GetServerTime();
		HHJHIFJIKAC_BonusVc.MNGJPJBCMBH item = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.NBKNAAPBFFL_BonusVc.EKENMIDOHPL_GetActiveBonus(time, AIBKGHFBFCC);
		if(item == null)
		{
			PLOOEECNHFB_IsDone = true;
			return;
		}
		NEAPMMJKOKA_GetProducts req = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.IFFNCAFNEAG_AddRequest(new NEAPMMJKOKA_GetProducts());
		req.IPKCADIAAPG_Criteria = LCKOLEDFDAL.BAKNLGCIHAN(item.CPGFOBNKKBF);
		req.BHFHGFKBOHH_OnSuccess = (CACGCMBKHDI_Request JIPCHHHLOMM) =>
		{
			//0xD950AC
			MHKCPJDNJKI_ProductsList = req.NFEAMMJIMPG.MHKCPJDNJKI_Products;
			MHKCPJDNJKI_ProductsList.Sort((KBPDNHOKEKD_ProductId HKICMNAACDA, KBPDNHOKEKD_ProductId BNKHBCBJBKI) =>
			{
				//0xD95038
				return HKICMNAACDA.NPPGKNGIFGK_Price.CompareTo(BNKHBCBJBKI.NPPGKNGIFGK_Price);
			});
			PLOOEECNHFB_IsDone = true;
			NPNNPNAIONN_IsError = false;
			PPECNOCKNMC_FullItemId = EKLNMHFCAOI.GJEEGMCBGGM_GetItemFullId(EKLNMHFCAOI.FKGCBLHOOCL_Category.IBBDMIFICCN_BonusVC, item.PPFNGGCBJKC_Id);
		};
		req.MOBEEPPKFLG_OnFail = (CACGCMBKHDI_Request JIPCHHHLOMM) =>
		{
			//0xD95310
			PLOOEECNHFB_IsDone = true;
			NPNNPNAIONN_IsError = true;
		};
	}

	// // RVA: 0xD94AA0 Offset: 0xD94AA0 VA: 0xD94AA0
	public void LAOEGNLOJHC_Convert()
	{
		PLOOEECNHFB_IsDone = false;
		NPNNPNAIONN_IsError = false;
		long time = NKGJPJPHLIF.HHCJCDFCLOB.IBLPICFDGOF_ServerRequester.FJDBNGEPKHL.KMEFBNBFJHI_GetServerTime();
		HHJHIFJIKAC_BonusVc.MNGJPJBCMBH item = IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.NBKNAAPBFFL_BonusVc.EKENMIDOHPL_GetActiveBonus(time, AIBKGHFBFCC);
		if (item == null)
		{
			PLOOEECNHFB_IsDone = true;
			return;
		}
		if(CIOECGOMILE.HHCJCDFCLOB.NOJDLFKKMDD(item.PPFNGGCBJKC_Id) < 1 || MHKCPJDNJKI_ProductsList.Count == 0)
		{
			PLOOEECNHFB_IsDone = true;
			return;
		}
		if(AIBKGHFBFCC < HHJHIFJIKAC_BonusVc.IJFKAIHFJLF.MDIJEKDNLFC || AIBKGHFBFCC >= HHJHIFJIKAC_BonusVc.IJFKAIHFJLF.PPPGDKCDACF)
		{
			if(AIBKGHFBFCC == HHJHIFJIKAC_BonusVc.IJFKAIHFJLF.KJBGPOMJFBE_MonthlyPass)
			{
				N.a.StartCoroutineWatched(CAIJJOKCOAB_ConvertMonthlyPass(item.PPFNGGCBJKC_Id));
				return;
			}
			if (AIBKGHFBFCC != HHJHIFJIKAC_BonusVc.IJFKAIHFJLF.JEPMLKCJCPK)
				return;
		}
		N.a.StartCoroutineWatched(BJGOKLICIDO_Coroutine_Convert(item.PPFNGGCBJKC_Id));
	}

	// [IteratorStateMachineAttribute] // RVA: 0x6B8E60 Offset: 0x6B8E60 VA: 0x6B8E60
	// // RVA: 0xD94D64 Offset: 0xD94D64 VA: 0xD94D64
	private IEnumerator BJGOKLICIDO_Coroutine_Convert(int LGMBMMMAFKK)
	{
		TodoLogger.LogError(0, "BJGOKLICIDO_Coroutine_Convert");
		yield return null;
		PLOOEECNHFB_IsDone = true;
	}

	// [IteratorStateMachineAttribute] // RVA: 0x6B8ED8 Offset: 0x6B8ED8 VA: 0x6B8ED8
	// // RVA: 0xD94E0C Offset: 0xD94E0C VA: 0xD94E0C
	private IEnumerator CAIJJOKCOAB_ConvertMonthlyPass(int LGMBMMMAFKK)
	{
		TodoLogger.LogError(0, "CAIJJOKCOAB_ConvertMonthlyPass");
		yield return null;
		PLOOEECNHFB_IsDone = true;
	}

	// // RVA: 0xD94EF4 Offset: 0xD94EF4 VA: 0xD94EF4
	// public bool ELMHHMHLFJG(GJDFHLBONOL AIMLPJOGPID) { }

	// [CompilerGeneratedAttribute] // RVA: 0x6B8F50 Offset: 0x6B8F50 VA: 0x6B8F50
	// // RVA: 0xD94FA4 Offset: 0xD94FA4 VA: 0xD94FA4
	// private void <Coroutine_Convert>b__10_0() { }

	// [CompilerGeneratedAttribute] // RVA: 0x6B8F60 Offset: 0x6B8F60 VA: 0x6B8F60
	// // RVA: 0xD94FB0 Offset: 0xD94FB0 VA: 0xD94FB0
	// private void <Coroutine_Convert>b__10_1() { }
}
