using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Geekbrains.Objects;

namespace Geekbrains.Controller
{
    public class InputController : BaseController
    {
        private bool _isActiveFlaslight = false;
        private int _indexWeapon;
        private bool _weaponIsSelected = true;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                _isActiveFlaslight = !_isActiveFlaslight;
                if (_isActiveFlaslight)
                {
                    Main.Instance.GetFlashLight.On();
                }
                else
                {
                    Main.Instance.GetFlashLight.Off();
                }
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _indexWeapon = 1;
                _weaponIsSelected = false;
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                _indexWeapon = 2;
                _weaponIsSelected = false;
            }

            if (!_weaponIsSelected)
            {
                if (Main.Instance.GetObjectManager.GetWeapons[_indexWeapon])
                {
                    Main.Instance.GetWeaponController.On(Main.Instance.GetObjectManager.GetWeapons[_indexWeapon], Main.Instance.GetObjectManager.GetAmmunition[_indexWeapon]);                    
                }
                _weaponIsSelected = true;
            }
        }
    }
}

