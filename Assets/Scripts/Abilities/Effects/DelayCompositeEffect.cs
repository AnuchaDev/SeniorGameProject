using System;
using System.Collections;
using System.Collections.Generic;
using RPG.Abilities;
using UnityEngine;

namespace RPG.Attributes.Effects
{
    [CreateAssetMenu(fileName = "Delay Composite Effect", menuName = "Abilities/Effects/Delay Composite", order = 0)]
    public class DelayCompositeEffect : EffectStrategy
    {
        [SerializeField] float delay = 0;
        [SerializeField] EffectStrategy[] delayedEffects;

        public override void StartEffect(AbilityData data, Action finished)
        {
            data.StartCoroutine(DelayEffect(data, finished));
        }

        private IEnumerator DelayEffect(AbilityData data, Action finished)
        {
            yield return new WaitForSeconds(delay);
            foreach(var effect in delayedEffects)
            {
                effect.StartEffect(data, finished);
            }
        }


    }

}