﻿using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignUserAssetQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignUserAssetQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 券资产详情信息
        /// </summary>
        [JsonProperty("voucher_asset_list")]
        public List<VoucherDetailInfo> VoucherAssetList { get; set; }

        /// <summary>
        /// 券资产数量
        /// </summary>
        [JsonProperty("voucher_asset_num")]
        public long VoucherAssetNum { get; set; }
    }
}
