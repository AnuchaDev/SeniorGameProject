using System;
using System.Collections;
using System.Collections.Generic;
using RPG.Abilities;
using UnityEngine;

namespace RPG.Attributes.Targeting
{
    [CreateAssetMenu(fileName = "Self Targeting", menuName = "Abilities/Targeting/Self", order = 0)]
    public class SelfTargeting : TargetingStrategy
    {
        public override void StartTargeting(AbilityData data, Action finished)
        {
            data.SetTargets(new GameObject[] { data.GetUser() });
            data.SetTargetedPoint(data.GetUser().transform.position);
            finished();
        }
    }

}