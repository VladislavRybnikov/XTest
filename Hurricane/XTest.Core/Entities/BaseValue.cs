using Hurricane.XTest.Core.Abstract.Entities;

namespace Hurricane.XTest.Core.Entities
{
   public class BaseValue : IBaseValue
    {
        public string Value { get; set; }
    }

    public class  MatrixValue : BaseValue, IMatrixValue
    {
       public string[][] Matrix { get; set; }
    }
}
