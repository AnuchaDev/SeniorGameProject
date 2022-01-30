using System;
using System.Collections;
using System.Collections.Generic;
using GameDev.Saving;
using UnityEngine;

namespace RPG.Inventories
{
    public class Purse : MonoBehaviour,ISaveable
    {
        [SerializeField] float startingBalance = 400f;

        float balance = 0;

        public event Action onChange;

        private void Awake()
        {
            balance = startingBalance;
            //print($"Balance:{balance}");
        }

        public float GetBalance()
        {
            return balance;
        }

        public void UpdateBalance(float amount)
        {
            balance += amount;
            //print($"Balance:{balance}");
            if(onChange != null)
            {
                onChange();
            }
        }

        public object CaptureState()
        {
            return balance;
        }

        public void RestoreState(object state)
        {
            balance = (float)state;
        }

    }

}