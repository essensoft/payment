﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeContractUserstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeContractUserstatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 我承诺消费活动名字
        /// </summary>
        [JsonProperty("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 场景类目
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// 用户支付宝ID
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }
    }
}
