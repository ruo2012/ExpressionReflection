using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ExpressionReflection {
    public static class MethodInfoExtensions {
        public static object Invoke(this MethodBase methodBase,params object[] parameters) {
            return methodBase.Invoke(null,parameters);
        }
        public static Func<object[],object> ToDelegate(this MethodInfo info,object instance = null) { 
            return delegate (object[] parameters) {
                return info.Invoke(instance, parameters);
            };
        }
    }
}
