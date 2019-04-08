using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains.Objects
{
    public class Gun : Weapon
    {
        public override void Fire(Ammunition ammunition)
        {
            if (_fire)
            {
                if (ammunition != null)
                {
                    Bullet bul = Instantiate(ammunition, _gun.position, _gun.rotation) as Bullet;
                    if (bul)
                    {
                        bul.GetRigidBody.AddForce(_gun.forward * _force);
                        bul.name = "bullet";
                        _fire = false;
                        _recharge.Start(_rechargeTime);                        
                    }
                }
            }
        }
    }
}

