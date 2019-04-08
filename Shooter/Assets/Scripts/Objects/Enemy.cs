using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains.Objects
{
    public class Enemy : BaseObjectScene
    {
        [SerializeField] protected float _hp = 100;
        protected bool _isDead = false;
    }
}
