using System;
using System.Collections.Generic;

namespace YLDTest.Interface
{
    public interface IEvaluator<T>
    {
        void Add(Func<T, T[], T> func, params T[] additionalArgs);

        T Evaluate(T seed);
    }
}