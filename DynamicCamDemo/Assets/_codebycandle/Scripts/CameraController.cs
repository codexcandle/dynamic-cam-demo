using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Codebycandle.DynamicCamDemo
{
    public class CameraController:MonoBehaviour, ICameraController
    {
        #region VAR
        private Camera[] cams;
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
        }

        private void FindVars()
        {
            cams = GetComponentsInChildren<Camera>();
        }
        #endregion

        #region UTIL-PUBLIC
        public void SetActiveCam(int index)
        {
            for(int i = 0; i < cams.Length; i++)
            {
                cams[i].enabled = (i == index);
            }
        }
        #endregion
    }
}