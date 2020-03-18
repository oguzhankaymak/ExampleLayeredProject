using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Extensions
{
    public static class SessionExtensionMethods
    {
        public static void SetObject(this ISession session,string key,object value)
        {
            string objectString = JsonConvert.SerializeObject(value);
            session.SetString(key, objectString);
        }
         
        public static T GetObject<T>(this ISession session,string key) where T : class
        {
            string objectString = session.GetString(key);
            if (string.IsNullOrEmpty(objectString))
            {
                return null;
            }   
            else
            {
                T value = JsonConvert.DeserializeObject<T>(objectString);
                return value;
            }
        }
    }
}
