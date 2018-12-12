﻿using Hurricane.XTest.Core.Const.Enums;

namespace Hurricane.XTest.Core.Abstract.Entities
{
    public interface IQuestionEntity
    {
        string Description { get; set; }
        IBaseValue Question { get; set; }
        IBaseValue Answer { get; set; }
        StateType StateType { get; set; }
        QuestionType QuestionType { get; set; }
        CodeType CodeType { get; set; }
    }

    public interface IBaseValue
    {
        string Value { get; set; }
    }

    public interface IMatrixValue : IBaseValue
    {
        string [][] Matrix { get; set; }
    }
}
