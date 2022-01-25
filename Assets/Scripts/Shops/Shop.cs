using System;
using System.Collections;
using System.Collections.Generic;
using GameDev.Inventories;
using RPG.Control;
using UnityEngine;

namespace RPG.Shops
{
    public class Shop : MonoBehaviour,IRaycastable
    {
        [SerializeField] string shopName;

        public event Action onChange;

        public IEnumerable<ShopItem> GetFilteredItems()
        {
            yield return new ShopItem(InventoryItem.GetFromID("44a49af5-08e9-44ac-96b0-718d83d684ab"),1,10.0f,0);
            yield return new ShopItem(InventoryItem.GetFromID("bea16a60-22e5-46c4-9bf6-cbe763e76ea4"), 102, 1000.0f, 0);
            yield return new ShopItem(InventoryItem.GetFromID("8fa70a77-5749-4b1e-90ce-1efdf7328288"), 20, 200000.0f, 0);
            yield return new ShopItem(InventoryItem.GetFromID("eee23140-eb14-43a2-b9c8-31fae67bc13f"), 10, 7.0f, 0);

        }
        public void SelectFilter(ItemCategory category) { }
        public ItemCategory GetFiilter() { return ItemCategory.None; }
        public void SelectMode(bool isBuying) { }
        public bool IsBuyingMode() { return true; }
        public bool CanTransact() { return true; }
        public void ConfirmTransaction() { }
        public float TransactionTotal() { return 0; }

        public string GetShopName()
        {
            return shopName;
        }

        public void AddToTransaction(InventoryItem item, int quantity) { }

        public CursorType GetCursorType()
        {
            return CursorType.Shop;
        }

        public bool HandleRaycast(PlayerController callingController)
        {
            if (Input.GetMouseButtonDown(0))
            {
                callingController.GetComponent<Shopper>().SetActiveShop(this);
            }
            return true;
        }
    }


}