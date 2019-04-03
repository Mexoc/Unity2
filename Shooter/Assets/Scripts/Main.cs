using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Geekbrains.Controller;

namespace Geekbrains
{
    public class Main : MonoBehaviour
    {
        private static Main _instance;

        private GameObject _controllerGameObject;
        private InputController _inputController;
        private FlashlightController _flashlightController;

        private void Awake()
        {
            _instance = this;
        }

        public static Main Instance
        {
            get { return _instance; }
        }

        public FlashlightController GetFlashLight
        {
            get { return _flashlightController; }
        }
    }
}

