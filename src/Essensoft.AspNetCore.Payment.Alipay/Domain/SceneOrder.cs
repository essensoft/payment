﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneOrder Data Structure.
    /// </summary>
    [Serializable]
    public class SceneOrder : AlipayObject
    {
        /// <summary>
        /// 买家支付宝用户ID
        /// </summary>
        [JsonProperty("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 优惠说明，以json格式字符串返回。
        /// </summary>
        [JsonProperty("discount_detail")]
        public List<MallDiscountDetail> DiscountDetail { get; set; }

        /// <summary>
        /// 商圈场景订单ID
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单类型：OFFLINE_PURCHASE：线下购买
        /// </summary>
        [JsonProperty("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 商户订单号,64个字符以内、可包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 订单实付金额
        /// </summary>
        [JsonProperty("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 业务场景码，分类：SCAN_PURCHASE（扫码购场景）
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID
        /// </summary>
        [JsonProperty("seller_user_id")]
        public string SellerUserId { get; set; }

        /// <summary>
        /// 订单状态：INIT：初始化，WAIT_PAY：待支付，PAID：已经支付，CLOSE：关闭
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易成功时间
        /// </summary>
        [JsonProperty("trade_success_time")]
        public string TradeSuccessTime { get; set; }

        /// <summary>
        /// 交易下单时间
        /// </summary>
        [JsonProperty("trade_time")]
        public string TradeTime { get; set; }
    }
}
