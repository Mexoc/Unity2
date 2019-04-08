using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains.Objects
{
    public abstract class Weapon : BaseObjectScene
    {
        [SerializeField] protected Transform _gun;

        [SerializeField] protected float _force = 500;

        [SerializeField] protected float _rechargeTime = 0.2f;

        protected bool _fire = true;
        protected Timer _recharge = new Timer();

        public abstract void Fire(Ammunition ammunition);

        protected virtual void Update()
        {
            _recharge.Update();
            if (_recharge.IsEvent())
            {
                _fire = true;
            }
        }  
    }
}

