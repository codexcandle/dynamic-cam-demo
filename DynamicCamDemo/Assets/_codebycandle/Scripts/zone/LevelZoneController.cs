using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Codebycandle.DynamicCamDemo
{
    public class LevelZoneController:MonoBehaviour
    {
        #region VAR
        public Action<int> OnZoneTrigger;

        private LevelZone[] zones;
        #endregion

        #region MONO-BEHAVIOUR
        void Start()
        {
            Init();
        }
        #endregion

        #region UTIL-PRIVATE
        private void Init()
        {
            FindVars();

            AddListeners();
        }

        private void FindVars()
        {
            LevelZone[] items = GetComponentsInChildren<LevelZone>();

            // set view index
            for(int i = 0; i < items.Length; i++)
            {
                items[i].Init(i);
            }

            zones = items;
        }

        private void AddListeners()
        {
            foreach(var zone in zones)
            {
                zone.OnZoneTrigger += HandleZoneTrigger;
            }
        }        
        #endregion

        #region HANDLER
        private void HandleZoneTrigger(int index)
        {
            if(OnZoneTrigger != null)
            {
                OnZoneTrigger(index);
            }
        }
        #endregion
    }
}