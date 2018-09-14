using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Abstract.Entities;
using XTest.Core.Abstract.Entities.Common;
using XTest.Core.Abstract.Entities.Config;
using XTest.Core.Abstract.Processors;
using XTest.Core.Entities.Common;
using System.Linq;
using XTest.Core.Const.Enums;
using XTest.Core.Processors.Encoders;

namespace XTest.Core.Processors
{
    public class GenerateProcess : IGenerateProcess
    {       
        private readonly BaseEncoderProcess _baseEncoderProcess;

        public GenerateProcess()
        {
            _baseEncoderProcess = new BaseEncoderProcess();
        }

        public IDataResult<ICollection<IBaseTestEntity>> GetBaseTests()
        {
            IDataResult<ICollection<IBaseTestEntity>> methodResult =
                new DataResult<ICollection<IBaseTestEntity>>();

            methodResult.Data = ConfigTest.TestEntities;
            methodResult.Success = true;

            return methodResult;
        }

        public IDataResult<ICollection<IQuestionEntity>> GetQuestions(string nameTest)
        {
            IDataResult<ICollection<IQuestionEntity>> methodResult =
                new DataResult<ICollection<IQuestionEntity>>();

            IBaseTestEntity baseTest = ConfigTest.TestEntities
                .FirstOrDefault(p => p.Name.ToLower().Equals(nameTest.ToLower()));

            if(baseTest==null)
            {
                methodResult.Success = false;

                return methodResult;
            }

            List<IQuestionEntity> questionEntities = new List<IQuestionEntity>();

            switch(baseTest.QuestionType)
            {
                case QuestionType.Ellieas:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest,new EllieasCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new EllieasCoder(CodeType.Dencoding)));
                    break;
                case QuestionType.Varshamova:
                    questionEntities.AddRange(_baseEncoderProcess
                        .GetQuestionsEncoder(baseTest.CountEncodTest, new VarshamovaCoder(CodeType.Encoding)));
                    questionEntities.AddRange(_baseEncoderProcess
                             .GetQuestionsEncoder(baseTest.CountDecodTest, new VarshamovaCoder(CodeType.Dencoding)));
                    break;
            }

            questionEntities.ForEach(p => p.StateType = StateType.Default);

            methodResult.Data = questionEntities;
            methodResult.Success = true;

            return methodResult;

        }

        public IDataResult<string> GetTheotry(string nameTest)
        {
            return null;
        }
    }
}
