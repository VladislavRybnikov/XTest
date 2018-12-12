using System;
using Hurricane.XTest.Core.Abstract.Entities;
using Hurricane.XTest.Core.Const.Enums;
using Hurricane.XTest.Core.Entities;

namespace Hurricane.XTest.Core.Processors.Encoders
{
    public class AbramsonCoder : IEncoder
    {
        public static Random _random = new Random();

        public IQuestionEntity QuestionEntity
        {
            get
            {
                return CodeType.Dencoding == CodeType ? Decoder() : Encoder();
            }
            set
            {
            }
        }
        public CodeType CodeType { get; set; }

        public AbramsonCoder(CodeType codeType)
        {
            CodeType = codeType;
        }

        private IQuestionEntity Encoder()
        {
            IQuestionEntity questionEntity = new QuestionEntity();
            questionEntity.QuestionType = QuestionType.Abramson;
            questionEntity.CodeType = CodeType;

            questionEntity.Description = "Закодируйте сообщение";
            questionEntity.Question = new BaseValue()
            { Value = "\t\r 1101010100 \n\n" +
            "Непроводимый полином P1: 11101" };
            questionEntity.Answer = new BaseValue()
            {
                Value = "110101010011010"
            };

            return questionEntity;
        }
        private IQuestionEntity Decoder()
        {
            IQuestionEntity questionEntity = new QuestionEntity();
            questionEntity.QuestionType = QuestionType.Abramson;
            questionEntity.CodeType = CodeType;

            questionEntity.Description = "Закодируйте сообщение";
            questionEntity.Question = new BaseValue()
            {
                Value = "\t\r 011010001000110\n\n" +
            "Непроводимый полином P1: 10111"
            };
            questionEntity.Answer = new BaseValue()
            {
                Value = "110101010011010"
            };

            return questionEntity;
        }
    }
}
