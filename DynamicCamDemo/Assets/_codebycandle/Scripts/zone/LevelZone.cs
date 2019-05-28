using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Codebycandle.DynamicCamDemo
{
    public class LevelZone:MonoBehaviour
    {
        public Action<int> OnZoneTrigger;

        private bool initialized;

        public int viewIndex
        {
            get;
            private set;
        }

        public void Init(int index)
        {
            // sanitize
            if(index < 0) return;

            this.viewIndex = index;

            initialized = true;
        }

        public void OnTriggerEnter(Collider col)
        {
            if(OnZoneTrigger != null)
            {
                // sanitize
                if(!initialized) return;

                // notify
                OnZoneTrigger(viewIndex);
            }
        }
    }
}