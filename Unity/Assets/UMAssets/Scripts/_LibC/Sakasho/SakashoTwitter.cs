using XeSys;

namespace ExternLib
{
	public static partial class LibSakasho
	{
		public static int SakashoTwitterGetTwitterLinkageStatus(int callbackId, string json)
		{
			EDOHBJAPLPF_JsonData res = GetBaseMessage();
			res["twitter_linkage"] = false;
			SendMessage(callbackId, res);
			return 0;
		}
	}
}
