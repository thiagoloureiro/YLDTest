using System;
using System.Collections.Generic;
using YLDTest.Interface;
using YLDTest.Model;

namespace YLDTest.Class
{
    public class Evaluator<T> : IEvaluator<T>
    {
        private readonly List<ObjList<T>> _lstObj;

        public Evaluator()
        {
            _lstObj = new List<ObjList<T>>();
        }

        public void Add(Func<T, T[], T> func, params T[] additionalArgs)
        {
            _lstObj.Add(new ObjList<T>
            {
                FunctionObj = func,
                AdditionalArgs = additionalArgs
            });
        }

        public T Evaluate(T seed)
        {
            var _ret = seed;

            foreach (var func in _lstObj)
            {
                _ret = func.FunctionObj(_ret, func.AdditionalArgs);
            }
            return _ret;
        }
    }
}