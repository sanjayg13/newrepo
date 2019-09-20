using ChatBotDBAccess;
using ProductQuestionContractsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductQuestionLib
{
    public class ProductQuestion : IProductQuestions
    {
        public List<string> GetProductQuestion(string questionname)
        {
            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                return (entities.Questions.Where(e => e.QuestionName.ToLower() == questionname.ToLower()).Select(Column => Column.Question1).ToList());
            }
        }
    }
}
