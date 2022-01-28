using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace RPG.Abilities.Filters
{
    [CreateAssetMenu(fileName = "TagFilter", menuName = "Abilities/Filters/Tag", order = 0)]
    public class TagFilter : FilterStrategy
    {
        [SerializeField] string tagToFilter = "";

        public override IEnumerable<GameObject> Filter(IEnumerable<GameObject> objectsToFilter)
        {
            foreach(var gameObject in objectsToFilter)
            {
                if(gameObject.CompareTag(tagToFilter))
                {
                    yield return gameObject;
                }
            }
        }
    }
}