using UnityEngine;

public class IHKOJFIFPKB : CACGCMBKHDI_Request
{
    public class HBFOPNJHBCK
    {
        public int PNAAOBECMPA; // 0x8
    }
    
	public string ELBFGEBOPLI; // 0x7C

	public IHKOJFIFPKB.HBFOPNJHBCK NFEAMMJIMPG { get; private set; } // 0x80 OHEIOONIIKB LFOJDJCNOHB KMKEGMGKCBA

	// RVA: 0x12028C4 Offset: 0x12028C4 VA: 0x12028C4 Slot: 12
	public override void DHLDNIEELHO()
    {
        EBGACDGNCAA = SakashoInquiry.GetInquiryResponsesNumber(ELBFGEBOPLI, this.DCKLDDCAJAP, this.MEOCKCJBDAD);
    }

	// RVA: 0x12029A8 Offset: 0x12029A8 VA: 0x12029A8 Slot: 13
	public override void MGFNKDPHFGI(MonoBehaviour DANMJLOBLIE)
    {
        EDOHBJAPLPF_JsonData json = IKPIMINCOPI_JsonMapper.PFAMKCGJKKL_ToObject(NGCAIEGPLKD_result);
        NFEAMMJIMPG = new IHKOJFIFPKB.HBFOPNJHBCK();
        NFEAMMJIMPG.PNAAOBECMPA = (int)json[AFEHLCGHAEE.PNAAOBECMPA/*num_replies*/];
    }
}