  
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ChatBotDBAccess;


namespace MonitorWebServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        
        public void TestGetSeries()
        {
            //Dictionary<string, List<string>> TestDssict1 = new Dictionary<string, List<string>>();
            List<string> TestList1 = new List<string>() { "MX400", "MX450", "MX500", "MX550", "MX700", "MX800", "MP2", "MP5" };
            List<string> TestList2 = new List<string>() { "CL", "FM20", "FM30", "FM40", "FM50" };
            List<string> TestList3 = new List<string>() { "CM Series", "CMS200" };
            List<string> TestList4 = new List<string>() { "VM1", "VM4", "VM6", "VM8", "VSI", "VS2+" };
            using (ChatBotDBEntities entities = new ChatBotDBEntities())
            {
                Assert.AreEqual(1, 1);
                Assert.AreEqual(TestList2, entities.Monitors.Where(e => e.SeriesName.ToLower() == "avalon").Select(Column => Column.ModelNo).ToList());
                //Assert.AreEqual(TestList2, entities.Monitors.Where(e => e.SeriesName.ToLower() == "avalon").Select(Column => Column.ModelNo).ToList<string>());
                //Assert.AreEqual(obj.GetSeries("avalon"), TestList2.ToList());
                //Assert.AreEqual(obj.GetSeries("efficia"), TestList3.ToList());
                //Assert.AreEqual(obj.GetSeries("suresigns"), TestList4.ToList());

                // Assert.AreEqual(entities.Monitors.Where(e => e.SeriesName == "intellivue").ToList(), TestList1);


            }
        }

    }
}
