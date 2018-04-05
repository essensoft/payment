﻿using Newtonsoft.Json;
using System;
using System.Collections;

namespace Essensoft.AspNetCore.Payment.Alipay.Parser
{
    public class AlipayDictionaryParser<T> where T : AlipayObject
    {
        public T Parse(IDictionary dic)
        {
            if (dic == null || dic.Count == 0)
                throw new ArgumentNullException(nameof(dic));

            T rsp = null;

            try
            {
                var jsonText = JsonConvert.SerializeObject(dic);
                rsp = JsonConvert.DeserializeObject<T>(jsonText);
            }
            catch { }

            if (rsp == null)
                rsp = Activator.CreateInstance<T>();

            return rsp;
        }
    }
}
