using UnityEngine;
using GameDev.Utils;
using RPG.Core;

namespace GameDev.Inventories
{

    [CreateAssetMenu(menuName = ("GameDev/GameDev.UI.InventorySystem/Equipable Item"))]
    public class EquipableItem : InventoryItem
    {
        // CONFIG DATA
        [Tooltip("Where are we allowed to put this item.")]
        [SerializeField] EquipLocation allowedEquipLocation = EquipLocation.Weapon;
        [SerializeField] Condition equipCondition;

        // PUBLIC
        public bool CanEquip(EquipLocation equipLocation,Equipment equipment)
        {
            if (equipLocation != allowedEquipLocation) return false;

            return equipCondition.Check(equipment.GetComponents<IPredicateEvaluator>());
        }

        public EquipLocation GetAllowedEquipLocation()
        {
            return allowedEquipLocation;
        }
    }
}