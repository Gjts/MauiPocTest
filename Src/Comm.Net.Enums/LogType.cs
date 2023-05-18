/*
 *┌──────────────────────────────────────────┐
 *│  描    述：                                   
 *│  创 建 人：HardieBao
 *│  创建时间：16/5/2023 9:54:52
 *│  修 改 人：
 *│  修改时间： 
 *│　版    本：1.0                                                                     
 *└──────────────────────────────────────────┘
*/
using System.ComponentModel;

namespace Comm.Net.Enums
{
    public enum LogType
    {
        [Description("网站")]
        Web,
        [Description("Api接口")]
        ApiRequest
    }
}
