using System;

namespace YLDTest.Model
{
    public class ObjList<T>
    {
        public Func<T, T[], T> FunctionObj;
        public T[] AdditionalArgs;
    }
}