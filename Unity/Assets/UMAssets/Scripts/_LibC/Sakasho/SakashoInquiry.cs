using XeSys;

namespace ExternLib
{
    public static partial class LibSakasho
    {
        public static int SakashoInquiryGetInquiryResponsesNumber(int callbackId, string json)
        {
            UnityEngine.Debug.Log("SakashoInquiryGetInquiryResponsesNumber "+json);
            // Hack directly send response
            string message =
@"{
    ""SAKASHO_CURRENT_ASSET_REVISION"": ""20220602120304"",
    ""SAKASHO_CURRENT_DATE_TIME"": "+Utility.GetCurrentUnixTime()+@",
    ""SAKASHO_CURRENT_MASTER_REVISION"": 5,
    ""num_replies"": 0
}";
            UnityEngine.GameObject.Find(UnityCallbackObject).SendMessage("NotifyOnSuccess", ""+callbackId+":"+message);
            // end hack

            return 0;
        }
    }
}