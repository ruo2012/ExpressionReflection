using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ExpressionReflection {
    public static class MethodInfoExtensions {
        /// <summary>
        /// 用指定的參數，叫用目前執行個體所表示的方法或建構函式。
        /// </summary>
        /// <param name="methodBase"></param>
        /// <param name="parameters">參數</param>
        /// <returns>結果</returns>
        public static object Invoke(this MethodBase methodBase, params object[] parameters) {
            return methodBase.Invoke(null, parameters);
        }

        /// <summary>
        /// 嘗試將MemberInfo轉換為MethodInfo並用指定的參數，叫用目前執行個體所表示的方法或建構函式。
        /// </summary>
        /// <param name="info"></param>
        /// <param name="instance">實體</param>
        /// <param name="result">結果</param>
        /// <param name="parameters">參數</param>
        /// <returns>是否成功引動</returns>
        public static bool AsInvoke(this MemberInfo info, object instance, out object result, params object[] parameters) {
            if (info is MethodInfo) {
                try {
                    result = ((MethodInfo)info).Invoke(instance, parameters);
                } catch {
                    result = null;
                    return false;
                }
                return true;
            } else {
                result = default(object);
                return false;
            }
        }

        /// <summary>
        /// 將目前執行個體所表示的方法或建構函式轉換為Func委派。
        /// </summary>
        /// <param name="info"></param>
        /// <param name="instance">實體</param>
        /// <returns>結果</returns>
        public static Func<object[], object> ToDelegate(this MethodInfo info, object instance = null) {
            return delegate (object[] parameters) {
                return info.Invoke(instance, parameters);
            };
        }
    }
}
