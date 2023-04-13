using System.Collections.Generic;
using XeSys;

namespace ExternLib
{
	public static partial class LibSakasho
	{
		public static int SakashoRegularRankingGetRegularRankingTopRanks(int callbackId, string json)
		{
			EDOHBJAPLPF_JsonData jsonData = IKPIMINCOPI_JsonMapper.PFAMKCGJKKL_ToObject(json);
			int page = (int)jsonData["page"];
			int ipp = (int)jsonData["ipp"];

			EDOHBJAPLPF_JsonData res = GetBaseMessage();
			res["previous_page"] = 0;
			res["next_page"] = 0;
			res["current_page"] = page;
			res["regular_ranking_ranks"] = new EDOHBJAPLPF_JsonData();
			res["regular_ranking_ranks"].LAJDIPCJCPO_SetJsonType(JFBMDLGBPEN_JsonType.BDHGEFMCJDF_Array);
			SendMessage(callbackId, res);
			return 0;
		}
	}
}
