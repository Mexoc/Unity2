using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains.Objects
{
    public class Bullet : Ammunition
    {        
        [SerializeField] private float _timeToDestroy = 10; // Время жизни пули
        [SerializeField] private float _damage = 20;     // Урон пули
        [SerializeField] private float _mass = 0.01f;    // Масса пули        
        private float _currentDamage; // Текущий урон пули

        public override void Awake()
        {
            base.Awake();
            // Если пуля не встретит ничего, то через заданное время пуля самоуничтожится
            Destroy(_instanceObject, _timeToDestroy);
            _currentDamage = _damage;
            _rigidbody.mass = _mass;
        }

        // Если пуля встретила препятствие
        private void OnCollisionEnter(Collision collision)
        {  // Если столкнулись с другой пулей, то ничего не делаем
            if (collision.collider.tag == "Bullet") return;
            // Функция нанесения урона
            SetDamage(collision.gameObject.GetComponent<ISetDamage>());
            Destroy(_instanceObject);          // Удаляем пулю
        }

        private void SetDamage(ISetDamage damageObj)
        {
            damageObj.TakeDamage(_currentDamage);        
        }
    }
}

