﻿using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Security;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// JS调起支付API
    /// 最新更新时间：2020.05.26
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter3_8.shtml
    /// </summary>
    public class WeChatPayV3JsApiSdkRequest : IWeChatPayV3SdkRequest
    {
        /// <summary>
        /// 订单详情扩展字符串
        /// </summary>
        public string Package { get; set; }

        #region IWeChatPayV3SdkRequest Members

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "package", Package }
            };
            return parameters;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPayDictionary sortedTxtParams)
        {
            if (!string.IsNullOrEmpty(options.SubAppId))
            {
                sortedTxtParams.Add(WeChatPayConsts.appId, options.SubAppId);
            }
            else
            {
                sortedTxtParams.Add(WeChatPayConsts.appId, options.AppId);
            }

            sortedTxtParams.Add(WeChatPayConsts.timeStamp, WeChatPayUtility.GetTimeStamp());
            sortedTxtParams.Add(WeChatPayConsts.nonceStr, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.signType, WeChatPayConsts.RSA);

            var signatureSourceData = BuildSignatureSourceData(sortedTxtParams);
            sortedTxtParams.Add(WeChatPayConsts.paySign, options.CertificateRSAPrivateKey.Sign(signatureSourceData));
        }

        private static string BuildSignatureSourceData(WeChatPayDictionary sortedTxtParams)
        {
            return $"{sortedTxtParams.GetValue(WeChatPayConsts.appId)}\n{sortedTxtParams.GetValue(WeChatPayConsts.timeStamp)}\n{sortedTxtParams.GetValue(WeChatPayConsts.nonceStr)}\n{sortedTxtParams.GetValue(WeChatPayConsts.package)}\n";
        }

        #endregion
    }
}
