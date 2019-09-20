using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChatBotDBAccess;
using System.Linq;

namespace MonitorWebServiceTest
{
    /// <summary>
    /// Summary description for TestSolutionController
    /// </summary>
    [TestClass]
    public class TestSolutionController
    {
        [TestMethod]
        public void TestGetSolutionType()
        {
            // Dictionary<string, List<string>> TestDssict1 = new Dictionary<string, List<string>>();
            List<string> ClinicalDecisionSupport = new List<string>() { "CDS Online Electronic help" };
            List<string> EWES = new List<string>() { "IGS" };
            List<string> CSA = new List<string>() { "ISAR", "ISEM", "IVIC-Xi" };

            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                var entity1 = entities.Solutions.Where(e => e.Category.ToLower() == "clinical decision support").Select(Column => Column.Name).ToList();
                Assert.AreEqual(ClinicalDecisionSupport[0].Trim(), entity1[0].Trim());
                var entity2 = entities.Solutions.Where(e => e.Category.ToLower() == "ewes").Select(Column => Column.Name).ToList();
                Assert.AreEqual(EWES[0].Trim(), entity2[0].Trim());
                var entity3 = entities.Solutions.Where(e => e.Category.ToLower() == "csa").Select(Column => Column.Name).ToList();
                for (int i = 0; i < CSA.Count; i++)
                    Assert.AreEqual(CSA[i].Trim(), entity3[i].Trim());

            }
        }
        [TestMethod]
        public void TestGetAllSolutions()
        {
            // Dictionary<string, List<string>> TestDssict1 = new Dictionary<string, List<string>>();
            List<string> Solutions = new List<string>() { "Clinical Decision Support", "EWES", "CSA" };


            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {

                var entity = entities.Solutions.Select(Column => Column.Category).ToList();
                for (int i = 0; i < Solutions.Count; i++)
                    Assert.AreEqual(Solutions[i].Trim(), entity[i].Trim());

            }
        }
    }
}
