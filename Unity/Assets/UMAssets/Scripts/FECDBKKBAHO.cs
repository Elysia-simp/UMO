using System.IO;
using System;
using System.Collections.Generic;

public class FECDBKKBAHO
{
	public class FHOPNIJCFKA_FileInfo
	{
		public long DGGFLBJBLLN; // 0x8
		public long FNALNKKMKDC_ExpireTime; // 0x10
		public int IOIMHJAOKOO; // 0x18
		public short KKPAHLMJKIH; // 0x1C
		public bool GEJJEDDEPMI; // 0x1E
		public bool GOAEFAAIOEK; // 0x1F
	}
	
	private const int MPLGOGILHHF = 10003;
	private const int KENEAGNAKAF = 24;
	private Dictionary<int, FHOPNIJCFKA_FileInfo> MLHACNBJAGM_FilesInfoByHash = new Dictionary<int, FHOPNIJCFKA_FileInfo>(); // 0x8
	private string JHJMNLMNPGO_PersistentDirSys; // 0xC
	public bool GCKONHLCMFL; // 0x10
	private int IHEPCAHBECA = -1; // 0x14
	// private Regex OOLIMFMEJGP; // 0x18
	private string KDFJMKLNOJH; // 0x1C
	private string HKHMCIEINKB; // 0x20
	private string OGCDNCDMLCA; // 0x24
	private long JHNMKKNEENE; // 0x28

	// // RVA: 0xFCF300 Offset: 0xFCF300 VA: 0xFCF300
	public void KHEKNNFCAOI_Init()
	{
		JHJMNLMNPGO_PersistentDirSys = CJMOKHDNBNB.FIPFFELDIOG_PersistentPath + KCOGAGGCPBP.HAFLEFNJAKD_DirSys;
		PCODDPDFLHK();
	}

	// // RVA: 0xFCF7E8 Offset: 0xFCF7E8 VA: 0xFCF7E8
	// public void JCHLONCMPAJ() { }

	// // RVA: 0xFCF860 Offset: 0xFCF860 VA: 0xFCF860
	public FHOPNIJCFKA_FileInfo LBDOLHGDIEB(string CJEKGLGBIHF)
	{
		if(MLHACNBJAGM_FilesInfoByHash.ContainsKey(CJEKGLGBIHF.GetHashCode()))
		{
			return MLHACNBJAGM_FilesInfoByHash[CJEKGLGBIHF.GetHashCode()];
		}
		return null;
	}

	// // RVA: 0xFCF948 Offset: 0xFCF948 VA: 0xFCF948
	public void OJCJPCHFPGO(string CJEKGLGBIHF)
	{
		TodoLogger.Log(0, "TODO");
	}

	// // RVA: 0xFCFA28 Offset: 0xFCFA28 VA: 0xFCFA28
	// public void KMHCHILJPIG() { }

	// // RVA: 0xFCFBB8 Offset: 0xFCFBB8 VA: 0xFCFBB8
	public FECDBKKBAHO.FHOPNIJCFKA_FileInfo ANIJHEBLMGB(string CJEKGLGBIHF, long DGGFLBJBLLN, int KKPAHLMJKIH)
	{
		TodoLogger.Log(0, "TODO");
		return null;
	}

	// // RVA: 0xFCF3E0 Offset: 0xFCF3E0 VA: 0xFCF3E0
	public void PCODDPDFLHK()
	{
		if(!Directory.Exists(JHJMNLMNPGO_PersistentDirSys))
		{
			Directory.CreateDirectory(JHJMNLMNPGO_PersistentDirSys);
		}
		MLHACNBJAGM_FilesInfoByHash.Clear();
		string file = JHJMNLMNPGO_PersistentDirSys + "/" + KCOGAGGCPBP.PFJKALCPNHG_File00;
		if(File.Exists(file))
		{
			byte[] data = File.ReadAllBytes(file);
			if(data != null)
			{
				int header = BitConverter.ToInt32(data, 0);
				if(header == 0x2713)
				{
					int val = BitConverter.ToInt32(data, 4);
					int offset = 8;
					for(int i = 0; i < val; i++)
					{
						FHOPNIJCFKA_FileInfo d = new FHOPNIJCFKA_FileInfo();
						d.DGGFLBJBLLN = BitConverter.ToInt64(data, offset);
						d.FNALNKKMKDC_ExpireTime = BitConverter.ToInt64(data, offset + 8);
						d.IOIMHJAOKOO = BitConverter.ToInt32(data, offset + 16);
						d.KKPAHLMJKIH = BitConverter.ToInt16(data, offset + 20);
						d.GEJJEDDEPMI = data[22] != 0;
						MLHACNBJAGM_FilesInfoByHash.Add(d.IOIMHJAOKOO, d);
						offset += 24;
					}
				}
				else
				{
					UnityEngine.Debug.LogError("Wrong signature for "+JHJMNLMNPGO_PersistentDirSys);
				}
			}
		}
	}

	// // RVA: 0xFCFEAC Offset: 0xFCFEAC VA: 0xFCFEAC
	public void HJMKBCFJOOH()
    {
        TodoLogger.Log(0, "TODO");
    }

	// // RVA: 0xFD0494 Offset: 0xFD0494 VA: 0xFD0494
	public bool JCENJHBMDIP(int KKPAHLMJKIH, long JHNMKKNEENE, long CKPIHCGOEDP)
	{
		TodoLogger.Log(0, "JCENJHBMDIP");
		return false;
	}

	// // RVA: 0xFD0724 Offset: 0xFD0724 VA: 0xFD0724
	// public void IKOFAKDLDJE() { }

	// // RVA: 0xFD099C Offset: 0xFD099C VA: 0xFD099C
	// private void BNPFBOIFDAG() { }

	// // RVA: 0xFD0C1C Offset: 0xFD0C1C VA: 0xFD0C1C
	public void EBCAKALIAHH()
    {
        TodoLogger.Log(0, "TODO");
    }

	// // RVA: 0xFD09C8 Offset: 0xFD09C8 VA: 0xFD09C8
	// private void PMHECMICPGN(string CJJJPKJHOGM) { }

	// // RVA: 0xFD0D84 Offset: 0xFD0D84 VA: 0xFD0D84
	// private void PJNOMDMINDA(string CJJJPKJHOGM) { }

	// // RVA: 0xFD1000 Offset: 0xFD1000 VA: 0xFD1000
	// public void FMCLFMGBAJJ() { }
}
