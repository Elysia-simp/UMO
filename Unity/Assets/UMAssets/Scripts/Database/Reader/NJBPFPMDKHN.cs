using FlatBuffers;
using System.Collections.Generic;

public class LLFEFBAPGCH
{
	public int PPFNGGCBJKC { get; set; } // 0x8 FDGEMCPHJCB DEMEPMAEJOO HIGKAIDMOKN
	public int IJEKNCDIIAE { get; set; } // 0xC FAHNCMHNFCG KJIMMIBDCIL DMEGNOKIKCD
	public int PLALNIIBLOF { get; set; } // 0x10 DFMNDOMAPAB JPCJNLHHIPE JJFJNEJLBDG
	public int CEHGGKDLAFA { get; set; } // 0x14 JJBLENPJLEK NMDGBGFNNCJ MFJINKDMHHP
}
public class NJBPFPMDKHN
{
	public LLFEFBAPGCH[] CEEPNGEADMG { get; set; } // 0x8 CHAJIGCPNGK PFHOLDEPGAB KFFKCCNMEED
	public static NJBPFPMDKHN HEGEKFMJNCC(byte[] NIODCJLINJN)// 0x18AB410
	{
		ByteBuffer buffer = new ByteBuffer(NIODCJLINJN);
		EADNHFHCKIA res_readData = EADNHFHCKIA.GetRootAsEADNHFHCKIA(buffer);
		NJBPFPMDKHN res_data = new NJBPFPMDKHN();

		List<LLFEFBAPGCH> CEEPNGEADMG_list = new List<LLFEFBAPGCH>();
		for(int CEEPNGEADMG_idx = 0; CEEPNGEADMG_idx < res_readData.EJNIGLEDAFJLength; CEEPNGEADMG_idx++)
		{
			NGBNIMPLJEE CEEPNGEADMG_readData = res_readData.GetEJNIGLEDAFJ(CEEPNGEADMG_idx);
			LLFEFBAPGCH CEEPNGEADMG_data = new LLFEFBAPGCH();

			CEEPNGEADMG_data.PPFNGGCBJKC = CEEPNGEADMG_readData.BBPHAPFBFHK;
			CEEPNGEADMG_data.IJEKNCDIIAE = CEEPNGEADMG_readData.OFMGALJGDAO;
			CEEPNGEADMG_data.PLALNIIBLOF = CEEPNGEADMG_readData.CFLMCGOJJJD;
			CEEPNGEADMG_data.CEHGGKDLAFA = CEEPNGEADMG_readData.JCIIGMCDKAH;
			CEEPNGEADMG_list.Add(CEEPNGEADMG_data);
		}
		res_data.CEEPNGEADMG = CEEPNGEADMG_list.ToArray();

		return res_data;
	}
}
