using System;
using UnityEngine;

namespace GameDev.Inventories
{

    [CreateAssetMenu(menuName = ("GameDev/GameDev.UI.InventorySystem/Action Item"))]
    public class ActionItem : InventoryItem
    {
        // CONFIG DATA
        [Tooltip("Does an instance of this item get consumed every time it's used.")]
        [SerializeField] bool consumable = false;

        // PUBLIC
        public virtual bool Use(GameObject user)
        {
            Debug.Log("Using action: " + this);
            return false;
        }

        public bool isConsumable()
        {
            return consumable;
        }
    }
}