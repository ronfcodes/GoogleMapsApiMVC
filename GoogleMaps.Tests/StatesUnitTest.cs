using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace GoogleMaps.Tests
{
    /// <summary>
    /// Summary description for StatesUnitTest
    /// </summary>
    [TestClass]
    public class StatesUnitTest
    {
        [TestMethod]
        public void StatesDictionaryGetAllValuesTest()
        {
            Models.States s = new Models.States();
            Dictionary<string,string> dict = s.stateAbbreviationExpand();   
            var value = dict.Values.ToList();

            Assert.IsNotNull(value);
        }
        [TestMethod]
        public void StatesDictionaryGetAllKeysTest()
        {
            Models.States s = new Models.States();
            Dictionary<string, string> dict = s.stateAbbreviationExpand();
            var keys = dict.Keys.ToList();

            Assert.IsNotNull(keys);
        }
        [TestMethod]
        public void StatesDictionarGetValueByKeyTest()
        {
            Models.States s = new Models.States();
            Dictionary<string, string> dict = s.stateAbbreviationExpand();
            string stateName = dict["KY"];

            Assert.AreSame("Kentucky",stateName);
        }
    }
}
