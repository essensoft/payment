﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosCategoryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCategoryCreateModel : AlipayObject
    {
        /// <summary>
        /// 菜类名称
        /// </summary>
        [JsonProperty("cate_name")]
        public string CateName { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
