﻿using System.Collections.Generic;
using Essensoft.Paylink.WeChatPay.V2.Response;

namespace Essensoft.Paylink.WeChatPay.V2.Request
{
    /// <summary>
    /// 企业支付 - 查询红包记录 (普通商户)
    /// </summary>
    public class WeChatPayQueryWorkWxRedPackRequest : IWeChatPayCertRequest<WeChatPayQueryWorkWxRedPackResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string MchBillNo { get; set; }

        #region IWeChatPayCertRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/mmpaymkttransfers/queryworkwxredpack";

        public string GetRequestUrl()
        {
            return requestUrl;
        }

        public void SetRequestUrl(string url)
        {
            requestUrl = url;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "mch_billno", MchBillNo },
            };
            return parameters;
        }

        public void PrimaryHandler(WeChatPayDictionary sortedTxtParams, WeChatPaySignType signType, WeChatPayOptions options)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.APIKey, signType));
        }

        #endregion
    }
}
