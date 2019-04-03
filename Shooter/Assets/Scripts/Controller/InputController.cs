using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains.Controller
{
    public class InputController : BaseController
    {
        private bool _isActiveFlaslight = false;

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
        }
    }
}

