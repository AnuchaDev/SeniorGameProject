using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev.Utils
{
    public interface IPredicateEvaluator
    {
        bool? Evaluate(string predicate, string[] parameters);
    }

}