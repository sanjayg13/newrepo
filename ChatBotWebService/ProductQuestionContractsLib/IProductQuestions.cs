using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductQuestionContractsLib
{
    public interface IProductQuestions
    {
        List<string> GetProductQuestion(string questionname);
    }
}
