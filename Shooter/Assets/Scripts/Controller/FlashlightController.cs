using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Geekbrains.Controller
{
    public sealed class FlashlightController : BaseController
    {
        private Light _light;
        private string flashlightText;
        private int flashlightCharge = 100;

        private void Awake()
        {
            _light = GameObject.Find("Flashlight").GetComponent<Light>();
            flashlightText = GameObject.Find("flashlightText").GetComponent<Text>().text;
        }

        public void Start()
        {
            SetFlashlightActive(false);
            flashlightText = "Заряд фонарика: " + flashlightCharge.ToString();
        }

        private void Update()
        {
            if (!Enable)
                return;
        }

        private void SetFlashlightActive(bool value)
        {
            _light.enabled = value;
        }

        public override void On()
        {
            //if (Enable) return;
            base.On();
            SetFlashlightActive(true);
        }

        private void FixedUpdate()
        {
            if (_light.enabled)
            {
                flashlightCharge--;
            }
            else if (!_light.enabled && flashlightCharge<100)
            {
                flashlightCharge++;
            }
        }

        public override void Off()
        {
            //if (!Enable) return;
            base.On();
            SetFlashlightActive(false);
        }
    }
}

