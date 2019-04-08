using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Geekbrains.Controller;
using Geekbrains.Objects;

namespace Geekbrains
{
    public class Main : MonoBehaviour
    {
        private static Main _instance;
        private GameObject _controllerGameObject;
        [SerializeField] private InputController _inputController;
        [SerializeField] private FlashlightController _flashlightController;
        [SerializeField] private WeaponController _weaponController;
        [SerializeField] private ObjectManager _objectManager;

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

        public InputController GetInputController
        {
            get { return _inputController; }
        }

        public WeaponController GetWeaponController
        {
            get { return _weaponController; }
        }

        public ObjectManager GetObjectManager
        {
            get { return _objectManager; }
        }
    }
}

