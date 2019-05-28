using UnityEngine;

namespace Codebycandle.DynamicCamDemo
{
    public class AppManager:MonoBehaviour
    {
        #region VAR
        [SerializeField] private LevelZoneController zoneController;
        [SerializeField] private CameraController camController;
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
            AddZoneListener();
        }

        private void AddZoneListener()
        {
            zoneController.OnZoneTrigger += HandleZoneTrigger;
        }
        #endregion

        #region HANDLER
        private void HandleZoneTrigger(int index)
        {
            camController.SetActiveCam(index);
        }
        #endregion
    }
}