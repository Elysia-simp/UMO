
public class GCAHJLOGMCI
{
	public enum KNMMOMEHDON
	{
		HJNNKCMLGFL = 0,
		CCAPCGPIIPF = 1,
		PHABJLGFJNI = 2,
		GENEIBGNMPH = 3,
		JGDEHOGIENP = 4,
		GKDFKDLFNAJ = 5,
		BKNHBNINDOC = 6,
		ANFKBNLLJFN = 7,
		BCBJMKDAAKA = 8,
		OOABDNHIEFK = 9,
		DLOPEFGOAPD = 10,
		AEFCOHJBLPO = 11,
	}

	public enum NFCAJPIJFAM
	{
		HJNNKCMLGFL = 0,
		AIMPCCIHKAJ = 1,
		DIHBOGEPHFI = 2,
		ODDGKAKAGLE = 3,
		AKHEAGMMIAM = 4,
		GOAHICNDICO = 5,
		LMHDFEKIDKG = 6,
		OBLEFFEJGIJ = 8,
		NGAHKKOBGPA = 9,
		BPPLDIBMPKH = 10,
		AEFCOHJBLPO = 11,
	}

	private const int KBAHKEAEDEJ = 1000000;
	private const int HHOIIDMKCIG = 10;

	//// RVA: 0x16A9698 Offset: 0x16A9698 VA: 0x16A9698
	//public static GCAHJLOGMCI.KNMMOMEHDON OLMFIANJBOB(int KAPMOPMDHJE) { }

	//// RVA: 0x16A96CC Offset: 0x16A96CC VA: 0x16A96CC
	//public static int GPAJHMLOPNP(int KAPMOPMDHJE) { }

	//// RVA: 0x16A9704 Offset: 0x16A9704 VA: 0x16A9704
	//public static int AIAOCEGMOJP(int KAPMOPMDHJE) { }

	//// RVA: 0x16A971C Offset: 0x16A971C VA: 0x16A971C
	public static int BDJDDKBCHKO(int KAPMOPMDHJE)
	{
		return (KAPMOPMDHJE / 10) % 10;
	}

	//// RVA: 0x16A9748 Offset: 0x16A9748 VA: 0x16A9748
	public static GCAHJLOGMCI.NFCAJPIJFAM HHFLDFFJICJ(int KAPMOPMDHJE)
	{
		return (GCAHJLOGMCI.NFCAJPIJFAM)(KAPMOPMDHJE % 10);
	}

	//// RVA: 0x16A9768 Offset: 0x16A9768 VA: 0x16A9768
	public static long PMBGPACNPIN(KNMMOMEHDON INDDJNMPONH, string OPFGFINHFCE, long KJBGCLPMLCG, long NMPMNPLGIEL = 0)
	{
		if(INDDJNMPONH != KNMMOMEHDON.CCAPCGPIIPF/*1*/ && INDDJNMPONH != KNMMOMEHDON.ANFKBNLLJFN/*7*/)
		{
			if(INDDJNMPONH == KNMMOMEHDON.GENEIBGNMPH)
			{
				if(OPFGFINHFCE.Contains(JpStringLiterals.StringLiteral_10431))
				{
					NMPMNPLGIEL = 0;
					TodoLogger.Log(TodoLogger.ToCheck, "PMBGPACNPIN values");
					return NMPMNPLGIEL | KJBGCLPMLCG | (0xff0000 << 32);
				}
			}
			if(NMPMNPLGIEL != 0)
			{
				TodoLogger.Log(TodoLogger.ToCheck, "PMBGPACNPIN values");
				return NMPMNPLGIEL | KJBGCLPMLCG;
			}
			long val = 0;
			if(IMMAOANGPNK.HHCJCDFCLOB.NKEBMCIMJND_Database.GDEKCOOBLMA_System.IOIDJALFFJA_GachaSortPriority.TryGetValue((int)INDDJNMPONH, out val))
			{
				TodoLogger.Log(TodoLogger.ToCheck, "PMBGPACNPIN values");
				return val | KJBGCLPMLCG;
			}
		}
		NMPMNPLGIEL = 0;
		TodoLogger.Log(TodoLogger.ToCheck, "PMBGPACNPIN values");
		return NMPMNPLGIEL | KJBGCLPMLCG;
	}
}
