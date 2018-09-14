using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Abstract.Entities;
using XTest.Core.Abstract.Entities.Common;

namespace XTest.Core.Abstract.Processors
{
    public interface IGenerateProcess
    {
        IDataResult<ICollection<IBaseTestEntity>> GetBaseTests();

        IDataResult<ICollection<IQuestionEntity>> GetQuestions(string nameTest);

        IDataResult<string> GetTheotry(string nameTest);
    }
}
