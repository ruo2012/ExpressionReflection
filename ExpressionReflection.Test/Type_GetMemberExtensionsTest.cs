using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressionReflection.Test {
    [TestClass]
    public class Type_GetMemberExtensionsTest {
        [TestMethod]
        public void GetMemberTest() {
            List<int> test = new List<int>();
            Assert.IsNotNull(
                typeof(List<int>).GetMember<List<int>>(x => x.Count));
            Assert.IsNotNull(
                typeof(List<int>).GetMember(x => new List<int>()));
            Assert.IsNotNull(
                typeof(List<int>).GetMember<List<int>>(x => x.Clear()));
            Assert.IsNotNull(
                typeof(List<int>).GetMember<List<int>>(x => x.Sum()));

            Assert.IsNotNull(
                test.GetMember(x => x.Count));
            Assert.IsNotNull(
                test.GetMember(x => new List<int>()));
            Assert.IsNotNull(
                test.GetMember<List<int>>(x => x.Clear()));
            Assert.IsNotNull(
                test.GetMember<List<int>>(x => x.Sum()));
        }
    }
}
