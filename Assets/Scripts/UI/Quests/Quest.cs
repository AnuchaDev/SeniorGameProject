using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Quests
{
    [CreateAssetMenu(fileName ="Quest",menuName = "RPG Project/Quest",order = 0)]
    public class Quest : ScriptableObject
    {
        [SerializeField] string[] objective;

        public string GetTitle()
        {
            return name;
        }

        public int GetObjectiveCount()
        {
            return objective.Length;
        }
    }

}