using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev.UI
{
    public class ShowHideUI : MonoBehaviour
    {
        [SerializeField] KeyCode toggleKey = KeyCode.Escape;
        [SerializeField] GameObject uiContainer = null;

        // Start is called before the first frame update
        void Start()
        {
            uiContainer.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(toggleKey))
            {
                toggle();
            }
        }

        public void toggle()
        {
            uiContainer.SetActive(!uiContainer.activeSelf);
        }
    }
}