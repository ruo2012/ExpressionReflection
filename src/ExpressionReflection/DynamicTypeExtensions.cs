using ExpressionReflection;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace ExpressionReflection{
    public static class DynamicTypeExtensions {
        /// <summary>
        /// 轉換為動態物件，僅欄位與屬性
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="onlyPublic">僅為public屬性與欄位</param>
        /// <returns>動態物件</returns>
        public static ExpandoObject ToExpando(this object obj, bool onlyPublic = true) {
            ExpandoObject result = new ExpandoObject();
            IDictionary<string, object> dict = result;
            BindingFlags flag = 
                BindingFlags.Instance |
                BindingFlags.Public;
            if (!onlyPublic) flag |= BindingFlags.NonPublic;
            var allMembers = obj.GetType().GetMembers(flag);

            foreach(var member in allMembers) {
                if (member is FieldInfo) {
                    dict.Add(member.Name,((FieldInfo)member).GetValue(obj));
                } else if (member is PropertyInfo && 
                    ((PropertyInfo)member).GetIndexParameters().Length == 0) {
                    dict.Add(member.Name, ((PropertyInfo)member).GetValue(obj));
                }
            }
            return result;
        }
    }
}
