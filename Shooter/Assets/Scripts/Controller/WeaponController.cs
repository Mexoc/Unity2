using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Geekbrains.Objects;

namespace Geekbrains.Controller
{
    public class WeaponController : BaseController
    {
        private Weapon _weapon;
        private Ammunition _ammunition;

        public Weapon SelectedWeapon
        {
            get { return _weapon; }
        }

        private void Update()
        {
            if (!Enable)
                return;
            if (Input.GetKey(KeyCode.Mouse0))
                SelectedWeapon.Fire(_ammunition);
        }

        public virtual void On(Weapon weapon, Ammunition ammunition)
        {
            if (Enable) return;
            base.On();
            _weapon = weapon;
            _ammunition = ammunition;
            _weapon.IsVisible = true;
        }

        public override void Off()
        {
            if (!Enable) return;
            base.Off();
            _weapon.IsVisible = false;
            _weapon = null;
            _ammunition = null;
        }
    }
}
