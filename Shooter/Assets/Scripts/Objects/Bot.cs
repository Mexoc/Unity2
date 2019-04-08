using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains.Objects
{
    public class Bot : Enemy
    {        
        private float _step = 1;
        private float _speed = 1;

        public void TakeDamage(float damage)
        {
            if (_hp > 0)
            {
                _hp -= damage;
            }
            if (_hp <= 0)
            {
                _hp = 0;
                Color = Color.red;
                _isDead = true;
            }
                
        }

        private void Update()
        {
            if (_isDead)
            {
                Color color = Color;
                if (color.a > 0)
                {
                    color.a -= _step / 100;
                    Color = color;
                }
                if (color.a < 1)
                    Destroy(gameObject);
            }               
        }
    }
}
