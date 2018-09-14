using System;
using System.Collections.Generic;
using System.Text;
using XTest.Core.Const.Enums;
using XTest.Core.Entities;

namespace XTest.Core.Abstract.Entities.Config
{
   public static class ConfigTest
    {
        public static List<IBaseTestEntity> TestEntities { get; set; } = new List<IBaseTestEntity>();

        static ConfigTest()
        {
            Init();
        }

        private static void Init()
        {
            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Код Эллайеса",
                GroupType = GroupType.SestemCodes,
                CountDecodTest = 5,
                CountEncodTest=5,
                QuestionType = QuestionType.Ellieas
            });

            TestEntities.Add(new BaseTestEntity()
            {
                Name = "Код Варшамова",
                GroupType = GroupType.SestemCodes,
                CountDecodTest = 5,
                CountEncodTest = 5,
                QuestionType = QuestionType.Ellieas
            }); 

        }
    }
}
