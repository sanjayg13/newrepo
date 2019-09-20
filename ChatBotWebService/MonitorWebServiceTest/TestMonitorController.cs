
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;
using System.Linq;
using ChatBotDBAccess;
using System.Diagnostics;

namespace MonitorWebServiceTest
{
   
    [TestClass]
    public class TestMonitorController
    {
        [TestMethod]
        public void TestGetSeries()
        {
            // Dictionary<string, List<string>> TestDssict1 = new Dictionary<string, List<string>>();
            List<string> TestList1 = new List<string>() { "MX400  ", "MX450  ", "MX500  ", "MX550  ", "MX700  ", "MX800  ", "MP2  ", "MP5  " };
            List<string> TestList2 = new List<string>() { "C L", "FM20", "FM30", "FM40", "FM50" };
            List<string> TestList3 = new List<string>() { "CM Series", "CMS200" };
            List<string> TestList4 = new List<string>() { "VM1", "VM4", "VM6", "VM8", "VSI", "VS2+" };
            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                var entity1 = entities.Monitors.Where(e => e.SeriesName.ToLower() == "intellivue").Select(Column => Column.ModelNo).ToList<string>();
                Assert.AreEqual(TestList1[0].Trim(), entity1[0].Trim());
                var entity2 = entities.Monitors.Where(e => e.SeriesName.ToLower() == "avalon").Select(Column => Column.ModelNo).ToList<string>();
                Assert.AreEqual(TestList2[0].Trim(), entity2[0].Trim());
                var entity3 = entities.Monitors.Where(e => e.SeriesName.ToLower() == "efficia").Select(Column => Column.ModelNo).ToList<string>();
                Assert.AreEqual(TestList3[1].Trim(), entity3[1].Trim());

            }
        }

        [TestMethod]
        public void TestGetPortableMonitor()
        {
            List<string> TestList1 = new List<string>() { "MX400", "MX450", "MX500", "MX550", "MP2", "MP5", "VM1", "VM4", "VM6", "VM8", "VSI", "C L", "FM20", "FM30", "FM40", "FM50" };
            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                var entity = entities.Monitors.Where(e => e.Spec1.ToLower() == "portable").Select(Column => Column.ModelNo).ToList<string>();
                for (int i = 0; i < TestList1.Capacity; i++)
                    Assert.AreEqual(TestList1[i].Trim(), entity[i].Trim());
            }
        }

        [TestMethod]
        public void TestGetNonPortableMonitor()
        {
            List<string> TestList1 = new List<string>() { "MX700", "MX800", "VS2+", "CM Series", "CMS200" };
            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                var entity = entities.Monitors.Where(e => e.Spec1.ToLower() == "non-portable").Select(Column => Column.ModelNo).ToList<string>();
                for (int i = 0; i < TestList1.Count; i++)
                    Assert.AreEqual(TestList1[i].Trim(), entity[i].Trim());
            }
        }

        [TestMethod]
        public void TestGetMonitorOnSize()
        {
            List<string> TestList1 = new List<string>() { "MX700", "MX800", "VS2+", "CM Series", "CMS200" };
            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                var entity = entities.Monitors.Where(e => e.Spec1.ToLower() == "non-portable").Select(Column => Column.ModelNo).ToList<string>();
                for (int i = 0; i < TestList1.Count; i++)
                    Assert.AreEqual(TestList1[i].Trim(), entity[i].Trim());
            }
        }

        [TestMethod]
        public void TestGetMonitorOnSizeAndPortablity()
        {
            List<string> TestList1 = new List<string>() { "MP2", "C L" };
            List<string> TestList2 = new List<string>() { "MP5", "VSI" };
            List<string> TestList3 = new List<string>() { "MX400", "VM1", "VM4" };
            List<string> TestList4 = new List<string>() { "MX450", "MX500", "VM6", "VM8", "FM20", "FM30" };
            List<string> TestList5 = new List<string>() { "MX550", "FM40", "FM50" };
            List<string> TestList6 = new List<string>() { "MX700", "MX800", "CM Series" };
            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                var entity1 = entities.Monitors.Where(e => e.Spec2.ToLower() == "4.5' touch screen").Where(e => e.Spec1.ToLower() == "portable").Select(Column => Column.ModelNo).ToList(); ;
                for (int i = 0; i < TestList1.Count; i++)
                    Assert.AreEqual(TestList1[i].Trim(), entity1[i].Trim());

                var entity2 = entities.Monitors.Where(e => e.Spec2.ToLower() == "5.5' touch screen").Where(e => e.Spec1.ToLower() == "portable").Select(Column => Column.ModelNo).ToList(); ;
                for (int i = 0; i < TestList2.Count; i++)
                    Assert.AreEqual(TestList2[i].Trim(), entity2[i].Trim());

                var entity3 = entities.Monitors.Where(e => e.Spec2.ToLower() == "9' touch screen").Where(e => e.Spec1.ToLower() == "portable").Select(Column => Column.ModelNo).ToList(); ;
                for (int i = 0; i < TestList3.Count; i++)
                    Assert.AreEqual(TestList3[i].Trim(), entity3[i].Trim());

                var entity4 = entities.Monitors.Where(e => e.Spec2.ToLower() == "12' touch screen").Where(e => e.Spec1.ToLower() == "portable").Select(Column => Column.ModelNo).ToList(); ;
                for (int i = 0; i < TestList4.Count; i++)
                    Assert.AreEqual(TestList4[i].Trim(), entity4[i].Trim());

                var entity5 = entities.Monitors.Where(e => e.Spec2.ToLower() == "15' touch screen").Where(e => e.Spec1.ToLower() == "portable").Select(Column => Column.ModelNo).ToList(); ;
                for (int i = 0; i < TestList5.Count; i++)
                    Assert.AreEqual(TestList5[i].Trim(), entity5[i].Trim());


                var entity6 = entities.Monitors.Where(e => e.Spec2.ToLower() == "15' touch screen").Where(e => e.Spec1.ToLower() == "non-portable").Select(Column => Column.ModelNo).ToList(); ;
                for (int i = 0; i < TestList6.Count; i++)
                    Assert.AreEqual(TestList6[i].Trim(), entity6[i].Trim());


            }
        }
        [TestMethod]
        public void TestGetMoniorCategory()
        {
            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                var entity = entities.Monitors.Select(Column => Column.Category).Distinct().ToList();
                List<string> TestList1 = new List<string>() { "bedside monitor", "high end monitors", "maternity and fetal monitor", "vital signs monitor" };
                for (int i = 0; i < TestList1.Count; i++)
                    Assert.AreEqual(TestList1[i].Trim(), entity[i].Trim());
            }
        }


    }
}
