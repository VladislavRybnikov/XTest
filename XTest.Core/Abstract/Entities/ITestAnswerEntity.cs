using System;
using System.Collections.Generic;
using System.Text;

namespace XTest.Core.Abstract.Entities
{
    public interface ITestAnswerEntity
    {
        //string UserName { get; set; }
        //ITestEntity Test { get; set; }
        //ICollection<IQuestionEntity> Answers { get; set; }
        IBaseValue Answer { get; set; }
        IQuestionEntity QuestionEntity { get; set; }
    }
}
