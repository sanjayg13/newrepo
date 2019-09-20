using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChatBotDBAccess;
using System.Linq;

namespace MonitorWebServiceTest
{
    [TestClass]
    public class QuestionControllerTester
    {
        [TestMethod]
        public void TestQuestionController()
        {
            //string MonitorCategoryChoice = "Choose the Category of monitor that you want to view?";
            string CategorySpecificationChoice = "Do you want monitor based on category or specification?";
            string MonitorCategoryChoice = "Choose the category you want to view??";
            string MonitorSolutionChoice = "Do you want information about patient monitors or solutions?";
            string MonitorSpec1 = "Choose the first specification you want?";
            string MonitorSpec2 = "Choose the second Specification you want?";
            string MonitorSpecsCategory = "Choose the monitor model you ae interested in?";
            string ProductChoice = "Choose the specification you are interested in?";

            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                var entity1 = entities.Questions.Where(e => e.QuestionName == "CategorySpecificationChoice").Select(Columns => Columns.Question1).ToList();
                Assert.AreEqual(entity1[0].Trim(), CategorySpecificationChoice.Trim());
                var entity2 = entities.Questions.Where(e => e.QuestionName == "MonitorSolutionChoice").Select(Columns => Columns.Question1).ToList();
                Assert.AreEqual(entity2[0], MonitorSolutionChoice.Trim());
                var entity3 = entities.Questions.Where(e => e.QuestionName == "MonitorSpec1").Select(Columns => Columns.Question1).ToList();
                Assert.AreEqual(entity3[0], MonitorSpec1.Trim());
                var entity4 = entities.Questions.Where(e => e.QuestionName == "MonitorSpec2").Select(Columns => Columns.Question1).ToList();
                Assert.AreEqual(entity4[0], MonitorSpec2.Trim());
                var entity5 = entities.Questions.Where(e => e.QuestionName == "MonitorSpecsCategory").Select(Columns => Columns.Question1).ToList();
                Assert.AreEqual(entity5[0], MonitorSpecsCategory.Trim());
                var entity6 = entities.Questions.Where(e => e.QuestionName == "ProductChoice").Select(Columns => Columns.Question1).ToList();
                Assert.AreEqual(entity6[0], ProductChoice.Trim());
                var entity7 = entities.Questions.Where(e => e.QuestionName == "MonitorCategoryChoice").Select(Columns => Columns.Question1).ToList();
                Assert.AreEqual(entity7[0], MonitorCategoryChoice.Trim());


            }
        }
    }
}
