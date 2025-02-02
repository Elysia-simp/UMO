using XeSys;

namespace ExternLib
{
	public static partial class LibSakasho
	{
		public static int SakashoPaymentGetRemainingForCurrencyIds(int callbackId, string json)
		{
			EDOHBJAPLPF_JsonData jsonData = IKPIMINCOPI_JsonMapper.PFAMKCGJKKL_ToObject(json);
			EDOHBJAPLPF_JsonData ids = jsonData["ids"];

			string message = "";

			EDOHBJAPLPF_JsonData arrayData = IKPIMINCOPI_JsonMapper.PFAMKCGJKKL_ToObject(@"[
				{
					""description"": ""\u30b2\u30fc\u30e0\u5185\u3067\u8cfc\u5165\u3067\u304d\u308b\u4eee\u60f3\u901a\u8ca8"",
					""free"": 0,
					""id"": 1001,
					""name"": ""\u6b4c\u6676\u77f3"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u6b4c\u6676\u77f3\u8cfc\u5165\u306e\u304a\u307e\u3051 (3/1\uff5e5/31)"",
					""free"": 0,
					""id"": 3001,
					""name"": ""\u30b9\u30d7\u30ea\u30f3\u30b0\u30b9\u30d5\u30a3\u30a2"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u6b4c\u6676\u77f3\u8cfc\u5165\u306e\u304a\u307e\u3051 (6/1\uff5e8/31)"",
					""free"": 0,
					""id"": 3002,
					""name"": ""\u30b5\u30de\u30fc\u30b9\u30d5\u30a3\u30a2"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u6b4c\u6676\u77f3\u8cfc\u5165\u306e\u304a\u307e\u3051 (9/1\uff5e11/30)"",
					""free"": 0,
					""id"": 3003,
					""name"": ""\u30aa\u30fc\u30bf\u30e0\u30b9\u30d5\u30a3\u30a2"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u6b4c\u6676\u77f3\u8cfc\u5165\u306e\u304a\u307e\u3051 (12/1\uff5e2/28)"",
					""free"": 0,
					""id"": 3004,
					""name"": ""\u30a6\u30a3\u30f3\u30bf\u30fc\u30b9\u30d5\u30a3\u30a2"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u5a18\u304f\u3058\u2606\u62bd\u9078\u7528"",
					""free"": 0,
					""id"": 4001,
					""name"": ""\u5a18\u304f\u3058\u2606\u62bd\u9078\u5238"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u26055\u78ba\u5b9a\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 2002,
					""name"": ""\u26055\u78ba\u5b9a\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8A"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u26055\u78ba\u5b9a\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 2003,
					""name"": ""\u26055\u78ba\u5b9a\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8B"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u26055\u78ba\u5b9a\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 2004,
					""name"": ""\u26055\u78ba\u5b9a\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8C"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u5a18\u304f\u3058\u2606\u62bd\u9078\u7528"",
					""free"": 0,
					""id"": 4002,
					""name"": ""\u5a18\u304f\u3058\u2606\u62bd\u9078\u5238B"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u304a\u5e74\u7389\u7528\u901a\u8ca8"",
					""free"": 0,
					""id"": 5001,
					""name"": ""\u304a\u5e74\u7389"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 2101,
					""name"": ""\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u30ed\u30b0\u30dc\u7528\u306e\u26055\u78ba\u5b9a\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 2008,
					""name"": ""\u26055\u78ba\u5b9a\u30ed\u30b0\u30dc\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8\u30005\u6708"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u30ed\u30b0\u30dc\u7528\u306e\u26055\u78ba\u5b9a\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 2009,
					""name"": ""\u26055\u78ba\u5b9a\u30ed\u30b0\u30dc\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8\u30006\u6708"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u30ed\u30b0\u30dc\u7528\u306e\u26055\u78ba\u5b9a\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 2010,
					""name"": ""\u26055\u78ba\u5b9a\u30ed\u30b0\u30dc\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8\u30007\u6708"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u5a18\u304f\u3058\u2606\u62bd\u9078\u7528"",
					""free"": 0,
					""id"": 4003,
					""name"": ""\u5a18\u304f\u3058\u2606\u62bd\u9078\u5238C"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u30b5\u30de\u30fc\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 5002,
					""name"": ""\u30b5\u30de\u30fc\u30c1\u30b1\u30c3\u30c8"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u5a18\u30af\u30b8\u2606\u62bd\u9078\u7528"",
					""free"": 0,
					""id"": 4004,
					""name"": ""\u5a18\u304f\u3058\u2606\u62bd\u9078\u5238D"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u8863\u88c5\u89e3\u653e\u30d7\u30ec\u30fc\u30c8\u4ea4\u63db\u5238"",
					""free"": 0,
					""id"": 3005,
					""name"": ""\u8863\u88c5\u89e3\u653e\u30d7\u30ec\u30fc\u30c8\u4ea4\u63db\u5238"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u53ce\u96c6\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 2201,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u53ce\u96c6A)"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u53ce\u96c6\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 2202,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u53ce\u96c6B)"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u53ce\u96c6\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 2203,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u53ce\u96c6C)"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u30df\u30c3\u30b7\u30e7\u30f3\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 2204,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u30df\u30c3\u30b7\u30e7\u30f3A)"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u30df\u30c3\u30b7\u30e7\u30f3\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 2205,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u30df\u30c3\u30b7\u30e7\u30f3B)"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u30df\u30c3\u30b7\u30e7\u30f3\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 2206,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u30df\u30c3\u30b7\u30e7\u30f3C)"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u30d0\u30c8\u30eb\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 2207,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u6b4c\u59eb-\u30d0\u30c8\u30ebA)"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u30d0\u30c8\u30eb\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 2208,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u6b4c\u59eb-\u30d0\u30c8\u30ebB)"",
					""paid"": 0,
					""total"": 0

				},
				{
					""description"": ""\u30d0\u30c8\u30eb\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": 0,
					""id"": 2209,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u6b4c\u59eb-\u30d0\u30c8\u30ebC)"",
					""paid"": 0,
					""total"": 0

				}
			]");

			EDOHBJAPLPF_JsonData res = GetBaseMessage();
			res["balances"] = new EDOHBJAPLPF_JsonData();
			res["balances"].LAJDIPCJCPO_SetJsonType(JFBMDLGBPEN_JsonType.BDHGEFMCJDF_Array);
			for(int i = 0; i < ids.HNBFOAJIIAL_Count; i++)
			{
				int val = (int)ids[i];
				EDOHBJAPLPF_JsonData r = null;
				for(int j = 0; j < arrayData.HNBFOAJIIAL_Count; j++)
				{
					if ((int)arrayData[j]["id"] == val)
					{
						r = arrayData[j];
						break;
					}
				}
				if(r == null)
				{
					TodoLogger.LogError(0, "SakashoPaymentGetRemainingForCurrencyIds, missing id "+val);
					r = IKPIMINCOPI_JsonMapper.PFAMKCGJKKL_ToObject(@"{
					""description"": ""No desc"",
					""free"": 0,
					""id"": "+val+@",
					""name"": ""No name"",
					""paid"": 0,
					""total"": 0
				}");
				}
				res["balances"].Add(r);
			}

			SendMessage(callbackId, res);
			return 0;
		}
		
		public static int SakashoPaymentGetVirtualCurrencyBalancesWithExpiredAt(int callbackId, string json)
		{
			EDOHBJAPLPF_JsonData jsonData = IKPIMINCOPI_JsonMapper.PFAMKCGJKKL_ToObject(json);
			EDOHBJAPLPF_JsonData ids = jsonData["virtualCurrencyIds"];

			string message = "";

			EDOHBJAPLPF_JsonData arrayData = IKPIMINCOPI_JsonMapper.PFAMKCGJKKL_ToObject(@"[
				{
					""description"": ""\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": [],
					""id"": 2101,
					""name"": ""\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8"",
					""paid"": []
				},
				{
					""description"": ""\u53ce\u96c6\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": [],
					""id"": 2201,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u53ce\u96c6A)"",
					""paid"": []
				},
				{
					""description"": ""\u53ce\u96c6\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": [],
					""id"": 2202,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u53ce\u96c6B)"",
					""paid"": []
				},
				{
					""description"": ""\u53ce\u96c6\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": [],
					""id"": 2203,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u53ce\u96c6C)"",
					""paid"": []
				},
				{
					""description"": ""\u30df\u30c3\u30b7\u30e7\u30f3\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": [],
					""id"": 2204,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u30df\u30c3\u30b7\u30e7\u30f3A)"",
					""paid"": []
				},
				{
					""description"": ""\u30df\u30c3\u30b7\u30e7\u30f3\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": [],
					""id"": 2205,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u30df\u30c3\u30b7\u30e7\u30f3B)"",
					""paid"": []
				},
				{
					""description"": ""\u30df\u30c3\u30b7\u30e7\u30f3\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": [],
					""id"": 2206,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u30df\u30c3\u30b7\u30e7\u30f3C)"",
					""paid"": []
				},
				{
					""description"": ""\u30d0\u30c8\u30eb\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": [],
					""id"": 2207,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u6b4c\u59eb-\u30d0\u30c8\u30ebA)"",
					""paid"": []
				},
				{
					""description"": ""\u30d0\u30c8\u30eb\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": [],
					""id"": 2208,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u6b4c\u59eb-\u30d0\u30c8\u30ebB)"",
					""paid"": []
				},
				{
					""description"": ""\u30d0\u30c8\u30eb\u30a4\u30d9\u30f3\u30c8\u5831\u916c\u7528\u3001\u30c7\u30ab\u30eb\u30ac\u30c1\u30e3\u3092\u5f15\u304f\u305f\u3081\u306e\u30c1\u30b1\u30c3\u30c8"",
					""free"": [],
					""id"": 2209,
					""name"": ""\u30a4\u30d9\u30f3\u30c8\u30ac\u30c1\u30e3\u30c1\u30b1\u30c3\u30c8(\u6b4c\u59eb-\u30d0\u30c8\u30ebC)"",
					""paid"": []
				}
			]");

			EDOHBJAPLPF_JsonData res = GetBaseMessage();
			res["balances"] = new EDOHBJAPLPF_JsonData();
			res["balances"].LAJDIPCJCPO_SetJsonType(JFBMDLGBPEN_JsonType.BDHGEFMCJDF_Array);
			for(int i = 0; i < ids.HNBFOAJIIAL_Count; i++)
			{
				int val = (int)ids[i];
				EDOHBJAPLPF_JsonData r = null;
				for(int j = 0; j < arrayData.HNBFOAJIIAL_Count; j++)
				{
					if ((int)arrayData[j]["id"] == val)
					{
						r = arrayData[j];
						break;
					}
				}
				if(r == null)
				{
					TodoLogger.LogError(0, "SakashoPaymentGetVirtualCurrencyBalancesWithExpiredAt, missing id " + val);
					r = IKPIMINCOPI_JsonMapper.PFAMKCGJKKL_ToObject(@"{
					""description"": ""No desc"",
					""free"": [],
					""id"": "+val+@",
					""name"": ""No name"",
					""paid"": []
				}");
				}
				res["balances"].Add(r);
			}

			SendMessage(callbackId, res);
			return 0;
		}


		public static int SakashoPaymentGetProducts(int callbackId, string json)
		{
			EDOHBJAPLPF_JsonData jsonData = IKPIMINCOPI_JsonMapper.PFAMKCGJKKL_ToObject(json);
			int currencyId = -1;
			if(jsonData.BBAJPINMOEP_Contains("currencyId"))
				currencyId = (int)jsonData["currencyId"];
			int productType = -1;
			if (jsonData.BBAJPINMOEP_Contains("productType"))
				productType = (int)jsonData["productType"];
			int label = -1;
			if (jsonData.BBAJPINMOEP_Contains("label"))
				label = (int)jsonData["label"];
			string masterGroupName = null;
			if (jsonData.BBAJPINMOEP_Contains("masterGroupName"))
				masterGroupName = (string)jsonData["masterGroupName"];
			int page = (int)jsonData["page"];
			int ipp = (int)jsonData["ipp"];


			string message = "";

			EDOHBJAPLPF_JsonData arrayData = IKPIMINCOPI_JsonMapper.PFAMKCGJKKL_ToObject(@"[
				{
					""bought_quantity"": null,
					""buy_limit"": 0,
					""closed_at"": 32520895200,
					""description"": ""\u30b2\u30fc\u30e0\u4e2d\u306b\u30b3\u30f3\u30c6\u30cb\u30e5\u30fc\u3067\u304d\u307e\u3059\u3002"",
					""group_key"": null,
					""id"": 67554,
					""imageUrl"": null,
					""item_set_name_for_api"": null,
					""label"": 10,
					""name"": ""\u30b3\u30f3\u30c6\u30cb\u30e5\u30fc"",
					""opened_at"": 1497856800,
					""platform_product_id"": null,
					""price"": 10
				},
				{
					""bought_quantity"": null,
					""buy_limit"": 0,
					""closed_at"": 32520895200,
					""description"": ""\u30b9\u30bf\u30df\u30ca\u56de\u5fa9"",
					""group_key"": null,
					""id"": 67572,
					""imageUrl"": null,
					""item_set_name_for_api"": null,
					""label"": 10,
					""name"": ""\u30b9\u30bf\u30df\u30ca\u56de\u5fa9"",
					""opened_at"": 1497870000,
					""platform_product_id"": null,
					""price"": 10
				},
				{
					""bought_quantity"": null,
					""buy_limit"": 0,
					""closed_at"": 32525902800,
					""description"": ""VOP\u9ad8\u901f\u5b8c\u4e86\u306e\u5b9f\u884c\u306b\u4f7f\u7528\u3057\u307e\u3059\u3002"",
					""group_key"": null,
					""id"": 153192,
					""imageUrl"": null,
					""item_set_name_for_api"": null,
					""label"": 10,
					""name"": ""VOP\u9ad8\u901f\u5b8c\u4e86"",
					""opened_at"": 1535342400,
					""platform_product_id"": null,
					""price"": 5
				},
				{
					""bought_quantity"": null,
					""buy_limit"": 0,
					""closed_at"": 32512611600,
					""description"": ""AP\u56de\u5fa9"",
					""group_key"": null,
					""id"": 167079,
					""imageUrl"": null,
					""item_set_name_for_api"": null,
					""label"": 10,
					""name"": ""AP\u56de\u5fa9"",
					""normal_lot_free_setting"": {
						""duration_days"": null,
						""is_first_time"": false,
						""reset_count"": null,
						""reset_hours"": null
					},
					""opened_at"": 1552575600,
					""platform_product_id"": null,
					""player_normal_lot_free_state"": {
						""is_next_free"": false
					},
					""price"": 10
				},
				{
					""bought_quantity"": null,
					""buy_limit"": 0,
					""closed_at"": 32530057200,
					""description"": ""AP\u56de\u5fa9(\u5c0f)"",
					""group_key"": null,
					""id"": 222423,
					""imageUrl"": null,
					""item_set_name_for_api"": null,
					""label"": 10,
					""name"": ""AP\u56de\u5fa92"",
					""opened_at"": 1570086000,
					""platform_product_id"": null,
					""price"": 5
				},
				{
					""bought_quantity"": null,
					""buy_limit"": 0,
					""closed_at"": 32530057200,
					""description"": ""AP\u56de\u5fa9\uff08\u5927\uff09"",
					""group_key"": null,
					""id"": 222424,
					""imageUrl"": null,
					""item_set_name_for_api"": null,
					""label"": 10,
					""name"": ""AP\u56de\u5fa93"",
					""opened_at"": 1570086000,
					""platform_product_id"": null,
					""price"": 20
				}
			]");

			EDOHBJAPLPF_JsonData res = GetBaseMessage();
			res["current_page"] = page;
			res["next_page"] = 0;
			res["previous_page"] = 0;
			res["products"] = new EDOHBJAPLPF_JsonData();
			res["products"].LAJDIPCJCPO_SetJsonType(JFBMDLGBPEN_JsonType.BDHGEFMCJDF_Array);
			if(productType == 0 && currencyId == 1001 && label == 10)
			{
				for (int i = 0; i < arrayData.HNBFOAJIIAL_Count; i++)
				{
					if((int)arrayData[i]["label"] == label)
						res["products"].Add(arrayData[i]);
				}
			}
			else
			{
				TodoLogger.LogError(0, "Missing product info for "+json);
			}

			SendMessage(callbackId, res);
			return 0;
		}

		public static int SakashoPaymentRecover(int callbackId, string json)
		{
			EDOHBJAPLPF_JsonData res = GetBaseMessage();
			SendMessage(callbackId, res);
			return 0;
		}	

		public static int SakashoPaymentPurchase(int callbackId, string json)
		{
			EDOHBJAPLPF_JsonData res = GetBaseMessage();
			SendMessage(callbackId, res);
			return 0;
		}
	}
}
