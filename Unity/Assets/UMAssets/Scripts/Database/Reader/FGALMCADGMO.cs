using FlatBuffers;
using System.Collections.Generic;

public class MEEJPBEAKKP
{
	public int PPFNGGCBJKC { get; set; } // 0x8 FDGEMCPHJCB DEMEPMAEJOO HIGKAIDMOKN
	public int IJEKNCDIIAE { get; set; } // 0xC FAHNCMHNFCG KJIMMIBDCIL DMEGNOKIKCD
	public int PLALNIIBLOF { get; set; } // 0x10 DFMNDOMAPAB JPCJNLHHIPE JJFJNEJLBDG
	public int PDBPFJJCADD { get; set; } // 0x14 PMJMBGBCIGO FOACOMBHPAC NBACOBCOJCA
	public int EGBOHDFBAPB { get; set; } // 0x18 DDNBDNJHAIB MGOEKKJNOLF NHPFDCAFAFF
	public int KMENGHEAIOC { get; set; } // 0x1C MLHHJIIPDPC CFEGFAIJACF CPFBBHLFALE
	public int JDANEOJCLBB { get; set; } // 0x20 CIIPLOPOPBO ONCHMOLCBDG MNKBPDNCPMM
	public int CPGFOBNKKBF { get; set; } // 0x24 CIAEKFDKLJB AMNKHCIJHJD INJMDACNFOL
	public int GBJFNGCDKPM { get; set; } // 0x28 GHLFADHILNN CEJJMKODOGK HOHCEBMMACI
	public int JBGEEPFKIGG { get; set; } // 0x2C AHPLCJAKAOP OLOCMINKGON ABAFHIBFKCE
}
public class FGALMCADGMO
{
	public MEEJPBEAKKP[] BHOHDFAFCNL { get; set; } // 0x8 EFDGJLHLLHB BKOCPNEOBKB HHGNFHJJMKL
	public static FGALMCADGMO HEGEKFMJNCC(byte[] NIODCJLINJN)// 0x14E6D70
	{
		ByteBuffer buffer = new ByteBuffer(NIODCJLINJN);
		FKNGHMMLIJF res_readData = FKNGHMMLIJF.GetRootAsFKNGHMMLIJF(buffer);
		FGALMCADGMO res_data = new FGALMCADGMO();

		List<MEEJPBEAKKP> BHOHDFAFCNL_list = new List<MEEJPBEAKKP>();
		for(int BHOHDFAFCNL_idx = 0; BHOHDFAFCNL_idx < res_readData.EOEALHJBOGCLength; BHOHDFAFCNL_idx++)
		{
			HJHAEAPNEMD BHOHDFAFCNL_readData = res_readData.GetEOEALHJBOGC(BHOHDFAFCNL_idx);
			MEEJPBEAKKP BHOHDFAFCNL_data = new MEEJPBEAKKP();

			BHOHDFAFCNL_data.PPFNGGCBJKC = BHOHDFAFCNL_readData.BBPHAPFBFHK;
			BHOHDFAFCNL_data.IJEKNCDIIAE = BHOHDFAFCNL_readData.OFMGALJGDAO;
			BHOHDFAFCNL_data.PLALNIIBLOF = BHOHDFAFCNL_readData.CFLMCGOJJJD;
			BHOHDFAFCNL_data.PDBPFJJCADD = BHOHDFAFCNL_readData.NJLJEKDBPCH;
			BHOHDFAFCNL_data.EGBOHDFBAPB = BHOHDFAFCNL_readData.IPHMJNCEPIJ;
			BHOHDFAFCNL_data.KMENGHEAIOC = BHOHDFAFCNL_readData.JFJCBFNEOAB;
			BHOHDFAFCNL_data.JDANEOJCLBB = BHOHDFAFCNL_readData.GPLJLPKJPAM;
			BHOHDFAFCNL_data.CPGFOBNKKBF = BHOHDFAFCNL_readData.DKMLEDJJFOI;
			BHOHDFAFCNL_data.GBJFNGCDKPM = BHOHDFAFCNL_readData.LPJPOOHJKAE;
			BHOHDFAFCNL_data.JBGEEPFKIGG = BHOHDFAFCNL_readData.KJFEBMBHKOC;
			BHOHDFAFCNL_list.Add(BHOHDFAFCNL_data);
		}
		res_data.BHOHDFAFCNL = BHOHDFAFCNL_list.ToArray();

		return res_data;
	}
}