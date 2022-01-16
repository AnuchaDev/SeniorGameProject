using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDev.Inventories;

namespace GameDev.UI.Inventories
{

    public interface IItemHolder
    {
        InventoryItem GetItem();
    }
}