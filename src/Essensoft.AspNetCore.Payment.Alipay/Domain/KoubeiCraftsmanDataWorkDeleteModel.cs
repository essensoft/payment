﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCraftsmanDataWorkDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCraftsmanDataWorkDeleteModel : AlipayObject
    {
        /// <summary>
        /// 服务商、服务商员工、商户、商户员工等口碑角色操作时必填，对应为 koubei.member.data.oauth.query 中的 auth_code，默认有效期24小时；ISV自身角色操作的时候，无需传该参数
        /// </summary>
        [JsonProperty("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 口碑手艺人id。是创建手艺人接口koubei.craftsman.data.provider.create返回的craftsman_id，或通过查询手艺人信息接口koubei.craftsman.data.provider查询craftsman_id
        /// </summary>
        [JsonProperty("craftsman_id")]
        public string CraftsmanId { get; set; }

        /// <summary>
        /// 口碑手艺人作品id列表，通过查询手艺人作品信息接口   koubei.craftsman.data.work.batchquery 获取 work_id,使用Json数组方式传值
        /// </summary>
        [JsonProperty("work_ids")]
        public List<string> WorkIds { get; set; }
    }
}
